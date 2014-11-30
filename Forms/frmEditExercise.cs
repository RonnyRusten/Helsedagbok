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
    public partial class frmEditExercise : Form
    {
        private bool _editMode;
        private DataTable _tblExercises;
        private DataTable _tblExercisesFiltered;
        private int _idWorkout;
        private int _idExerciseType;

        public frmEditExercise()
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

        private void frmEditExercise_Load(object sender, EventArgs e)
        {
            GetExercises();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterExercises();
        }

        private void GetExercises()
        {
            string sql = "SELECT idExerciseType, Name FROM tblWoExerciseTypes ORDER BY Name";
            _tblExercises = Functions.GetTable(sql);
            dgvExercises.DataSource = _tblExercises;
            dgvExercises.Columns[0].Visible = false;
            dgvExercises.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            Workout.AddWorkoutExercise(IdWorkout, _idExerciseType);
            DialogResult = DialogResult.OK;
        }

        private void dgvExercises_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExercises.SelectedRows.Count > 0)
                _idExerciseType = (int)dgvExercises.SelectedRows[0].Cells[0].Value;
        }
    }
}
