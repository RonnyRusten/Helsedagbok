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
    public partial class FrmRecepieSearch : Form
    {
        public static event EventHandler<RecepieSelectedEventArgs> RecepieSelectedEvent;

        protected virtual void RecepieSelected(RecepieSelectedEventArgs e)
        {
            EventHandler<RecepieSelectedEventArgs> handler = RecepieSelectedEvent;
            if (handler != null)
                handler(this, e);
        }

        public FrmRecepieSearch()
        {
            InitializeComponent();
        }

        private void GetRecepieCategories()
        {
            string sql = "SELECT idCategory, CategoryName AS Kategori FROM tblRecepieCategories ORDER BY CategoryName";
            DataTable tblCategories = Functions.GetTable(sql);
            dgvCategories.DataSource = tblCategories;
            dgvCategories.Columns[0].Visible = false;
            dgvCategories.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            select.Width = 20;
            dgvCategories.Columns.Insert(1, select);
        }

        private void GetRecepies()
        {
            string sql = "SELECT idRecepie, Name AS Oppskrift FROM tblRecepies";
            DataTable tblRecepies = Functions.GetTable(sql);
            dgvRecepies.DataSource = tblRecepies;
            dgvRecepies.Columns[0].Visible = false;
            dgvRecepies.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmRecepieSearch_Load(object sender, EventArgs e)
        {
            GetRecepies();
            GetRecepieCategories();
        }

        private void dgvRecepies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecepies.SelectedRows.Count > 0)
            {
                RecepieSelectedEventArgs args = new RecepieSelectedEventArgs();
                args.RecepieName = dgvRecepies.SelectedRows[0].Cells["Oppskrift"].Value.ToString();
                args.RecepieId = (int)dgvRecepies.SelectedRows[0].Cells["idRecepie"].Value;
                RecepieSelected(args);
            }
        }


    }

    public class RecepieSelectedEventArgs : EventArgs
    {
        public string RecepieName { get; set; }
        public int RecepieId { get; set; }
    }
}
