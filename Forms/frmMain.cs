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
using Helsedagbok.Classes;
using Helsedagbok.Forms;
using Helsedagbok.User_Controls;

namespace Helsedagbok
{
    public partial class frmMain : Form
    {
        private DataTable _tblMeals;
        private ucDaySummary _daySummary;
        private int _idRecepie;

        public frmMain()
        {
            InitializeComponent();
            frmEditDiary.eFoodUpdated += MealUpdated;
            ucWorkout.WorkoutDeletedEvent += GetWorkouts;
            FrmRecepieSearch.RecepieSelectedEvent += RecepieSelected;
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblRecepieName.Text = "";
            pnlWorkouts.Width = 415 + System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            Functions.GetFormPositionSize (this);
            tabMain.SelectedIndex = (int)Functions.getRegistry("", "SelectedTab");

            getMeals();
            lblUserName.Text = getUser(Global.idUser);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.SetFormPositionSize(this);
            Functions.setRegistryKey("", "SelectedTab", tabMain.SelectedIndex);
        }

        private string getUser(int idUser)
        {
            string UserName = "";
            string sqlQuery = "SELECT FirstName + ' ' + LastName FROM tblUsers WHERE idUser = @idUser";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", idUser);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader userReader = cmd.ExecuteReader();
            if (userReader.HasRows)
            {
                userReader.Read();
                UserName = userReader.GetString(0);
            }
            Global.conn1.Close();
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
            SqlDataAdapter a = new SqlDataAdapter(sqlString, Global.conn1);
            a.SelectCommand.Parameters.AddWithValue("@date", dtpDate.Value.Date);
            a.SelectCommand.Parameters.AddWithValue("@idUser", Global.idUser);
            _tblMeals=new DataTable();
            a.Fill(_tblMeals);
            
            foreach (DataRow row in _tblMeals.Rows )
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
                    dgvDiary.Rows[HeaderRowNo].DefaultCellStyle = FoodDiaryHeadingStyle();
                    dgvDiary.Rows[HeaderRowNo].Cells[1].Value = MealId;
                    dgvDiary.Rows[HeaderRowNo].Cells[3].Value = row["Name"].ToString();
                    dgvDiary.Rows[HeaderRowNo].Cells[4].Value = Meal.Energy.ToString("# ###.##") + " kCal";
                    totalEnergy += Meal.Energy;
                    int RowNo;
                    foreach (Global.Food Food in Meal.Foods)
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
            if (_daySummary == null)
            {
                _daySummary = new ucDaySummary();
                _daySummary.Top = 81;
                _daySummary.Left = dgvDiary.Left + dgvDiary.Width + 2;
                _daySummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                tpFoodDiary.Controls.Add(_daySummary);
            }
            _daySummary.Energy = Energy;
            _daySummary.Carbs = Carbs;
            _daySummary.Sugar = Sugar;
            _daySummary.Fat = Fat;
            _daySummary.FatMono = FatMono;
            _daySummary.FatPoly = FatPoly;
            _daySummary.FatSat = FatSat;
            _daySummary.FatTrans = FatTrans;
            _daySummary.Protein = Protein;
            _daySummary.Alcohol = Alcohol;
            _daySummary.Weight = Weight;
            _daySummary.setValues();
        }

        private void setDiaryGrid()
        {
            dgvDiary.Columns[0].Visible = false;
            dgvDiary.Columns[1].Visible = false;
            dgvDiary.Columns[2].Visible = false;
            dgvDiary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiary.ClearSelection();
        }

        private DataGridViewCellStyle FoodDiaryHeadingStyle()
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

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmEditDiary frm = new frmEditDiary();
            frm.DiaryDate = dtpDate.Value;
            frm.ShowDialog();
        }

        private void btnNutritionDetails_Click(object sender, EventArgs e)
        {
            frmNutritionBreakdown frm = new frmNutritionBreakdown();
            frm.tblMeals = _tblMeals;
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblDiary WHERE id = @idDiary",Global.conn1);
                    cmd.Parameters.AddWithValue("@idDiary", idDiary);
                    if (Global.conn1.State != ConnectionState.Open)
                        Global.conn1.Open();
                    cmd.ExecuteNonQuery();
                    Global.conn1.Close();
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
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idDiary", (int)dgvDiary.SelectedRows[0].Cells[0].Value);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idFood = reader.GetInt32(2);
                idUnit = reader.GetInt32(4);
                idMealType = reader.GetInt32(5);
                amnt = reader.GetDecimal(3);
                reader.Close();
                Global.conn1.Close();
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

            //TODO: Legg til dialog for å velge dato.

            DataTable tblMeal = new DataTable();

            string sqlSelect = "SELECT * FROM tblMeals WHERE id = @idMeal";
            int idMeal = (int)dgvDiary.SelectedRows[0].Cells[1].Value;
            int idMealType = 0;
            SqlCommand cmd = new SqlCommand(sqlSelect, Global.conn1);
            cmd.Parameters.AddWithValue("@idMeal", idMeal);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idMealType = reader.GetInt32(1);
                reader.Close();
            }

            string sqlInsert = "INSERT INTO tblMeals (id_mealType, date, time, SortOrder, idUser) VALUES (@idMealType, @Date, @Time, 1, @idUser); Select @NewId = SCOPE_IDENTITY();";
            cmd = new SqlCommand(sqlInsert, Global.conn1);
            cmd.Parameters.AddWithValue("@idMealType", idMealType);
            cmd.Parameters.AddWithValue("@Date", DateTime.Today);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToLocalTime());
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            cmd.Parameters.Add("@NewID",SqlDbType.Int).Direction=ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int NewIdMeal = Convert.ToInt32(cmd.Parameters["@NewID"].Value);

            sqlSelect = "SELECT id, @newIDMeal, id_Food, Amnt, id_Unit FROM tblDiary WHERE id_Meal = @idMeal";
            SqlDataAdapter daMeal = new SqlDataAdapter(sqlSelect,Global.conn1);
            daMeal.SelectCommand.Parameters.AddWithValue("@newIDMeal", NewIdMeal);
            daMeal.SelectCommand.Parameters.AddWithValue("@idMeal", idMeal);
            daMeal.Fill(tblMeal);

            using (SqlBulkCopy bk = new SqlBulkCopy(Global.conn1))
            {
                bk.DestinationTableName = "tblDiary";
                bk.WriteToServer(tblMeal);
            }
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
        private void btnAddRecepieIngredient_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRecepieSearch_Click(object sender, EventArgs e)
        {
            FrmRecepieSearch frm = new FrmRecepieSearch();
            frm.TopMost = true;
            frm.Show();
        }
 
        private void btnAddRecepie_Click(object sender, EventArgs e)
        {
            FrmRecepies frm = new FrmRecepies();
            frm.Title = "Ny oppskrift.";
            frm.EditMode = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _idRecepie = frm.IdRecepie;
                lblRecepieName.Text = frm.RecepieName;
                GetRecepieProperties(_idRecepie);
            }
            
        }
       
        private void RecepieSelected(object sender, RecepieSelectedEventArgs e)
        {
            pnlRecepieIngredients.Controls.Clear();
            _idRecepie = e.RecepieId;
            lblRecepieName.Text = e.RecepieName;
            GetRecepieProperties(e.RecepieId);
            GetRecepieHeadings();
        }

        private void GetRecepieProperties(int recepieId)
        {
            lblRecepieCategories.Text = "";
            RecepieProperties properties = Recepies.GetRecepieProperties(recepieId);
            foreach (string cat in properties.Categories)
            {
                if (lblRecepieCategories.Text != "")
                    lblRecepieCategories.Text += ", ";
                lblRecepieCategories.Text += cat;
            }
            lblRecepieTime.Text = properties.Time;
            lblRecepieDifficulty.Text = properties.Difficulty;
            lblRecepieServings.Text = properties.Servings.ToString();
        }

        private void GetRecepieHeadings()
        {
            Point recepieHeadingLocation = new Point(0, 0);
            string sql = "SELECT idRecepieHeading, Name, SortOrder " +
                         "FROM tblRecepieHeadings " +
                         "WHERE idRecepie=" + _idRecepie +
                         " ORDER BY SortOrder";
            DataTable tbl = Functions.GetTable(sql);
            foreach (DataRow row in tbl.Rows)
            {
                UcRecepiePart heading = new UcRecepiePart();
                heading.RecepiePartName = row["Name"].ToString();
                heading.IdRecepieHeading = (int)row["idRecepieHeading"];
                heading.Location = recepieHeadingLocation;
                heading.GetRecepieIngredients();
                pnlRecepieIngredients.Controls.Add(heading);
                recepieHeadingLocation.Y += heading.Height;
            }
        }

        #endregion

        #region Trening
        private DataGridViewCellStyle WorkoutHeadingStyle()
        {
            DataGridViewCellStyle HeadingStyle = new DataGridViewCellStyle(dgvDiary.DefaultCellStyle);
            Font HeadingFont = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            HeadingStyle.Font = HeadingFont;
            HeadingStyle.BackColor = Color.SteelBlue;
            HeadingStyle.ForeColor = Color.White;
            HeadingStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            return HeadingStyle;
        }

        private DataGridViewCellStyle ExerciseHeadingStyle()
        {
            DataGridViewCellStyle HeadingStyle = new DataGridViewCellStyle(dgvDiary.DefaultCellStyle);
            Font HeadingFont = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            HeadingStyle.Font = HeadingFont;
            HeadingStyle.BackColor = Color.CadetBlue;
            HeadingStyle.ForeColor = Color.White;
            HeadingStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            return HeadingStyle;
        }

        private void GetWorkouts(object sender, EventArgs e)
        {
            pnlWorkouts.Controls.Clear();
            WorkoutHeader[] workouts = Workout.GetWorkouts(dtpWorkoutDate.Value);
            if (workouts == null)
                return;
            int lineNo = 0;
            foreach (WorkoutHeader workout in workouts)
            {
                ucWorkout wo = new ucWorkout();
                wo.Title = workout.Name;
                wo.IdWorkout = workout.IdWorkout;
                wo.DateTime = dtpWorkoutDate.Value;
                wo.Location = new Point(0, 29*lineNo);
                pnlWorkouts.Controls.Add(wo);
                wo.GetExercises();
                lineNo += 1;

                //TODO: Add workout summary.
            }
        }

        private void dtpWorkoutDate_ValueChanged(object sender, EventArgs e)
        {
            GetWorkouts(null, null);
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            frmWorkout frm = new frmWorkout();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Workout.AddWorkout(frm.WorkoutName,frm.WorkoutLocation,dtpWorkoutDate.Value,frm.Duration);
                GetWorkouts(null, null);
            }
        }
        #endregion

    }
}

