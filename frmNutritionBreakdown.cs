using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helsedagbok
{
    public partial class frmNutritionBreakdown : Form
    {
        DataTable m_tblMeals;

        public DataTable tblMeals
        {
            get { return m_tblMeals; }
            set { m_tblMeals = value; }
        }

        public frmNutritionBreakdown()
        {
            InitializeComponent();
        }

        private void frmNutritionBreakdown_Load(object sender, EventArgs e)
        {
            fill();
            this.Height = 50 + tblMeals.Rows.Count * 160;
        }

        private void fill()
        {
            int mealNo = 0;
            foreach (DataRow row in tblMeals.Rows)
            {
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

                int MealId = (int)row["id"];
                Meal Meal = new Meal(MealId);
                
                int n = 0;
                foreach (clsGlobal.Food Food in Meal.Foods)
                {
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
                AddMealSummary(mealNo, row, Carbs, Sugar, Fat, FatSat, FatMono, FatPoly, FatTrans, Protein, Alcohol, Weight, Meal);
                mealNo += 1;
            }
        }

        private void AddMealSummary(int mealNo, DataRow row, decimal Carbs, decimal Sugar, decimal Fat, decimal FatSat, decimal FatMono, decimal FatPoly, decimal FatTrans, decimal Protein, decimal Alcohol, decimal Weight, Meal Meal)
        {
            ucMealSummary mealSummary = new ucMealSummary();
            mealSummary.MealName = row["Name"].ToString();
            mealSummary.Energy = Meal.Energy;
            mealSummary.Carbs = Carbs;
            mealSummary.Sugar = Sugar;
            mealSummary.Fat = Fat;
            mealSummary.FatMono = FatMono;
            mealSummary.FatPoly = FatPoly;
            mealSummary.FatSat = FatSat;
            mealSummary.FatTrans = FatTrans;
            mealSummary.Protein = Protein;
            mealSummary.Alcohol = Alcohol;
            mealSummary.Weight = Weight;
            mealSummary.Top = 2 + (mealNo * 160);
            mealSummary.Left = 2;
            mealSummary.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.Controls.Add(mealSummary);
        }

    }
}
