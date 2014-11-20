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
    public partial class ucExerciseTotals : UserControl
    {
        public ucExerciseTotals()
        {
            InitializeComponent();
        }

        public int Reps
        {
            set { lblReps.Text = value.ToString(); }
            get
            {
                int retval;
                Int32.TryParse(lblReps.Text, out retval);
                return retval;
            }
        }

        public decimal Weight
        {
            set { lblTotal.Text = value.ToString() + " kg"; }
            get
            {
                decimal retval;
                decimal.TryParse(lblTotal.Text.Replace(" kg",""), out retval);
                return retval;
            }
        }

    }
}
