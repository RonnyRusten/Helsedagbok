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
using System.Data.SqlTypes;


namespace Helsedagbok
{

    public partial class frmMain : Form
    {
        DataTable tblMeals;
        ucDaySummary daySummary;

        public frmMain()
        {
            InitializeComponent();
            frmEditDiary.eFoodUpdated += MealUpdated;
            
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            getMeals();
            lblUserName.Text = getUser(clsGlobal.idUser);
            getRecepieCategories();
            getRecepies();
        }

        private string getUser(int idUser)
        {
            string UserName = "";
            string sqlQuery = "SELECT FirstName + ' ' + LastName FROM tblUsers WHERE idUser = @idUser";
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idUser", idUser);
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
            SqlDataReader userReader = cmd.ExecuteReader();
            if (userReader.HasRows)
            {
                userReader.Read();
                UserName = userReader.GetString(0);
            }
            clsGlobal.conn1.Close();
            return UserName;
        }



#region Næringsinnhold

        private void MealUpdated(object sender, EventArgs e)
        {
            getMeals();
        }

        private void getMeals()
        {
            int mealNo = 0;
            decimal Carbs = 0;
            decimal Sugar = 0;
            decimal Fat = 0;
            decimal FatSat = 0;
            decimal FatMono = 0;
            decimal FatPoly = 0;
            decimal FatTrans = 0;
            decimal Protein = 0;
            decimal Alcohol = 0;
            decimal Weight = 0;
            decimal totalEnergy = 0;

            dgvDiary.Rows.Clear();
            string sqlString = "SELECT " +
                "tblMeals.id, " +
                "tblMeals.id_mealtype, " +
                "tblMeals.date, " +
                "tblMeals.time, " +
                "tblMealTypes.SortOrder, " +
                "tblMealTypes.Name " +
                "FROM tblMeals " +
                "LEFT OUTER JOIN tblMealTypes on tblMeals.id_mealType = tblMealTypes.id " +
                "WHERE date = @date AND tblMeals.idUser = @idUser" +
                " ORDER BY tblMealTypes.SortOrder, time";
            SqlDataAdapter a = new SqlDataAdapter(sqlString, clsGlobal.conn1);
            a.SelectCommand.Parameters.AddWithValue("@date", dtpDate.Value.Date);
            a.SelectCommand.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            tblMeals=new DataTable();
            a.Fill(tblMeals);
            
            foreach (DataRow row in tblMeals.Rows )
            {
                decimal MealCarbs = 0;
                decimal MealFat = 0;
                decimal MealProtein = 0;
                decimal MealAlcohol = 0;
                int MealId = (int)row["id"];
                Meal Meal = new Meal(MealId);
                if (Meal.Foods.Length > 0)
                {
                    int HeaderRowNo = dgvDiary.Rows.Add();
                    dgvDiary.Rows[HeaderRowNo].DefaultCellStyle = HeadingStyle();
                    dgvDiary.Rows[HeaderRowNo].Cells[1].Value = MealId;
                    dgvDiary.Rows[HeaderRowNo].Cells[3].Value = row["Name"].ToString();
                    dgvDiary.Rows[HeaderRowNo].Cells[4].Value = Meal.Energy.ToString("# ###.##") + " kCal";
                    totalEnergy += Meal.Energy;
                    int RowNo;
                    foreach (clsGlobal.Food Food in Meal.Foods)
                    {
                        RowNo = dgvDiary.Rows.Add();
                        dgvDiary.Rows[RowNo].Cells[0].Value = Food.idDiary;
                        dgvDiary.Rows[RowNo].Cells[1].Value = MealId;
                        dgvDiary.Rows[RowNo].Cells[2].Value = Food.idFood;
                        dgvDiary.Rows[RowNo].Cells[3].Value = Food.DisplayName;
                        dgvDiary.Rows[RowNo].Cells[4].Value = Food.Energy.ToString("# ###.##") + " kCal";

                        Carbs += Food.Carbs;
                        MealCarbs += Food.Carbs;
                        Sugar += Food.Sugar;
                        Fat += Food.Fat;
                        MealFat += Food.Fat;
                        FatSat += Food.FatSat;
                        FatMono += Food.FatMono;
                        FatPoly += Food.FatPoly;
                        FatTrans += Food.FatTrans;
                        Protein += Food.Protein;
                        MealProtein += Food.Protein;
                        Alcohol += Food.Alcohol;
                        MealAlcohol += Food.Alcohol;
                        Weight += Food.Count * Food.unitWeight;
                    }
                }
            }
            setDiaryGrid();
            AddDaySummary(mealNo, Carbs, Sugar, Fat, FatSat, FatMono, FatPoly, FatTrans, Protein, Alcohol, Weight, totalEnergy);
        }

        private void AddDaySummary(int mealNo, decimal Carbs, decimal Sugar, decimal Fat, decimal FatSat, decimal FatMono, decimal FatPoly, decimal FatTrans, decimal Protein, decimal Alcohol, decimal Weight, decimal Energy)
        {
            if (daySummary == null)
            {
                daySummary = new ucDaySummary();
                daySummary.Top = 81;
                daySummary.Left = dgvDiary.Left + dgvDiary.Width + 2;
                daySummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                tpFoodDiary.Controls.Add(daySummary);
            }
            daySummary.Energy = Energy;
            daySummary.Carbs = Carbs;
            daySummary.Sugar = Sugar;
            daySummary.Fat = Fat;
            daySummary.FatMono = FatMono;
            daySummary.FatPoly = FatPoly;
            daySummary.FatSat = FatSat;
            daySummary.FatTrans = FatTrans;
            daySummary.Protein = Protein;
            daySummary.Alcohol = Alcohol;
            daySummary.Weight = Weight;
            daySummary.setValues();
        }

        private void setDiaryGrid()
        {
            //dgvDiary.Columns[0].Visible = false;
            //dgvDiary.Columns[1].Visible = false;
            //dgvDiary.Columns[2].Visible = false;
            dgvDiary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiary.ClearSelection();
        }

        private DataGridViewCellStyle HeadingStyle()
        {
            DataGridViewCellStyle HeadingStyle = new DataGridViewCellStyle(dgvDiary.DefaultCellStyle);
            Font HeadingFont = new Font(DataGridView.DefaultFont, FontStyle.Bold); ;
            HeadingStyle.Font = HeadingFont;
            HeadingStyle.BackColor = Color.SteelBlue;
            HeadingStyle.ForeColor = Color.White;
            HeadingStyle.Alignment = DataGridViewContentAlignment.TopRight;
            return HeadingStyle;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            getMeals();
        }

        private void bntAddFood_Click(object sender, EventArgs e)
        {
            frmEditDiary frm = new frmEditDiary();
            frm.DiaryDate = dtpDate.Value;
            frm.ShowDialog();
        }

        private void btnNutritionDetails_Click(object sender, EventArgs e)
        {
            frmNutritionBreakdown frm = new frmNutritionBreakdown();
            frm.tblMeals = tblMeals;
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSetup frm = new frmSetup();
            frm.ShowDialog();
            getMeals();
        }
        
        private void cmFood_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDiary.SelectedRows[0].Cells[0].Value == null)
            {
                miCopyMeal.Visible = true;
                miMoveMeal.Visible = true;
                miEditFood.Visible = false;
                miDeleteFood.Visible = false;
            }
            else
            {
                miCopyMeal.Visible = false;
                miMoveMeal.Visible = false;
                miEditFood.Visible = true;
                miDeleteFood.Visible = true;
            }
        }

        private void miDeleteFood_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count > 0)
            {
                int idDiary = (int)dgvDiary.SelectedRows[0].Cells[0].Value;
                string FoodName = dgvDiary.SelectedRows[0].Cells[3].Value.ToString();
                if (MessageBox.Show("Vil du slette " + FoodName + "?", "Slette?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblDiary WHERE id = @idDiary",clsGlobal.conn1);
                    cmd.Parameters.AddWithValue("@idDiary", idDiary);
                    if (clsGlobal.conn1.State != ConnectionState.Open)
                        clsGlobal.conn1.Open();
                    cmd.ExecuteNonQuery();
                    clsGlobal.conn1.Close();
                    getMeals();
                }
            }
        }

        private void miEditFood_Click(object sender, EventArgs e)
        {
            int idFood;
            int idUnit;
            int idMealType;
            decimal amnt;
            if (dgvDiary.SelectedRows[0].Cells[0].Value == null)
                return;
            string sqlQuery = "SELECT " +
                              "tblDiary.id, " +
                              "tblDiary.id_Meal, " +
                              "tblDiary.id_Food, " +
                              "tblDiary.amnt, " +
                              "tblDiary.id_unit, " +
                              "tblMeals.id_mealType " +
                              "FROM tblDiary " +
                              "left join tblMeals on tblmeals.id = tblDiary.id_Meal " +
                              "WHERE tblDiary.id = @idDiary";
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idDiary", (int)dgvDiary.SelectedRows[0].Cells[0].Value);
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idFood = reader.GetInt32(2);
                idUnit = reader.GetInt32(4);
                idMealType = reader.GetInt32(5);
                amnt = reader.GetDecimal(3);
                reader.Close();
                clsGlobal.conn1.Close();
                frmEditDiary frm = new frmEditDiary();
                frm.DiaryDate = dtpDate.Value.Date;
                frm.IdFood = idFood;
                frm.IdUnit = idUnit;
                frm.IdMealType = idMealType;
                frm.amnt = amnt;
                frm.ShowDialog();
            }
        }

        private void miCopyMeal_Click(object sender, EventArgs e)
        {
            int idMeal = (int)dgvDiary.SelectedRows[0].Cells[0].Value;
            //tblMeals, id + id_mealType
            //tblDiary, id_Meal
        }

        private void miMoveMeal_Click(object sender, EventArgs e)
        {
            int idMeal = (int)dgvDiary.SelectedRows[0].Cells[0].Value;
            //tblMeals, id + date
        }

        private void dgvDiary_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dgvDiary.Rows[rowSelected].Selected = true;
                }
            }
        }

#endregion

#region Oppskrifter
        private void getRecepieCategories()
        {
            DataTable tblCategories = new DataTable();
            string sqlSelect;

            sqlSelect = "SELECT idCategory,CategoryName AS Kategori FROM tblCategories ORDER BY CategoryName";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, clsGlobal.conn1);
            adapter.Fill(tblCategories);
            dgvCategories.DataSource = tblCategories;
            dgvCategories.Columns[0].Visible = false;
            dgvCategories.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvCategories.se
        }

        private void getRecepies()
        {
            DataTable tblRecepies = new DataTable();
            string sqlSelect;

            sqlSelect = "SELECT idRecepie, Name AS Oppskrift FROM tblRecepies";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, clsGlobal.conn1);
            adapter.Fill(tblRecepies);
            dgvRecepies.DataSource = tblRecepies;
            dgvRecepies.Columns[0].Visible = false;
            dgvRecepies.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void getReceiptProperties()
        {
            string sqlSelect = "SELECT tblCategories.CategoryName " +
                                ", tblRecepies.Time " +
                                ", tblRecepies.Porsjoner " +
                                ", tblDifficulties.Difficulty " +
                                "FROM tblRecepies " +
                                "JOIN tblRecepie_categories ON tblRecepie_categories.id_recepie = tblRecepies.idRecepie " +
                                "JOIN tblCategories ON tblCategories.idCategory = tblRecepie_categories.id_Category " +
                                "WHERE tblRecepies.idRecepie = @idRecepie";
            

        }
#endregion

    }
}

