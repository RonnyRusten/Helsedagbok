using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helsedagbok.Forms
{
    public partial class frmWorkout : Form
    {
        private int _idWorkout;

        public frmWorkout()
        {
            InitializeComponent();
        }

        public int IdWorkout
        {
            get { return _idWorkout; }
            set { _idWorkout = value; }
        }

        public string WorkoutName
        {
            get { return txtWorkoutName.Text; }
            set { txtWorkoutName.Text = value; }
        }

        public string WorkoutLocation
        {
            get { return cmbLocation.Text; }
            set { cmbLocation.Text = value; }
        }

        public DateTime Duration
        {
            get { return dtpDuration.Value; }
            set { dtpDuration.Value = value; }
        }

        private void frmWorkout_Load(object sender, EventArgs e)
        {
            string sql = "SELECT DISTINCT Location FROM tblWoWorkouts";
            DataTable tbl = Functions.GetTable(sql);
            cmbLocation.DisplayMember = "Location";
            cmbLocation.DataSource = tbl;
        }
    }
}
