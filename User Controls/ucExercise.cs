using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private int _idExercise;
        private List<ucSet> _sets=new List<ucSet>();
        private Point _setLocation = new Point(0, 22);

        public ucExercise()
        {
            InitializeComponent();
            Height = 27;
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

        public void GetSets()
        {
            DataTable tblSets = Workout.GetWorkoutSets(_idExercise);
            int exerciseTotalReps = 0;
            decimal exerciseTotalWeight = 0;
            foreach (DataRow setRow in tblSets.Rows)
            {
                ucSet newSet = new ucSet((int)setRow["idWorkoutSet"]);
                _sets.Add(newSet);
                newSet.Location = _setLocation;
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
        }
    }
}
