using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Helsedagbok
{
    public class Meal
    {
        decimal m_Energy;
        decimal m_persFat;
        decimal m_persCarbs;
        decimal m_persProtein;
        decimal m_persAlcohol;
        int m_MealId;
        Global.Food[] m_foods;

#region "Properties"
        public Global.Food[] Foods
        {
            get { return m_foods; }
            set { m_foods = value; }
        }

        public decimal Energy
        {
            get { return m_Energy; }
            //set { m_Energy = value; }
        }
#endregion

        public Meal(int MealId)
        {
            m_MealId=MealId;
            getFoods();
            calculateTotalEnergy();
        }

        private void getFoods()
        {
            string sqlString = "SELECT " +
                "tblDiary.id AS DiaryId, " +
                "tblMeals.id AS MealId, " +
                "tblMatvarer.id AS FoodId, " +
                "tblMatvarer.Name, " +
                "tblMatvarer.Karbohydrat, " +
                "tblMatvarer.Sukker, " +
                "tblMatvarer.Fett, " +
                "tblMatvarer.Fett_mettet, " +
                "tblMatvarer.Fett_enum, " +
                "tblMatvarer.Fett_flerum, " +
                "tblMatvarer.Fett_trans, " +
                "tblMatvarer.Protein, " +
                "tblMatvarer.Alkohol, " +
                "tblDiary.amnt, " +
                "tblUnits.Name AS Unit, " +
                "tblUnits.id as id_Unit, " +
                "tblUnits.Weight as Unit_Weight, " +
                "tblMealTypes.Name AS MealType " +
                "FROM tblMeals " +
                "RIGHT OUTER JOIN tblDiary ON tblMeals.id = tblDiary.id_Meal " +
                "LEFT OUTER JOIN tblUnits ON tblDiary.id_unit = tblUnits.id " +
			    "LEFT OUTER JOIN tblMatvarer ON tblDiary.id_Food = tblMatvarer.id " +
                "LEFT OUTER JOIN tblMealTypes ON tblMealTypes.id = tblMeals.id_mealType " +
                "WHERE tblMeals.id = @mealId " +
                "ORDER BY DiaryId";
            SqlDataAdapter a = new SqlDataAdapter(sqlString, Global.conn1);
            a.SelectCommand.Parameters.AddWithValue("@mealId", m_MealId);
            DataTable tblFoods = new DataTable();
            a.Fill(tblFoods);
            int n = 0;
            Foods = new Global.Food[tblFoods.Rows.Count];
            foreach (DataRow row in tblFoods.Rows)
	        {
                try
                {
                    Foods[n].idDiary = (int)row["Diaryid"];
                    Foods[n].idFood = (int)row["Foodid"];
                    Foods[n].Name = (string)row["Name"];
                    Foods[n].Count = Convert.ToDecimal(row["amnt"]);
                    Foods[n].idUnit = (int)row["id_Unit"];
                    Foods[n].Unit = (string)row["Unit"];
                    Foods[n].unitWeight = Convert.ToDecimal(row["Unit_Weight"]);
                    decimal Mass = Foods[n].Count * Foods[n].unitWeight;
                    Foods[n].Carbs = Convert.ToDecimal(row["Karbohydrat"]) /100 * Mass;
                    Foods[n].Sugar = Convert.ToDecimal(row["Sukker"]) / 100 * Mass;
                    Foods[n].Fat = Convert.ToDecimal(row["Fett"]) / 100 * Mass;
                    Foods[n].FatSat = Convert.ToDecimal(row["Fett_mettet"]) / 100 * Mass;
                    Foods[n].FatMono = Convert.ToDecimal(row["Fett_enum"]) / 100 * Mass;
                    Foods[n].FatPoly = Convert.ToDecimal(row["Fett_flerum"]) / 100 * Mass;
                    Foods[n].FatTrans = (row["Fett_trans"] is DBNull) ? 0 : Convert.ToDecimal(row["Fett_trans"]) / 100 * Mass;
                    Foods[n].Protein = Convert.ToDecimal(row["Protein"]) / 100 * Mass;
                    Foods[n].Alcohol = Convert.ToDecimal(row["Alkohol"]) / 100 * Mass;
                    Foods[n].Energy = calculateEnergy(n);
                    Foods[n].DisplayName = Displayname(n);
                    n++;
                }
                catch (Exception)
                {}
                
	        }
        }

        private string Displayname(int Foodid)
        {
            string dn;
            dn = Foods[Foodid].Count + " " + Foods[Foodid].Unit + " " + Foods[Foodid].Name;
            return dn;
        }
        
        private void calculateTotalEnergy()
        {
            decimal eTotal = 0;
            decimal eFatTotal = 0;
            decimal eCarbsTotal = 0;
            decimal eProteinTotal = 0;
            decimal eAlcoholTotal = 0;
            
            foreach (Global.Food Food in Foods)
            {
                decimal Mass = Food.Count * Food.unitWeight;
                decimal eFat = Food.Fat * 9;// / 100 * Mass;
                decimal eCarbs = Food.Carbs * 4;// / 100 * Mass;
                decimal eProtein = Food.Protein * 4;// / 100 * Mass;
                decimal eAlcohol = Food.Alcohol * 7;// / 100 * Mass;
                eFatTotal += eFat;
                eCarbsTotal += eCarbs;
                eProteinTotal += eProtein;
                eAlcoholTotal += eAlcohol;
                eTotal += (eFat + eCarbs + eProtein + eAlcohol);
            }

            if (eTotal > 0)
            {
                m_persAlcohol = eAlcoholTotal / eTotal * 100;
                m_persCarbs = eCarbsTotal / eTotal * 100;
                m_persFat = eFatTotal / eTotal * 100;
                m_persProtein = eProteinTotal / eTotal * 100;
                m_Energy = eTotal;
            }
        }

        private decimal calculateEnergy(int FoodId)
        {
            decimal eFat = Foods[FoodId].Fat * 9;
            decimal eCarbs = Foods[FoodId].Carbs * 4;
            decimal eProtein = Foods[FoodId].Protein * 4;
            decimal eAlcohol = Foods[FoodId].Alcohol * 7;
            decimal Mass = Foods[FoodId].unitWeight * Foods[FoodId].Count;
            return (eFat + eCarbs + eProtein + eAlcohol);// /100 * Mass;
        }
    }
}
