using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Helsedagbok
{
    public partial class ucDaySummary : UserControl
    {
        public ucDaySummary()
        {
            InitializeComponent();
        }

        string m_Name;
        decimal m_Energy;
        decimal m_Carbs;
        decimal m_Sugar;
        decimal m_Fat;
        decimal m_FatSat;
        decimal m_FatMono;
        decimal m_FatPoly;
        decimal m_FatTrans;
        decimal m_Protein;
        decimal m_Alcohol;
        decimal m_weight;

        #region "Properties"
        public string MealName
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public decimal Energy
        {
            get { return m_Energy; }
            set { m_Energy = value; }
        }

        public decimal Carbs
        {
            get { return m_Carbs; }
            set { m_Carbs = value; }
        }

        public decimal Sugar
        {
            get { return m_Sugar; }
            set { m_Sugar = value; }
        }

        public decimal Fat
        {
            get { return m_Fat; }
            set { m_Fat = value; }
        }

        public decimal FatSat
        {
            get { return m_FatSat; }
            set { m_FatSat = value; }
        }

        public decimal FatMono
        {
            get { return m_FatMono; }
            set { m_FatMono = value; }
        }

        public decimal FatPoly
        {
            get { return m_FatPoly; }
            set { m_FatPoly = value; }
        }

        public decimal FatTrans
        {
            get { return m_FatTrans; }
            set { m_FatTrans = value; }
        }

        public decimal Protein
        {
            get { return m_Protein; }
            set { m_Protein = value; }
        }

        public decimal Alcohol
        {
            get { return m_Alcohol; }
            set { m_Alcohol = value; }
        }

        public decimal Weight
        {
            get { return m_weight; }
            set { m_weight = value; }
        }
        #endregion


        public void setValues()
        {
            lblEnergy.Text = Energy.ToString("0.0");
            lblCarbs.Text = Carbs.ToString("0.0");
            lblSugar.Text = Sugar.ToString("0.0");
            lblFat.Text = Fat.ToString("0.0");
            lblFatSat.Text = FatSat.ToString("0.0");
            lblFatMono.Text = FatMono.ToString("0.0");
            lblFatPoly.Text = FatPoly.ToString("0.0");
            lblFatTrans.Text = FatTrans.ToString("0.0");
            lblProtein.Text = Protein.ToString("0.0");
            lblAlcohol.Text = Alcohol.ToString("0.0");
            lblWeight.Text = Weight.ToString("0.0");
            setChart();
            setPerWeight();
            getGoals();
            setColors();
        }
        
        private void setChart()
        {
            decimal[] yValues = { 50, 35, 15, 0 };
            String[] xValues = { "50%", "35%", "15%", "0%" };
            if (Energy != 0)
            {
                yValues[0] = Carbs * 4 / Energy * 100;
                yValues[1] = Protein * 4 / Energy * 100;
                yValues[2] = Fat * 9 / Energy * 100;
                yValues[3] = Alcohol * 7 / Energy * 100;
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

        private void setPerWeight() 
        {
            decimal Weight = 0;
            string selectString = "SELECT TOP 1 Weight FROM tblMeasurement WHERE idUser = 1 ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(selectString, clsGlobal.conn1);
            if (clsGlobal.conn1.State != ConnectionState.Open)
            {
                clsGlobal.conn1.Open();
            }
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                    Weight = myReader.GetDecimal(0);
            }
            myReader.Close();
            clsGlobal.conn1.Close();
            if (Weight > 0)
            {
                lblCarbsWeight.Text = (Carbs / Weight).ToString("0.00");
                lblFatWeight.Text = (Fat / Weight).ToString("0.00");
                lblProteinWeight.Text = (Protein / Weight).ToString("0.00");
                lblAlcoholWeight.Text = (Alcohol / Weight).ToString("0.00");
            }
        }

        private void getGoals()
        {
            decimal Calories = 0;
            decimal Carbs = 0;
            decimal Fat = 0;
            decimal Protein = 0;
            decimal Fiber = 0;

            string selectString = "SELECT TOP 1 * FROM tblNutritionGoals WHERE idUser = 1 ORDER BY idGoal DESC";
            SqlCommand cmd = new SqlCommand(selectString, clsGlobal.conn1);
            if (clsGlobal.conn1.State != ConnectionState.Open)
            {
                clsGlobal.conn1.Open();
            }
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    Calories = myReader.GetDecimal(2);
                    Carbs = myReader.GetDecimal(3);
                    Fat = myReader.GetDecimal(4);
                    Protein = myReader.GetDecimal(5);
                    Fiber = myReader.GetDecimal(6);
                }
            }
            myReader.Close();
            clsGlobal.conn1.Close();

            lblEnergyGoal.Text = Calories.ToString("0.0");
            lblCarbsGoal.Text = Carbs.ToString("0.0");
            lblFatGoal.Text = Fat.ToString("0.0");
            lblProteinGoal.Text = Protein.ToString("0.0");

        }

        private void setColors()
        {
            if (Convert.ToDecimal(lblEnergy.Text) > Convert.ToDecimal(lblEnergyGoal.Text))
                lblEnergy.ForeColor=Color.Red;
            if (Convert.ToDecimal(lblCarbs.Text) > Convert.ToDecimal(lblCarbsGoal.Text))
                lblCarbs.ForeColor=Color.Red;
            if (Convert.ToDecimal(lblFat.Text) > Convert.ToDecimal(lblFatGoal.Text))
                lblFat.ForeColor = Color.Red;
            if (Convert.ToDecimal(lblProtein.Text) > Convert.ToDecimal(lblProteinGoal.Text))
                lblProtein.ForeColor = Color.Red;
        }
    }
}
