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
    public partial class frmEditDiary : Form
    {
        int m_idFood;
        int m_idMealType;
        DateTime m_DiaryDate;
        DataTable tblFoodInfo;
        DataTable tblUnits;
        DataTable tblFood;
        DataTable tblFoodFiltered;
        SqlDataAdapter FoodAdapter;

        public static event EventHandler eFoodUpdated;

        #region "Properties"
        public DateTime DiaryDate
        {
            get { return m_DiaryDate; }
            set 
            {
                m_DiaryDate = value;
                dtpDate.Value = value;
            }
        }

        public int IdFood
        {
            get { return m_idFood; }
            set { m_idFood = value; }
        }

        public int IdUnit
        {
            get { return (int)cmbUnits.SelectedValue; }
            set 
            {
                setUnit();
                cmbUnits.SelectedValue = value; 
            }
        }

        public int IdMealType
        {
            get { return lb_mealTypes.SelectedIndex; }
            set 
            {
                m_idMealType = value;
                getMealTypes();
                lb_mealTypes.SelectedValue = value;
                lb_mealTypes.SetSelected(lb_mealTypes.SelectedIndex, true);
            }
        }

        public decimal amnt
        {
            get { return Convert.ToDecimal(txtAmount.Text); }
            set { txtAmount.Text = value.ToString(); }
            
        }
        #endregion

        public frmEditDiary()
        {
            InitializeComponent();
        }

        protected virtual void FoodUpdated(EventArgs e)
        {
            EventHandler handler = eFoodUpdated;
            if (handler != null)
                handler(this, e);
        }

        private void frmEditDiary_Load(object sender, EventArgs e)
        {
            Functions.GetFormPositionSize(this);
            dtpDate.Value = DiaryDate;
            if (IdMealType <= 0)
                getMealTypes();
            if(tblUnits == null)
                getUnits();
            getFood();
            if (IdFood == 0)
                IdFood = (int)dgvFood.Rows[0].Cells[3].Value;
            getFoodInfo();
            setChart();
            //getUnits();
            if (Convert.ToDecimal(txtAmount.Text) <= 1)
                setUnit();
        }

        private void frmEditDiary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.SetFormPositionSize(this);
        }

        private void getFood()
        {
            dgvFood.DataSource = null;
            dgvFood.Columns.Clear();
            string sqlString = "SELECT " +
                "Display = (Name + ' (' + CAST(tblMatvarer.Energi_kCal AS nvarChar) + ' kCal/100g)'), " +
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

        private void getMealTypes()
        {
            SqlDataAdapter a = new SqlDataAdapter("SELECT id, Name FROM tblMealTypes ORDER BY SortOrder", Global.conn1);
            DataTable tbl = new DataTable();
            a.Fill(tbl);
            lb_mealTypes.DataSource = tbl;
            lb_mealTypes.DisplayMember = "Name";
            lb_mealTypes.ValueMember = "id";
            if (m_idMealType != 0)
                lb_mealTypes.SetSelected(IdMealType, true);
            else
                lb_mealTypes.SetSelected(0, false);
        }

        private void getUnits()
        {
            SqlDataAdapter a = new SqlDataAdapter("SELECT id, Name, Weight FROM tblUnits WHERE idFood = @idFood OR idFood is null", Global.conn1);
            a.SelectCommand.Parameters.AddWithValue("@idFood", IdFood);
            tblUnits = new DataTable();
            a.Fill(tblUnits);
            cmbUnits.DataSource = tblUnits;
            cmbUnits.DisplayMember = "Name";
            cmbUnits.ValueMember = "id";
        }

        private void getFoodInfo()
        {
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM tblMatvarer WHERE id =" + IdFood, Global.conn1);
            tblFoodInfo = new DataTable();
            a.Fill(tblFoodInfo);
            if (tblFoodInfo.Rows.Count > 0)
            {
                lblFoodName.Text = tblFoodInfo.Rows[0]["Name"].ToString();
                setNutritionValues();
            }
            
        }

        private void setNutritionValues()
        {
            if (tblFoodInfo != null)
            {
                lblTotEnergy.Text = macroCalk(totalEnergy().ToString()) + " kCal";
                lblCarbs.Text = macroCalk(tblFoodInfo.Rows[0]["Karbohydrat"].ToString());
                lblProtein.Text = macroCalk(tblFoodInfo.Rows[0]["Protein"].ToString());
                lblFat.Text = macroCalk(tblFoodInfo.Rows[0]["Fett"].ToString());
                lblFatSat.Text = macroCalk(tblFoodInfo.Rows[0]["Fett_Mettet"].ToString());
                lblFatMonoUnsat.Text = macroCalk(tblFoodInfo.Rows[0]["Fett_Enum"].ToString());
                lblFatPolyUnsat.Text = macroCalk(tblFoodInfo.Rows[0]["Fett_Flerum"].ToString());
                lblFatTrans.Text = macroCalk(tblFoodInfo.Rows[0]["Fett_Trans"].ToString());
                lblAlcohol.Text = macroCalk(tblFoodInfo.Rows[0]["Alkohol"].ToString());

                lblCarbsEnergy.Text = macroEnergy(lblCarbs.Text, 4).ToString() + " kCal";
                lblProtEnergy.Text = macroEnergy(lblProtein.Text, 4).ToString() + " kCal";
                lblFatEnergy.Text = macroEnergy(lblFat.Text, 9).ToString() + " kCal";
                lblFatSatEnergy.Text = macroEnergy(lblFatSat.Text, 9).ToString() + " kCal";
                lblFatMonoEnergy.Text = macroEnergy(lblFatMonoUnsat.Text, 9).ToString() + " kCal";
                lblFatPolyEnergy.Text = macroEnergy(lblFatPolyUnsat.Text, 9).ToString() + " kCal";
                lblFatTransEnergy.Text = macroEnergy(lblFatTrans.Text, 9).ToString() + " kCal";
                lblAlcoholEnergy.Text = macroEnergy(lblAlcohol.Text, 7).ToString() + " kCal";
            }
        }

        private void setTotalWeight()
        {
            decimal count = Convert.ToDecimal(txtAmount.Text);
            decimal unitWeight = (decimal)tblUnits.Rows[cmbUnits.SelectedIndex]["Weight"];
            decimal totWeight = count * unitWeight;
            if (unitWeight != 1)
            {
                lblTotWeight.Visible = true;
                lblTotWeight.Text = "(" + totWeight.ToString("0.0") + " g) =";
            }
            else 
            { 
                lblTotWeight.Visible = false; 
            }
        }

        private void setChart()
        {
            decimal[] yValues = { 50, 35, 15, 0 };
            String[] xValues = { "50%", "35%", "15%", "0%" };

            decimal eTot = Convert.ToDecimal(macroCalk(totalEnergy().ToString()));
            decimal eFat = Convert.ToDecimal(macroCalk(tblFoodInfo.Rows[0]["Fett"].ToString())) * 9;
            decimal eProtein = Convert.ToDecimal(macroCalk(tblFoodInfo.Rows[0]["Protein"].ToString())) * 4;
            decimal eCarbs = Convert.ToDecimal(macroCalk(tblFoodInfo.Rows[0]["Karbohydrat"].ToString())) * 4;
            decimal eAlkohol = Convert.ToDecimal(macroCalk(tblFoodInfo.Rows[0]["Alkohol"].ToString())) * 7;

            if (eTot != 0)
            {
                yValues[0] = eCarbs / eTot * 100;
                yValues[1] = eProtein / eTot * 100;
                yValues[2] = eFat / eTot * 100;
                yValues[3] = eAlkohol / eTot * 100;
            }
            xValues[0] = "Karbohydrat: " + yValues[0].ToString("0.0") + "%";
            xValues[1] = "Protein: " + yValues[1].ToString("0.0") + "%";
            xValues[2] = "Fett: " + yValues[2].ToString("0.0") + "%";
            xValues[3] = "Alkohol: " + yValues[3].ToString("0.0") + "%";

            pcNutrition.Legends[0].Enabled = true;
            pcNutrition.Series["Default"].Points.DataBindXY(xValues, yValues);
            pcNutrition.ChartAreas[0].Area3DStyle.Enable3D = true;
            pcNutrition.Series["Default"]["PieLabelStyle"] = "Disabled";
        }

        private string macroCalk(string value)
        {
            decimal total = 0;
            decimal count = Convert.ToDecimal(txtAmount.Text);
            if (count == 0)
            {
                count = 100;
                txtAmount.Text = "100";
            }
            decimal unitWeight = (decimal)tblUnits.Rows[cmbUnits.SelectedIndex]["Weight"];
            if (Functions.IsNumeric(value)) total =  Convert.ToDecimal(value) / 100 * count * unitWeight;
            return total.ToString("0.00");
        }

        private decimal totalEnergy()
        {
            decimal fat = (decimal)tblFoodInfo.Rows[0]["Fett"];
            decimal carbs = (decimal)tblFoodInfo.Rows[0]["Karbohydrat"];
            decimal protein = (decimal)tblFoodInfo.Rows[0]["Protein"];
            decimal alkohol = (decimal)tblFoodInfo.Rows[0]["Alkohol"];
            decimal total = (fat*9) + (carbs+protein)*4 + alkohol*7;
            return total;
        }

        private decimal macroEnergy(string value, int Multiplier)
        {
            decimal totEnergy = totalEnergy() ;
            decimal Energy = Convert.ToDecimal(value) * Multiplier;
            return Energy;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(txtAmount.Text, out d))
            {
                setNutritionValues();
                setTotalWeight();
                if (lb_mealTypes.SelectedItems.Count > 0)
                {
                    btnOK.Enabled = true;
                }
            }
            else
                btnOK.Enabled = false;
        }

        private void cmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            setNutritionValues();
            setTotalWeight();
        }

        private void AddFood()
        {
            SqlCommand cmd;
            int MealId = getMealId();
            int DiaryId = getDiaryId(MealId);
            if (DiaryId > 0)
            {
                cmd = new SqlCommand("Update tblDiary SET amnt = @amnt, id_unit = @idUnit WHERE id = @idDiary", Global.conn1);
                cmd.Parameters.AddWithValue("@idDiary", DiaryId);
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO tblDiary (id_Meal, id_Food, amnt, id_Unit) VALUES (@idMeal, @idFood, @amnt, @idUnit)", Global.conn1);
            }
            
            cmd.Parameters.AddWithValue("@idMeal", MealId);
            cmd.Parameters.AddWithValue("@idFood", IdFood);
            cmd.Parameters.AddWithValue("@amnt", txtAmount.Text);
            cmd.Parameters.AddWithValue("@idUnit", cmbUnits.SelectedValue);
            if (Global.conn1.State != ConnectionState.Open) Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        private int getMealId()
        {
            int retVal = 0;
            SqlDataAdapter a = new SqlDataAdapter("SELECT id FROM tblMeals WHERE id_mealType = @idMealType AND date = @date AND idUser = @idUser", Global.conn1);
            a.SelectCommand.Parameters.AddWithValue("@idMealType", lb_mealTypes.SelectedValue);
            a.SelectCommand.Parameters.AddWithValue("@date", dtpDate.Value.Date);
            a.SelectCommand.Parameters.AddWithValue("@idUser", Global.idUser);
            DataTable tblMeals = new DataTable();
            a.Fill(tblMeals);
            if (tblMeals.Rows.Count > 0)
            {
                retVal = (int)tblMeals.Rows[0]["id"];
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblMeals (id_MealType, date, time, sortOrder, idUser) VALUES (@idType, @date, @time, @sortOrder, @idUser)", Global.conn1);
                cmd.Parameters.AddWithValue("@idType", lb_mealTypes.SelectedValue);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                cmd.Parameters.AddWithValue("@time", DateTime.Now);
                cmd.Parameters.AddWithValue("@sortOrder", 1);
                cmd.Parameters.AddWithValue("@idUser", Global.idUser);
                if (Global.conn1.State != ConnectionState.Open)
                {
                   Global.conn1.Open(); 
                }
                cmd.ExecuteNonQuery();
                Global.conn1.Close();
                a.Fill(tblMeals);
                retVal = (int)tblMeals.Rows[0]["id"];
            }
            return retVal;
        }

        private int getDiaryId(int MealId)
        {
            int DiaryId = 0;
            string sqlQuery = "SELECT id FROM tblDiary WHERE id_Meal = @idMeal AND id_Food = @idFood";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idMeal", MealId);
            cmd.Parameters.AddWithValue("@idFood", IdFood);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                DiaryId = reader.GetInt32(0);
            }
            Global.conn1.Close();
            return DiaryId;
        }

        private void lb_mealTypes_Click(object sender, EventArgs e)
        {
            if (IdFood != 0)
                btnOK.Enabled = true;
        }

        private void txtFoodFilter_TextChanged(object sender, EventArgs e)
        {
            FilterFood();
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

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                setFavourite((int)dgvFood[2, e.RowIndex].Value, (int)dgvFood[3, e.RowIndex].Value);
                getFood();
                getUnits();
                FilterFood();
            }
            IdFood = (int)dgvFood.SelectedRows[0].Cells[3].Value;
            getFoodInfo();
            setChart();
            getUnits();
            setUnit();
            txtAmount.Focus();
            txtAmount.SelectAll();
            if (lb_mealTypes.SelectedItems.Count > 0)
                btnOK.Enabled = true;
        }

        private void setUnit()
        {
            if (tblUnits == null)
                getUnits();
            string sqlSelect = "SELECT TOP 1 id FROM tblUnits WHERE idFood = @idFood ORDER BY id";
            SqlCommand cmd = new SqlCommand(sqlSelect, Global.conn1);
            cmd.Parameters.AddWithValue("@IdFood", IdFood);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtAmount.Text = "1";
                cmbUnits.SelectedValue = reader.GetInt32(0);
            }
            else
            {
                cmbUnits.SelectedValue = 1;
            }
            reader.Close();
            setTotalWeight();
        }

        private void setFavourite(int status, int idFood)
        {
            string sqlString;

            switch (status)
            {
                case 1:
                    sqlString = "DELETE FROM tblFavorites WHERE id_Food = @idFood";
                    break;
                default:
                    sqlString = "INSERT INTO tblFavorites (id_Food, id_User) VALUES (@idFood, @idUser)";
                    break;
            }

            SqlCommand cmd = new SqlCommand(sqlString, Global.conn1);
            cmd.Parameters.AddWithValue("@idFood", idFood);
            cmd.Parameters.AddWithValue("@idUser", 1);
            if (Global.conn1.State != ConnectionState.Open)
            {
                Global.conn1.Open();
            }
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "0" || Functions.IsNumeric(txtAmount.Text) == false)
            {
                MessageBox.Show("Skriv inn mengde");
                return;
            }
            AddFood();
            FoodUpdated(EventArgs.Empty);
            txtAmount.Focus();
            txtAmount.SelectAll();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmAddFood frm = new frmAddFood();
            frm.ShowDialog();
            getFood();
            FilterFood();
            getUnits();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            frmAddFood frm = new frmAddFood();
            frm.EditMode = true;
            frm.FoodId = IdFood;
            frm.ShowDialog();
            getUnits();
        }

        private void lb_mealTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int test = lb_mealTypes.SelectedIndex;
        }

        private void dgvFood_MouseEnter(object sender, EventArgs e)
        {
            dgvFood.Focus();
        }

        private void dgvFood_MouseLeave(object sender, EventArgs e)
        {
            txtAmount.Focus();
        }


    }
}
