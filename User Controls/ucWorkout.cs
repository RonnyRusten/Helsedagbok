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
        public ucWorkout()
        {
            InitializeComponent();
            Height = 30;
        }

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

        public void GetExercises()
        {
            DataTable tblExercises = Workout.GetExersises(IdWorkout);
            foreach (ucExercise ex in _exercises)
            {
               Controls.Remove(ex); 
            }
            _exercises.Clear();
            foreach (DataRow exerciseRow in tblExercises.Rows)
            {
                ucExercise ex = new ucExercise();
                ex.Title = exerciseRow["Name"].ToString();
                ex.IdExercise = (int) exerciseRow["idWorkoutExercise"];
                _exercises.Add(ex);
                ex.Location = _exerciseLocation;
                Controls.Add(ex);
                ex.GetSets();
                Height += ex.Height;
                _exerciseLocation.Y += ex.Height;
            }
        }

        public void SaveExercises()
        {
            
        }

        public void AddExercise()
        {
            
        }

        public void DeleteExercise()
        {

        }

        private void tsmiAddExercise_Click(object sender, EventArgs e)
        {
            frmEditExercise frm = new frmEditExercise();
            frm.ShowDialog();
        }
    }
}
