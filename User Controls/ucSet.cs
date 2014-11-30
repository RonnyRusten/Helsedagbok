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
using Helsedagbok.Forms;

namespace Helsedagbok
{
    public partial class ucSet : UserControl
    {
        private int _idSet;
        private decimal _totalWeight;
        private decimal _weight;
        private int _reps;
        private string _notes;

        public event EventHandler SetUpdatedEvent;
        public event EventHandler SetDeletedEvent;
        public event EventHandler<NewSetEventArgs> CopySetEvent;

        protected virtual void SetUpdated(EventArgs e)
        {
            EventHandler handler = SetUpdatedEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void SetDeleted(EventArgs e)
        {
            EventHandler handler = SetDeletedEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void CopySet(NewSetEventArgs e)
        {
            EventHandler<NewSetEventArgs> handler = CopySetEvent;
            if (handler != null)
                handler(this, e);
        }

        public ucSet()
        {
            InitializeComponent();
        }

        public ucSet(int idSet)
        {
            InitializeComponent();
            _idSet = idSet;
            GetData();
        }

        public int IdSet
        {
            set { _idSet = value; }
            get { return _idSet; }
        }

        public decimal TotalWeight
        {
            get { return _totalWeight; }
            set { _totalWeight = value; }
        }

        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public int Reps
        {
            get { return _reps; }
            set { _reps = value; }
        }

        public string Notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                if (_notes.Length > 0)
                {
                    pnlNote.BackColor = Color.Green;
                    toolTip1.SetToolTip(btnNote, _notes);
                    toolTip1.SetToolTip(pnlNote, _notes);
                }
                else
                {
                    pnlNote.BackColor = SystemColors.Control;
                    toolTip1.SetToolTip(btnNote, "");
                    toolTip1.SetToolTip(pnlNote, "");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string question = "Vil du slette dette settet (" + Reps + " x " + Weight + ")?";
            if (MessageBox.Show(question, "Slette sett.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tblWoSets WHERE idWorkoutSet = " + IdSet;
                Functions.RunSql(sql);
                SetDeleted(EventArgs.Empty);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            NewSetEventArgs args = new NewSetEventArgs();
            args.Reps = Reps;
            args.Weight = Weight;
            args.Notes = "";
            CopySet(args);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewSetEventArgs args = new NewSetEventArgs();
            args.Reps = 0;
            args.Weight = 0;
            args.Notes = "";
            CopySet(args);
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            frmNotes note = new frmNotes();
            note.Location = PointToScreen(pnlNote.Location);//new Point(pnlNote.Left, pnlNote.Top);
            note.Notes = Notes;
            if (note.ShowDialog() == DialogResult.OK)
            {
                string sql = "UPDATE tblWoSets SET Notes = '" + note.Notes + "' WHERE idWorkoutSet=" + IdSet;
                Functions.RunSql(sql);
                Notes = note.Notes;
            }
            UpdateSet();
        }

        private void txtReps_TextChanged(object sender, EventArgs e)
        {
            Reps = (txtReps.Text != "") ? Convert.ToInt32(txtReps.Text) : 0;
            GetTotalWeight();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            Weight = (txtWeight.Text != "") ? Convert.ToDecimal(txtWeight.Text) : 0;
            GetTotalWeight();
        }

        private void GetData()
        {
            string sql = "SELECT idWorkoutSet, Reps, Weight, Notes FROM tblWoSets WHERE idWorkoutSet=" + _idSet;
            DataTable tbl = Functions.GetTable(sql);
            int.TryParse(tbl.Rows[0]["Reps"].ToString(), out _reps);
            decimal.TryParse(tbl.Rows[0]["Weight"].ToString(), out _weight);
            _totalWeight = _reps * _weight;
            txtReps.Text = tbl.Rows[0]["Reps"].ToString();
            txtWeight.Text = tbl.Rows[0]["Weight"].ToString(); // + " kg";
            Notes = tbl.Rows[0]["Notes"].ToString();    
        }

        private void GetTotalWeight()
        {
            int reps;
            decimal weight;
            if (Int32.TryParse(txtReps.Text, out reps) & decimal.TryParse(txtWeight.Text.Replace(" kg",""), out weight))
                txtTotal.Text = (reps*weight).ToString() + " kg";
            TotalWeight = weight * reps;
            UpdateSet();
        }

        private void UpdateSet()
        {
            string sql = "UPDATE tblWoSets SET Reps = @Reps, Weight = @Weight WHERE idWorkoutSet=" + IdSet;
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@Reps", Reps);
            cmd.Parameters.AddWithValue("@Weight", Weight);
            cmd.CommandText = sql;
            Functions.RunSqlCommand(cmd);
            SetUpdated(EventArgs.Empty);
        }
    }

    public class NewSetEventArgs : EventArgs
    {
        public int Reps { get; set; }
        public decimal Weight { get; set; }
        public string Notes { get; set; }
    }
}
