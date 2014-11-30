using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dtpDuration.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 1, 0, 0);
        }

        public void GetWorkout()
        {
            string sql = "SELECT Date, Name, Duration, Location FROM tblWoWorkouts WHERE idWorkout=" + IdWorkout;
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.CommandText = sql;
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtWorkoutName.Text = reader.GetString(1);
                dtpDuration.Value = reader.GetDateTime(2);
                cmbLocation.Text = reader.GetString(3);
            }
            reader.Close();
            Global.conn1.Close();
        }
    }
}
