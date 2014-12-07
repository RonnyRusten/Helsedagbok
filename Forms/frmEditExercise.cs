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
    public partial class FrmEditExercise : Form
    {
        private bool _editMode;
        private DataTable _tblExercises;
        private DataTable _tblExercisesFiltered;
        private DataTable _tblMuscles;
        private int _idWorkout;
        private int _idExerciseType;
        private int _newExerciseSortOrder;
        private string _exerciseName;
        private ucExercise _newExercise;

        public FrmEditExercise()
        {
            InitializeComponent();
        }

        public bool EditMode
        {
            get { return _editMode; }
            set { _editMode = value; }
        }

        public int IdWorkout
        {
            get { return _idWorkout; }
            set { _idWorkout = value; }
        }

        public int NewExerciseSortOrder
        {
            get { return _newExerciseSortOrder; }
            set { _newExerciseSortOrder = value; }
        }

        public ucExercise NewExercise
        {
            get { return _newExercise; }
            set { _newExercise = value; }
        }

        private void frmEditExercise_Load(object sender, EventArgs e)
        {
            GetExercises();
            GetMuscles();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterExercises();
        }

        private void GetExercises()
        {
            string sql = "SELECT idExerciseType, Name, idBodyPart, idMuscle FROM tblWoExerciseTypes ORDER BY Name";
            _tblExercises = Functions.GetTable(sql);
            dgvExercises.DataSource = _tblExercises;
            dgvExercises.Columns[0].Visible = false;
            dgvExercises.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GetMuscles()
        {
            string sql = "SELECT idMuscle, Name, Latin, Description FROM tblWoMuscles UNION SELECT null, null, null, null ORDER BY Name";
            _tblMuscles = Functions.GetTable(sql);
            dgvExercises.DataSource = _tblExercises;
            cmbPrimaryMuscle.DisplayMember = "Name";
            cmbPrimaryMuscle.ValueMember = "idMuscle";
            cmbPrimaryMuscle.DataSource = _tblMuscles;
        }

        private void FilterExercises()
        {
            DataRow[] drFilter = _tblExercises.Select("Name Like '%" + txtSearch.Text + "%'");
            //lblFoodCount.Text = "Fant " + drFilter.Length + " matvarer.";
            if (drFilter.Length > 0)
            {
                _tblExercisesFiltered = drFilter.CopyToDataTable();
            }

            if (txtSearch.Text.Length > 0)
            {
                dgvExercises.DataSource = _tblExercisesFiltered;
            }
            else
            {
                dgvExercises.DataSource = _tblExercises;
            }
        }

        private void GetExerciseDetails(int idExerciseType)
        {
            cmbPrimaryMuscle.SelectedValue = (!DBNull.Value.Equals(dgvExercises.SelectedRows[0].Cells[3].Value)) ? (int)dgvExercises.SelectedRows[0].Cells[3].Value : 0;
            //string sql = "SELECT idMuscle FROM tblWoExerciseTypes WHERE idExerciseType=@idExerciseType";
            //SqlCommand cmd = Global.conn1.CreateCommand();
            //cmd.CommandText = sql;
            //cmd.Parameters.AddWithValue("@idExerciseType", idExerciseType);
            //if (Global.conn1.State != ConnectionState.Open)
            //    Global.conn1.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    reader.Read();

            //}
        }

        private void miNewExercise_Click(object sender, EventArgs e)
        {
            frmNewExercise frm = new frmNewExercise();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetExercises();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NewExercise = Workout.AddWorkoutExercise(IdWorkout, _idExerciseType, _exerciseName, NewExerciseSortOrder);
            DialogResult = DialogResult.OK;
        }

        private void dgvExercises_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExercises.SelectedRows.Count > 0)
            {
                _idExerciseType = (int) dgvExercises.SelectedRows[0].Cells[0].Value;
                _exerciseName = dgvExercises.SelectedRows[0].Cells[1].Value.ToString();
                GetExerciseDetails(_idExerciseType);
            }
        }

        private void dgvExercises_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewExercise = Workout.AddWorkoutExercise(IdWorkout, _idExerciseType, _exerciseName, NewExerciseSortOrder);
            DialogResult = DialogResult.OK;
        }
    }
}
