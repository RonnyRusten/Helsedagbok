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
using Helsedagbok.User_Controls;

namespace Helsedagbok
{
    public partial class FrmEditRecepieIngredients : Form
    {
        #region Events
        public event EventHandler IngredientAddEvent;
        public event EventHandler IngredientUpdateEvent;

        protected virtual void IngredientAdd(EventArgs e)
        {
            EventHandler handler = IngredientAddEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void IngredientUpdate(EventArgs e)
        {
            EventHandler handler = IngredientUpdateEvent;
            if (handler != null)
                handler(this, e);
        }
        #endregion

        #region Properties
        private DataTable _tblFood;
        private DataTable _tblFoodFiltered;
        private SqlDataAdapter _foodAdapter;
        public int IdRecepieHeading { get; set; }
        public int IdIngredient { get; set; }
        public int IdUnit { get; set; }
        public int IdFood { get; set; }
        public int NewSortOrder { get; set;}
        public decimal Amount { get; set; }
        public bool EditMode { get; set; }
        public UcRecepieIngredient NewIngredient { get; set; }
        #endregion

        public FrmEditRecepieIngredients()
        {
            InitializeComponent();
        }

        private void GetUnits()
        {
            string sql = "SELECT id, Name, Weight FROM tblUnits";
            DataTable tbl = Functions.GetTable(sql);
            cmbUnits.DisplayMember = "Name";
            cmbUnits.ValueMember = "id";
            cmbUnits.DataSource = tbl;
        }

        private void GetFood()
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
            _foodAdapter = new SqlDataAdapter(sqlString, Global.conn1);
            _tblFood = new DataTable();
            _foodAdapter.Fill(_tblFood);
            DataColumn[] keys = new DataColumn[1];
            keys[0] = _tblFood.Columns["id"];
            _tblFood.PrimaryKey = keys;
            if (dgvFood.Columns.Count < 1)
            {
                dgvFood.Columns.Add(new DataGridViewImageColumn());
                dgvFood.DataSource = _tblFood;
                dgvFood.Columns[0].Width = 20;
                dgvFood.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvFood.Columns[2].Visible = false;
                dgvFood.Columns[3].Visible = false;
            }
        }

        private void SetFood()
        {
            int n = 0;
            foreach (DataGridViewRow row in dgvFood.Rows)
            {
                if ((int)row.Cells["id"].Value == IdFood)
                {
                    dgvFood.Rows[n].Selected = true;
                    dgvFood.FirstDisplayedScrollingRowIndex = n;
                    break;
                }
                n += 1;
            }
        }

        private void FilterFood()
        {
            DataRow[] drFilter = _tblFood.Select("Display Like '%" + txtFoodFilter.Text + "%'", "fav DESC");
            lblFoodCount.Text = "Fant " + drFilter.Length + " matvarer.";
            if (drFilter.Length > 0)
            {
                _tblFoodFiltered = drFilter.CopyToDataTable();
            }

            dgvFood.DataSource = (txtFoodFilter.Text.Length > 0) ? _tblFoodFiltered : _tblFood;
        }

        private bool AddIngredient()
        {
            string sql = "INSERT INTO tblRecepieIngredients (idRecepieHeading, idFood, Amount, idUnit, SortOrder) VALUES(@idRecepieHeading, @idFood, @Amount, @idUnit, @SortOrder) SET @ID = SCOPE_IDENTITY();";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idRecepieHeading", IdRecepieHeading);
            cmd.Parameters.AddWithValue("@idFood", (int) dgvFood.SelectedRows[0].Cells[3].Value);
            cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text));
            cmd.Parameters.AddWithValue("@idUnit", cmbUnits.SelectedValue);
            cmd.Parameters.AddWithValue("@SortOrder", NewSortOrder);
            cmd.Parameters.Add("@ID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            NewIngredient=new UcRecepieIngredient();
            NewIngredient.IdIngredient = (int)cmd.Parameters["@ID"].Value;
            NewIngredient.GetIngredient();
            NewSortOrder += 1;
            return true;
        }

        private bool EditIngredient()
        {
            string sql = "UPDATE tblRecepieIngredients SET " +
                         "idFood=@idFood, " +
                         "Amount=@Amount, " +
                         "idUnit=@idUnit " +
                         "WHERE idIngredient=@idIngredient";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idIngredient", IdIngredient);
            cmd.Parameters.AddWithValue("@idFood", (int)dgvFood.SelectedRows[0].Cells[3].Value);
            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
            cmd.Parameters.AddWithValue("@idUnit", cmbUnits.SelectedValue);
            return Functions.RunSqlCommand(cmd);
        }

        private void frmEditRecepieIngredients_Load(object sender, EventArgs e)
        {
            Functions.GetFormPositionSize(this);
            GetFood();
            GetUnits();
            if (EditMode)
            {
                btnAddIngredient.Text = "Oppdater";
                cmbUnits.SelectedValue = IdUnit;
                txtAmount.Text = Amount.ToString();
                SetFood();
            }
        }

        private void frmEditRecepieIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.SetFormPositionSize(this);
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

        private void btnEditFood_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                if (AddIngredient())
                    IngredientAdd(EventArgs.Empty);
            }
            else
            {
                if (EditIngredient())
                {
                    IngredientUpdate(EventArgs.Empty);
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }


    }
}
