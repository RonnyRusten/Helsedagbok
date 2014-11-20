using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Helsedagbok
{
    public partial class frmEditRecepieIngredients : Form
    {

        DataTable tblFood;
        DataTable tblFoodFiltered;
        SqlDataAdapter FoodAdapter;

        public frmEditRecepieIngredients()
        {
            InitializeComponent();
        }


        private void getFood()
        {
            dgvFood.DataSource = null;
            dgvFood.Columns.Clear();
            string sqlString = "SELECT " +
                "Display = Name, " +
                "fav = case when (SELECT tblfavorites.id FROM tblfavorites WHERE tblfavorites.id_food = tblMatvarer.id) is null then 0 else 1 END, " +
                "tblMatvarer.id " +
                "FROM tblMatvarer " +
                "Left Outer Join tblFavorites on tblfavorites.id_food = tblMatvarer.id " +
                "ORDER BY Display";
            FoodAdapter = new SqlDataAdapter(sqlString, Global.conn1);
            tblFood = new DataTable();
            FoodAdapter.Fill(tblFood);
            if (dgvFood.Columns.Count < 1)
            {
                dgvFood.Columns.Add(new DataGridViewImageColumn());
                dgvFood.DataSource = tblFood;
                dgvFood.Columns[0].Width = 20;
                dgvFood.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvFood.Columns[2].Visible = false;
                dgvFood.Columns[3].Visible = false;
            }
        }

        private void FilterFood()
        {
            DataRow[] drFilter;
            drFilter = tblFood.Select("Display Like '%" + txtFoodFilter.Text + "%'", "fav DESC");
            lblFoodCount.Text = "Fant " + drFilter.Length + " matvarer.";
            if (drFilter.Length > 0)
            {
                tblFoodFiltered = drFilter.CopyToDataTable();
            }

            if (txtFoodFilter.Text.Length > 0)
            {
                dgvFood.DataSource = tblFoodFiltered;
            }
            else
            {
                dgvFood.DataSource = tblFood;
            }
        }

        private void frmEditRecepieIngredients_Load(object sender, EventArgs e)
        {
            Functions.GetFormPositionSize(this);
            getFood();

        }

        private void dgvFood_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    if ((int)(dgvFood[2, e.RowIndex].Value) == 1)
                    {
                        dgvFood[0, e.RowIndex].Value = (Bitmap)Properties.Resources.Star_Favorite_16x16;
                    }
                    else
                    {
                        dgvFood[0, e.RowIndex].Value = (Bitmap)Properties.Resources.Star_Favorite_Grey_16x16;
                    }
                }
                catch { }
            }
        }

        private void txtFoodFilter_TextChanged(object sender, EventArgs e)
        {
            FilterFood();
        }
    }
}
