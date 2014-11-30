using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helsedagbok.Forms;

namespace Helsedagbok
{
    public partial class ucWorkout : UserControl
    {
        public static event EventHandler WorkoutDeletedEvent;

        public ucWorkout()
        {
            InitializeComponent();
            Height = 30;
        }

        protected virtual void WorkoutDeleted(EventArgs e)
        {
            EventHandler handler = WorkoutDeletedEvent;
            if (handler != null)
                handler(this, e);
        }

        private DateTime _dateTime;
        private int _idWorkout;
        private List<ucExercise> _exercises = new List<ucExercise>();
        private Point _exerciseLocation = new Point(0, 28);

        public string Title
        {
            get { return lblWorkoutName.Text; }
            set { lblWorkoutName.Text = value; }
        }

        public int IdWorkout
        {
            get { return _idWorkout; }
            set { _idWorkout = value; }
        }

        public List<ucExercise> Exercises
        {
            get { return _exercises; }
            set { _exercises = value; }
        }

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public void GetExercises()
        {
            
            _exerciseLocation.Y = 28;
            foreach (ucExercise ex in _exercises)
            {
                Controls.Remove(ex);
            }
            _exercises.Clear();

            DataTable tblExercises = Workout.GetExersises(IdWorkout);
            foreach (DataRow exerciseRow in tblExercises.Rows)
            {
                ucExercise ex = new ucExercise();
                ex.Title = exerciseRow["Name"].ToString();
                ex.IdExercise = (int)exerciseRow["idWorkoutExercise"];
                ex.IdExerciseType = (int)exerciseRow["idExerciseType"];
                ex.SortOrder = (DBNull.Value.Equals(exerciseRow["SortOrder"]) ? 0 : (int)exerciseRow["SortOrder"]);
                ex.ExerciseUpdatedEvent += SetHeight;
                ex.ExerciseReorderedEvent += SetExerciseOrders;
                _exercises.Add(ex);
                ex.Location = _exerciseLocation;
                Controls.Add(ex);
                ex.GetSets(null, EventArgs.Empty);
                Height += ex.Height;
                _exerciseLocation.Y += ex.Height;
            }
            Exercises[0].DisableUpButton();
            Exercises[Exercises.Count - 1].DisableDownButton();
        }

        private void mAddExercise_Click(object sender, EventArgs e)
        {
            frmEditExercise frm = new frmEditExercise();
            frm.IdWorkout = IdWorkout;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetExercises();
            }
        }

        private void mRenameWorkout_Click(object sender, EventArgs e)
        {
            frmWorkout frm = new frmWorkout();
            frm.IdWorkout = IdWorkout;
            frm.GetWorkout();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Workout.EditWorkout(frm.WorkoutName, frm.WorkoutLocation, DateTime, frm.Duration, IdWorkout);
                Title = frm.WorkoutName;
            }
        }

        private void mDeleteWorkout_Click(object sender, EventArgs e)
        {
            List<Control> remove = new List<Control>();
            foreach (Control cntrl in Controls)
            {
                Type t = cntrl.GetType();
                if (cntrl.GetType() == typeof(ucExercise))
                {
                    ucExercise exercise = (ucExercise)cntrl;
                    exercise.DeleteAllSets();
                    string sql = "DELETE FROM tblWoWorkoutExercises WHERE idWorkout=" + IdWorkout;
                    Functions.RunSql(sql);
                    remove.Add(exercise);
                }
            }
            foreach (Control cntrl in remove)
            {
                Controls.Remove(cntrl);
            }
            string sql2 = "DELETE FROM tblWoWorkouts WHERE idWorkout=" + IdWorkout;
            Functions.RunSql(sql2);
            WorkoutDeleted(EventArgs.Empty);
        }

        private void SetHeight(object sender, EventArgs e)
        {
            Height = 30;
            _exerciseLocation.Y = 28;
            foreach (ucExercise ex in _exercises)
            {
                Height += ex.Height;
                ex.Location = _exerciseLocation;
                _exerciseLocation.Y += ex.Height;
            }
        }

        private void SetExerciseOrders(object sender, ReorderExercisesEventArgs e)
        {
            bool moveUp = (e.NewPosition < e.OldPosition);
            ucExercise exSender = (ucExercise) sender;
            List<ucExercise> tempList = new List<ucExercise>();
            if (moveUp)
            {
                foreach (ucExercise ex in Exercises)
                {
                    if ((ex.SortOrder + 1) == exSender.SortOrder)
                    {
                        ex.SortOrder = exSender.SortOrder;
                        exSender.SortOrder -= 1;
                        tempList.Add(ex);
                        ex.SaveSortOrder(ex.SortOrder);
                        exSender.SaveSortOrder(exSender.SortOrder);
                    }
                    else if (ex == exSender)
                        tempList.Insert(ex.SortOrder - 1, ex);
                    else
                    {
                        tempList.Add(ex);
                    }

                }
            }
            else
            {
                foreach (ucExercise ex in Exercises)
                {
                    if ((ex.SortOrder - 1) == exSender.SortOrder)
                    {
                        exSender.SortOrder = ex.SortOrder;
                        ex.SortOrder -= 1;
                        tempList.Add(ex);
                    }
                    else if (ex == exSender)
                        tempList.Insert(ex.SortOrder - 1, ex);
                    else
                    {
                        tempList.Add(ex);
                    }
                }
            }
            SortExercises(tempList);
        }

        private void SortExercises(List<ucExercise> tempList)
        {
            ucExercise tempExercise;
            int n = 1;
            int max = _exercises.Count;
            bool noChange = true;

            do
            {
                for (int i = 0; i < max - n; i++)
                {
                    if (tempList[i].SortOrder > tempList[i + 1].SortOrder)
                    {
                        tempExercise = tempList[i];
                        tempList[i] = tempList[i + 1];
                        tempList[i + 1] = tempExercise;
                        noChange = false;
                    }
                }
                n += 1;
            } while (!noChange);

            _exerciseLocation.Y = 28;
            foreach (ucExercise ex in tempList)
            {
                ex.Location = _exerciseLocation;
                ex.EnableButtons();
                _exerciseLocation.Y += ex.Height;
            }
            
            Exercises = tempList;
            Exercises[0].DisableUpButton();
            Exercises[Exercises.Count - 1].DisableDownButton();
        }
    }
}
