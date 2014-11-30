using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helsedagbok
{
    public partial class ucExercise : UserControl
    {
        public event EventHandler ExerciseCountChangedEvent;
        public event EventHandler ExerciseUpdatedEvent;
        public event EventHandler<ReorderExercisesEventArgs> ExerciseReorderedEvent;

        private int _idExercise;
        private int _idExerciseType;
        private int _sortOrder;
        private List<ucSet> _sets=new List<ucSet>();
        private Point _setLocation = new Point(0, 22);

        protected virtual void ExerciseCountChanged(EventArgs e)
        {
            EventHandler handler = ExerciseCountChangedEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void ExerciseUpdated(EventArgs e)
        {
            EventHandler handler = ExerciseUpdatedEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void ExerciseReordered(ReorderExercisesEventArgs e)
        {
            EventHandler<ReorderExercisesEventArgs> handler = ExerciseReorderedEvent;
            if (handler != null)
                handler(this, e);
        }

        public ucExercise()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return lblExerciseName.Text; }
            set { lblExerciseName.Text = value; }
        }

        public int IdExercise
        {
            get { return _idExercise; }
            set { _idExercise = value; }
        }

        public int IdExerciseType
        {
            get { return _idExerciseType; }
            set { _idExerciseType = value; }
        }

        public int SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; }
        }

        public void GetSets(object sender, EventArgs e)
        {
            Height = 27;
            _setLocation.Y = 22;
            foreach (ucSet set in _sets)
            {
                Controls.Remove(set);
            }
            _sets.Clear();
            Control[] tot = Controls.Find("ucExerciseTotals", true);
            if (tot.Length > 0)
                Controls.Remove(tot[0]);
            DataTable tblSets = Workout.GetWorkoutSets(_idExercise);
            int exerciseTotalReps = 0;
            decimal exerciseTotalWeight = 0;
            foreach (DataRow setRow in tblSets.Rows)
            {
                ucSet newSet = new ucSet((int)setRow["idWorkoutSet"]);
                _sets.Add(newSet);
                newSet.Location = _setLocation;
                newSet.SetDeletedEvent += SetDeleted;
                newSet.SetUpdatedEvent += SetUpdated;
                newSet.CopySetEvent += AddSet;
                Controls.Add(newSet);
                Height += 27;
                _setLocation.Y += 27;
                exerciseTotalWeight += newSet.TotalWeight;
                exerciseTotalReps += newSet.Reps;
            }
            ucExerciseTotals totals = new ucExerciseTotals();
            totals.Reps = exerciseTotalReps;
            totals.Weight = exerciseTotalWeight;
            totals.Location = _setLocation;
            Controls.Add(totals);
            Height += 27;
            ExerciseUpdated(EventArgs.Empty);
        }

        public void DeleteAllSets()
        {
            List<Control> remove = new List<Control>();
            string sql = "DELETE FROM tblWoSets WHERE idWorkoutExercise=" + _idExercise;
            Functions.RunSql(sql);
            foreach (Control cntrl in Controls)
            {
                //Type t = cntrl.GetType();
                if (cntrl.GetType() == typeof (ucSet))
                {
                    remove.Add(cntrl);
                }
            }
            foreach (Control cntrl in remove)
            {
                Controls.Remove(cntrl);
            }
            ExerciseUpdated(EventArgs.Empty);
        }

        public void SaveSortOrder(int sortOrder)
        {
            string sql = "UPDATE tblWoWorkoutExercises SET SortOrder=" + sortOrder + " WHERE idWorkoutExercise=" + IdExercise;
            Functions.RunSql(sql);
        }

        public void EnableButtons()
        {
            btnUp.Enabled = true;
            btnDown.Enabled = true;
        }

        public void DisableUpButton()
        {
            btnUp.Enabled = false;
        }

        public void DisableDownButton()
        {
            btnDown.Enabled = false;
        }

        private void SetDeleted(object sender, EventArgs e)
        {
            GetSets(null, EventArgs.Empty);
        }

        private void SetUpdated(object sender, EventArgs e)
        {
            Control[] tot = Controls.Find("ucExerciseTotals", true);
            if (tot.Length > 0)
            {
                ucExerciseTotals totals = (ucExerciseTotals) tot[0];
                totals.Weight = 0;
                totals.Reps = 0;
                foreach (ucSet set in _sets)
                {
                    totals.Weight += set.TotalWeight;
                    totals.Reps += set.Reps;
                }
            }
        }

        private void AddSet(object sender, NewSetEventArgs e)
        {
            string sql = "INSERT INTO tblWoSets (idWorkoutExercise, idExerciseType, Reps, Weight, Notes) " +
                         "VALUES(@idWorkoutExercise, @idExerciseType, @reps, @weight, @notes)";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@idWorkoutExercise", IdExercise);
            cmd.Parameters.AddWithValue("@idExerciseType", IdExerciseType);
            cmd.Parameters.AddWithValue("@reps", e.Reps);
            cmd.Parameters.AddWithValue("@weight", e.Weight);
            cmd.Parameters.AddWithValue("@notes", e.Notes);
            cmd.CommandText = sql;
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
            GetSets(null, EventArgs.Empty);
        }

        private void mNewSet_Click(object sender, EventArgs e)
        {
            NewSetEventArgs args = new NewSetEventArgs();
            args.Reps = 0;
            args.Weight = 0;
            args.Notes = "";
            AddSet(null, args);
            GetSets(null, EventArgs.Empty);
        }

        private void mDeleteExercise_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ReorderExercisesEventArgs args = new ReorderExercisesEventArgs();
            args.OldPosition = SortOrder;
            args.NewPosition = SortOrder + 1;
            ExerciseReordered(args);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            ReorderExercisesEventArgs args = new ReorderExercisesEventArgs();
            args.OldPosition = SortOrder;
            args.NewPosition = SortOrder - 1;
            if (args.NewPosition == 1)
                btnUp.Enabled = false;
            //else
            //    btnUp.Enabled = true;
            btnDown.Enabled = true;
            ExerciseReordered(args);
        }
    }

    public class ReorderExercisesEventArgs : EventArgs
    {
        public int OldPosition { get; set; }
        public int NewPosition { get; set; }
    }
}
