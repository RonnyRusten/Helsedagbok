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
    public partial class ucSet : UserControl
    {
        private int _idSet;
        private decimal _totalWeight;
        private decimal _weight;
        private int _reps;

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

        private void GetData()
        {
            string sql = "SELECT idWorkoutSet, Reps, Weight, Notes FROM tblWoSets WHERE idWorkoutSet=" + _idSet;
            DataTable tbl = Functions.GetTable(sql);
            int.TryParse(tbl.Rows[0]["Reps"].ToString(), out _reps);
            decimal.TryParse(tbl.Rows[0]["Weight"].ToString(), out _weight);
            _totalWeight = _reps * _weight;
            txtReps.Text = tbl.Rows[0]["Reps"].ToString();
            txtWeight.Text = tbl.Rows[0]["Weight"].ToString() + " kg";
        }

        private void txtReps_TextChanged(object sender, EventArgs e)
        {
            GetTotalWeight();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            GetTotalWeight();
        }

        private void GetTotalWeight()
        {
            int reps;
            decimal weight;
            if (Int32.TryParse(txtReps.Text, out reps) & decimal.TryParse(txtWeight.Text.Replace(" kg",""), out weight))
                txtTotal.Text = (reps*weight).ToString() + " kg";
        }
    }
}
