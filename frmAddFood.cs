﻿using System;
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
    public partial class frmAddFood : Form
    {
        private bool m_EditMode;
        private int m_FoodId;

        public int FoodId
        {
            get { return m_FoodId; }
            set { m_FoodId = value; }
        }

        public bool EditMode
        {
            get { return m_EditMode; }
            set { m_EditMode = value; }
        }

        public frmAddFood()
        {
            InitializeComponent();
        }

        private void txtCalories_TextChanged(object sender, EventArgs e)
        {
            calculateEnergy();
        }

        private void txtCarbohydrates_TextChanged(object sender, EventArgs e)
        {
            calculateEnergy();
        }

        private void txtFat_TextChanged(object sender, EventArgs e)
        {
            calculateEnergy();
        }

        private void txtProtein_TextChanged(object sender, EventArgs e)
        {
            calculateEnergy();
        }

        private void txtAlcohol_TextChanged(object sender, EventArgs e)
        {
            calculateEnergy();
        }

        private void calculateEnergy()
        {
            decimal[] yValues = { 50, 35, 15, 0 };
            String[] xValues = { "50%", "35%", "15%", "0%" };
            decimal eCarbs = 0;
            decimal eProtein = 0;
            decimal eFat = 0;
            decimal eAlcohol = 0;
            decimal eTotal = 0;
            if (clsFunctions.IsNumeric(txtCalories.Text) == true)
                eTotal = Convert.ToDecimal(txtCalories.Text);
            if (eTotal > 0)
            {
                if (clsFunctions.IsNumeric(txtCarbohydrates.Text) == true)
                    eCarbs = Convert.ToDecimal(txtCarbohydrates.Text) * 4 / eTotal * 100;
                if (clsFunctions.IsNumeric(txtProtein.Text) == true)
                    eProtein = Convert.ToDecimal(txtProtein.Text) * 4 / eTotal * 100;
                if (clsFunctions.IsNumeric(txtFat.Text) == true)
                    eFat = Convert.ToDecimal(txtFat.Text) * 9 / eTotal * 100;
                if (clsFunctions.IsNumeric(txtAlcohol.Text) == true)
                    eAlcohol = Convert.ToDecimal(txtAlcohol.Text) * 7 / eTotal * 100;
            }
            yValues[0] = eCarbs;
            yValues[1] = eProtein;
            yValues[2] = eFat;
            yValues[3] = eAlcohol;

            xValues[0] = "Karbohydrat: " + yValues[0].ToString("0.0") + "%";
            xValues[1] = "Protein: " + yValues[1].ToString("0.0") + "%";
            xValues[2] = "Fett: " + yValues[2].ToString("0.0") + "%";
            xValues[3] = "Alkohol: " + yValues[3].ToString("0.0") + "%";

            pcNutrition.Legends[0].Enabled = true;
            pcNutrition.Series["Default"].Points.DataBindXY(xValues, yValues);
            pcNutrition.ChartAreas[0].Area3DStyle.Enable3D = true;
            pcNutrition.Series["Default"]["PieLabelStyle"] = "Disabled";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int result;
            if (EditMode == true)
            {
                result = updateDB();
                this.Close();
            }
            else
            {
                result = addToDB();
            }
            if (result > 0)
            {
                txtName.Text = "";
                txtCalories.Text = "0";
                txtSugars.Text = "0";
                txtProtein.Text = "0";
                txtFat.Text = "0";
                txtSatFat.Text = "0";
                txtMonoFat.Text = "0";
                txtPolyFat.Text = "0";
                txtTransFat.Text = "0";
                txtCarbohydrates.Text = "0";
                txtFiber.Text = "0";
                txtAlcohol.Text = "0";
                txtNatrium.Text = "0";
            }
            else
            {
                MessageBox.Show(txtName.Text + " ble ikke lagt til i basen!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int addToDB()
        {
            int numRows;
            SqlCommand cmd = new SqlCommand();
            string sqlString = "INSERT INTO tblMatvarer (Name, Energi_kCal, Protein, Fett, Fett_mettet, Fett_enum, Fett_flerum, Fett_trans, Karbohydrat, Sukker, Kostfiber, Alkohol, Natrium) " +
                "VALUES (@Name, @kCal, @Protein, @Fat, @FatSat, @FatMono, @FatPoly, @FatTrans, @Carbs, @Sugar, @Fiber, @Alcohol, @Natrium)";
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@kCal", Convert.ToDecimal(txtCalories.Text));
            cmd.Parameters.AddWithValue("@Protein", Convert.ToDecimal(txtProtein.Text));
            cmd.Parameters.AddWithValue("@Fat", Convert.ToDecimal(txtFat.Text));
            cmd.Parameters.AddWithValue("@FatSat", Convert.ToDecimal(txtSatFat.Text));
            cmd.Parameters.AddWithValue("@FatMono", Convert.ToDecimal(txtMonoFat.Text));
            cmd.Parameters.AddWithValue("@FatPoly", Convert.ToDecimal(txtPolyFat.Text));
            cmd.Parameters.AddWithValue("@FatTrans", Convert.ToDecimal(txtTransFat.Text));
            cmd.Parameters.AddWithValue("@Carbs", Convert.ToDecimal(txtCarbohydrates.Text));
            cmd.Parameters.AddWithValue("@Sugar", 0);
            cmd.Parameters.AddWithValue("@Fiber", Convert.ToDecimal(txtFiber.Text));
            cmd.Parameters.AddWithValue("@Alcohol", Convert.ToDecimal(txtAlcohol.Text));
            cmd.Parameters.AddWithValue("@Natrium", Convert.ToDecimal(txtNatrium.Text));
            cmd.CommandText = sqlString;
            cmd.Connection = clsGlobal.conn1;
            if (clsGlobal.conn1.State == ConnectionState.Closed)
                clsGlobal.conn1.Open();
            numRows = cmd.ExecuteNonQuery();
            clsGlobal.conn1.Close();
            return numRows;
        }

        private int updateDB()
        {
            int numRows;
            SqlCommand cmd = new SqlCommand();
            string sqlString = "UPDATE tblMatvarer SET Name = @Name, Energi_kCal = @kCal, Protein = @Protein, Fett = @Fat, " +
                "Fett_mettet = @FatSat, Fett_enum = @FatMono, Fett_flerum = @FatPoly, Fett_trans = @FatTrans, " +
                "Karbohydrat = @Carbs, Sukker = @Sugar, Kostfiber = @Fiber, Alkohol = @Alcohol, Natrium = @Natrium " +
                "WHERE id = @FoodId";
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@kCal", Convert.ToDecimal(txtCalories.Text));
            cmd.Parameters.AddWithValue("@Protein", Convert.ToDecimal(txtProtein.Text));
            cmd.Parameters.AddWithValue("@Fat", Convert.ToDecimal(txtFat.Text));
            cmd.Parameters.AddWithValue("@FatSat", Convert.ToDecimal(txtSatFat.Text));
            cmd.Parameters.AddWithValue("@FatMono", Convert.ToDecimal(txtMonoFat.Text));
            cmd.Parameters.AddWithValue("@FatPoly", Convert.ToDecimal(txtPolyFat.Text));
            cmd.Parameters.AddWithValue("@FatTrans", Convert.ToDecimal(txtTransFat.Text));
            cmd.Parameters.AddWithValue("@Carbs", Convert.ToDecimal(txtCarbohydrates.Text));
            cmd.Parameters.AddWithValue("@Sugar", Convert.ToDecimal(txtSugars.Text));
            cmd.Parameters.AddWithValue("@Fiber", Convert.ToDecimal(txtFiber.Text));
            cmd.Parameters.AddWithValue("@Alcohol", Convert.ToDecimal(txtAlcohol.Text));
            cmd.Parameters.AddWithValue("@Natrium", Convert.ToDecimal(txtNatrium.Text));
            cmd.Parameters.AddWithValue("@FoodId", FoodId);
            cmd.CommandText = sqlString;
            cmd.Connection = clsGlobal.conn1;
            if (clsGlobal.conn1.State == ConnectionState.Closed)
                clsGlobal.conn1.Open();
            numRows = cmd.ExecuteNonQuery();
            clsGlobal.conn1.Close();
            return numRows;
        }
        private void getFood(int FoodID)
        {
            string sqlQuery = "SELECT * FROM tblMatvarer WHERE id = @FoodID";
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@FoodID", FoodID);
            if (clsGlobal.conn1.State != ConnectionState.Open)
            {
                clsGlobal.conn1.Open();
            }
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    txtName.Text = myReader.GetString(1);
                    if (!myReader.IsDBNull(4))
                        txtCalories.Text = myReader.GetDecimal(4).ToString();
                    if (!myReader.IsDBNull(12))
                        txtCarbohydrates.Text = myReader.GetDecimal(12).ToString();
                    if (!myReader.IsDBNull(13))
                        txtSugars.Text = myReader.GetDecimal(13).ToString();
                    if (!myReader.IsDBNull(6))
                        txtFat.Text = myReader.GetDecimal(6).ToString();
                    if (!myReader.IsDBNull(7))
                        txtSatFat.Text = myReader.GetDecimal(7).ToString();
                    if (!myReader.IsDBNull(9))
                        txtMonoFat.Text = myReader.GetDecimal(9).ToString();
                    if (!myReader.IsDBNull(10))
                        txtPolyFat.Text = myReader.GetDecimal(10).ToString();
                    if (!myReader.IsDBNull(8))
                        txtTransFat.Text = myReader.GetDecimal(8).ToString();
                    if (!myReader.IsDBNull(5))
                        txtProtein.Text = myReader.GetDecimal(5).ToString();
                    if (!myReader.IsDBNull(15))
                        txtAlcohol.Text = myReader.GetDecimal(15).ToString();
                    if (!myReader.IsDBNull(26))
                        txtNatrium.Text = myReader.GetDecimal(26).ToString();
                    if (!myReader.IsDBNull(14))
                        txtFiber.Text = myReader.GetDecimal(14).ToString();
                }
            }
            myReader.Close();
            clsGlobal.conn1.Close();
        }

        private void frmAddFood_Load(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                this.Text = "Rediger matvare";
                getFood(FoodId);
            }
        }
    }
}
