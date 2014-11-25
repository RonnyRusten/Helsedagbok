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
    public partial class frmNewExercise : Form
    {
        public frmNewExercise()
        {
            InitializeComponent();
        }

        private void frmNewExercise_Load(object sender, EventArgs e)
        {
            GetBodyParts();
        }

        private void GetBodyParts()
        {
            string sql = "SELECT idBodyPart, Name FROM tblWoBodyParts ORDER BY Name";
            DataTable tbl = Functions.GetTable(sql);
            cmbBodyPart.DisplayMember = "Name";
            cmbBodyPart.ValueMember = "idBodyPart";
            cmbBodyPart.DataSource = tbl;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Workout.AddExercise(txtExerciseName.Text,(int)cmbBodyPart.SelectedValue);
        }
    }
}
