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
    public partial class frmNotes : Form
    {
        public frmNotes()
        {
            InitializeComponent();
        }

        public string Notes
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
        }
    }
}
