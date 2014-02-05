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

        private void MealUpdated(object sender, EventArgs e)
        {
            getMeals();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            getMeals();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
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
            RemoveMealSummaries();
            string sqlString = "SELECT " +
                "tblMeals.id, " +
                "tblMeals.id_mealtype, " +
                "tblMeals.date, " +
                "tblMeals.time, " +
                "tblMeals.SortOrder, " +
                "tblMealTypes.Name " +
                "FROM tblMeals " +
                "LEFT OUTER JOIN tblMealTypes on tblMeals.id_mealType = tblMealTypes.id " +
                "WHERE date = @date AND idUser = @idUser" +
                " ORDER BY id_mealType, time";
            SqlDataAdapter a = new SqlDataAdapter(sqlString, clsGlobal.conn1);
            a.SelectCommand.Parameters.AddWithValue("@date", dtpDate.Value.Date);
            a.SelectCommand.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            tblMeals=new DataTable();
            a.Fill(tblMeals);
            
            foreach (DataRow row in tblMeals.Rows )
            {
                int MealId = (int)row["id"];
                Meal Meal = new Meal(MealId);
                int HeaderRowNo = dgvDiary.Rows.Add();
                dgvDiary.Rows[HeaderRowNo].DefaultCellStyle = HeadingStyle();
                dgvDiary.Rows[HeaderRowNo].Cells[1].Value = MealId;
                dgvDiary.Rows[HeaderRowNo].Cells[2].Value = row["Name"].ToString();
                dgvDiary.Rows[HeaderRowNo].Cells[3].Value = Meal.Energy.ToString("# ###.##") + " kCal";
                int n = 0;
                int RowNo;
                foreach (clsGlobal.Food Food in Meal.Foods)
                {
                    RowNo = dgvDiary.Rows.Add();
                    dgvDiary.Rows[RowNo].Cells[0].Value = Meal.Foods[n].idDiary;
                    dgvDiary.Rows[RowNo].Cells[1].Value = MealId;
                    dgvDiary.Rows[RowNo].Cells[2].Value = Meal.Foods[n].DisplayName;
                    dgvDiary.Rows[RowNo].Cells[3].Value = Meal.Foods[n].Energy.ToString("# ###.##") + " kCal";
                    
                    Carbs += Meal.Foods[n].Carbs;
                    Sugar += Meal.Foods[n].Sugar;
                    Fat += Meal.Foods[n].Fat;
                    FatSat += Meal.Foods[n].FatSat;
                    FatMono += Meal.Foods[n].FatMono;
                    FatPoly += Meal.Foods[n].FatPoly;
                    FatTrans += Meal.Foods[n].FatTrans;
                    Protein += Meal.Foods[n].Protein;
                    Alcohol += Meal.Foods[n].Alcohol;
                    Weight += Meal.Foods[n].Count * Meal.Foods[n].unitWeight;
                    n += 1;
                }
                dgvDiary.Rows[HeaderRowNo].Cells[2].Value = row["Name"].ToString() + " (F: " + Fat.ToString("0.0") + " g, K: " + Carbs.ToString("0.0") + " g, P: " + Protein.ToString("0.0") + " g, A: " + Alcohol.ToString("0.0") + ")";
                mealNo += 1;
                totalEnergy += Meal.Energy;
            }
            setDiaryGrid();
            AddDaySummary(mealNo, Carbs, Sugar, Fat, FatSat, FatMono, FatPoly, FatTrans, Protein, Alcohol, Weight, totalEnergy);
        }

        private void RemoveMealSummaries()
        {
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl.GetType().Name == "ucMealSummary")
                {
                    this.Controls.Remove(cntrl);
                }
            }
        }

        private void AddDaySummary(int mealNo, decimal Carbs, decimal Sugar, decimal Fat, decimal FatSat, decimal FatMono, decimal FatPoly, decimal FatTrans, decimal Protein, decimal Alcohol, decimal Weight, decimal Energy)
        {
            if (daySummary == null)
            {
                daySummary = new ucDaySummary();
                daySummary.Top = 81;
                daySummary.Left = dgvDiary.Left + dgvDiary.Width + 2;
                daySummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                this.Controls.Add(daySummary);
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
            dgvDiary.Columns[0].Visible = false;
            dgvDiary.Columns[1].Visible = false;
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

        private void bntAddFood_Click(object sender, EventArgs e)
        {
            frmEditDiary frm = new frmEditDiary();
            
            frm.ShowDialog();
        }

        private void btnNutritionDetails_Click(object sender, EventArgs e)
        {
            frmNutritionBreakdown frm = new frmNutritionBreakdown();
            frm.tblMeals = tblMeals;
            frm.ShowDialog();
        }


    }
}

