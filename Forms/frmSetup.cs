using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Helsedagbok
{
    public partial class frmSetup : Form
    {
        private DateTime lastMeasurementDate;
        private SqlDataAdapter daMealTypes;
        private DataTable tblMealTypes;
        private bool hasNutritionGoals;
        private Point? prevPosition = null;
        private ToolTip ttWeightChart = new ToolTip();

        public frmSetup()
        {
            InitializeComponent();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            getMeasurements();
            getLastMeasure();
            getGoals();
            getWeightList();
            getMealTypes();
            getNutritionGoals();
        }

        private void getWeightList()
        {
            string sqlQuery = "SELECT * FROM tblMeasurement WHERE idUser = @idUser ORDER BY Date DESC";
            SqlDataAdapter a = new SqlDataAdapter(sqlQuery, Global.conn1);
            a.SelectCommand.Parameters.AddWithValue("@idUser", Global.idUser);
            DataTable tblWeight = new DataTable();
            a.Fill(tblWeight);
            WeightChart.DataSource = tblWeight;
            WeightChart.Series["Weight"].XValueMember = "Date";
            WeightChart.Series["Weight"].YValueMembers = "Weight";
            WeightChart.Series["Weight2"].XValueMember = "Date";
            WeightChart.Series["Weight2"].YValueMembers = "Weight2";
            WeightChart.DataBind();
        }

        private void getLastMeasure()
        {
            string sqlQuery = "SELECT TOP 1 Height, Date FROM tblMeasurement WHERE idUser = @idUser ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                    txtHeight.Text = reader.GetDecimal(0).ToString("0");
                if (!reader.IsDBNull(1))
                {
                    lastMeasurementDate = reader.GetDateTime(1);
                    lblMeasureDate.Text = lastMeasurementDate.ToString("dd.MM.yyyy");
                }
            }
            reader.Close();
            Global.conn1.Close();
        }

        private void getMeasurements()
        {
            string sqlQuery = "SELECT TOP 1 * FROM tblMeasurement WHERE idUser = @idUser AND Date = @Date ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtWeight.Text = (reader.IsDBNull(3)) ? "" : reader.GetDecimal(3).ToString("0.0");
                txtWeight2.Text = (reader.IsDBNull(4)) ? "" : reader.GetDecimal(4).ToString("0.0");
                txtNeck.Text = (reader.IsDBNull(5)) ? "" : reader.GetDecimal(5).ToString("0.0");
                txtShoulders.Text = (reader.IsDBNull(6)) ? "" : reader.GetDecimal(6).ToString("0.0");
                txtChest.Text = (reader.IsDBNull(7)) ? "" : reader.GetDecimal(7).ToString("0.0");
                txtWaist.Text = (reader.IsDBNull(8)) ? "" : reader.GetDecimal(8).ToString("0.0");
                txtHips.Text = (reader.IsDBNull(9)) ? "" : reader.GetDecimal(9).ToString("0.0");
                txtThigh.Text = (reader.IsDBNull(10)) ? "" : reader.GetDecimal(10).ToString("0.0");
                txtCalf.Text = (reader.IsDBNull(11)) ? "" : reader.GetDecimal(11).ToString("0.0");
                txtArm.Text = (reader.IsDBNull(12)) ? "" : reader.GetDecimal(12).ToString("0.0");
                txtForeArm.Text = (reader.IsDBNull(13)) ? "" : reader.GetDecimal(13).ToString("0.0");
            }
            else
            {
                txtWeight.Text = "";
                txtWeight2.Text = "";
                txtNeck.Text = "";
                txtShoulders.Text = "";
                txtChest.Text = "";
                txtWaist.Text = "";
                txtHips.Text = "";
                txtThigh.Text = "";
                txtCalf.Text = "";
                txtArm.Text = "";
                txtForeArm.Text = "";
            }
            reader.Close();
            Global.conn1.Close();
        }

        private void getGoals()
        {
            string sqlQuery = "SELECT TOP 1 * FROM tblBodyGoals WHERE idUser = @idUser ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                //txtHeight.Text = reader.GetDecimal(3).ToString("0");
                txtWeightGoal.Text = reader.GetDecimal(2).ToString("0.0");
                if (!reader.IsDBNull(3))
                    txtNeckGoal.Text = reader.GetDecimal(3).ToString("0.0");
                if (!reader.IsDBNull(4))
                    txtShouldersGoal.Text = reader.GetDecimal(4).ToString("0.0");
                if (!reader.IsDBNull(5))
                    txtChestGoal.Text = reader.GetDecimal(5).ToString("0.0");
                if (!reader.IsDBNull(6))
                    txtWaistGoal.Text = reader.GetDecimal(6).ToString("0.0");
                if (!reader.IsDBNull(7))
                    txtHipsGoal.Text = reader.GetDecimal(7).ToString("0.0");
                if (!reader.IsDBNull(8))
                    txtThighGoal.Text = reader.GetDecimal(8).ToString("0.0");
                if (!reader.IsDBNull(9))
                    txtCalfGoal.Text = reader.GetDecimal(9).ToString("0.0");
                if (!reader.IsDBNull(10))
                    txtArmGoal.Text = reader.GetDecimal(10).ToString("0.0");
                if (!reader.IsDBNull(11))
                    txtForeArmGoal.Text = reader.GetDecimal(11).ToString("0.0");
            }
            Global.conn1.Close();
        }

        private void getNutritionGoals()
        {
            string sqlQuery = "SELECT * FROM tblNutritionGoals WHERE idUser = @idUser";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                hasNutritionGoals = true;
                reader.Read();
                if (!reader.IsDBNull(2))
                    txtEnergyGoal.Text = reader.GetDecimal(2).ToString("0");
                if (!reader.IsDBNull(3))
                    txtCarbsGoal.Text = reader.GetDecimal(3).ToString("0.0");
                if (!reader.IsDBNull(4))
                    txtFatGoal.Text = reader.GetDecimal(4).ToString("0.0");
                if (!reader.IsDBNull(5))
                    txtProteinGoal.Text = reader.GetDecimal(5).ToString("0.0");
                if (!reader.IsDBNull(6))
                    txtFiberGoal.Text = reader.GetDecimal(6).ToString("0.0");
            }
            Global.conn1.Close();
        }

        private void saveMeasurements()
        {
            string sqlQuery;
            string sqlSelect = "Select idUser FROM tblMeasurement WHERE idUser = @idUser AND Date = @Date";
            string sqlInsert = "INSERT INTO tblMeasurement (idUser, Height, Weight, Weight2, Neck, Shoulders, Chest, Waist, Hips, Thighs, Calves, Arms, ForeArms, Date) " +
                                                   "VALUES (@idUser, @Height, @Weight, @Weight2, @Neck, @Shoulders, @Chest, @Waist, @Hips, @Thighs, @Calves, @Arms, @ForeArms, @Date)";
            string sqlUpdate = "UPDATE tblMeasurement SET idUser = @idUser, " +
                                                         "Height = @Height, " +
                                                         "Weight = @Weight, " +
                                                         "Weight2 = @Weight2, " +
                                                         "Neck = @Neck, " +
                                                         "Shoulders = @Shoulders, " +
                                                         "Chest = @Chest, " +
                                                         "Waist = @Waist, " +
                                                         "Hips = @Hips, " +
                                                         "Thighs = @Thighs, " +
                                                         "Calves = @Calves, " +
                                                         "Arms = @Arms, " +
                                                         "ForeArms = @ForeArms " +
                                                         "WHERE idUser = @idUser AND Date = @Date";
            SqlCommand cmd = new SqlCommand(sqlSelect, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
                { sqlQuery = sqlUpdate; }
            else 
                { sqlQuery = sqlInsert; }
            reader.Close();
            cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            cmd.Parameters.AddWithValue("@Height", (txtHeight.Text.Length > 0) ? Convert.ToDecimal(txtHeight.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Weight", (txtWeight.Text.Length > 0) ? Convert.ToDecimal(txtWeight.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Weight2", (txtWeight2.Text.Length>0) ? Convert.ToDecimal(txtWeight2.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Neck", (txtNeck.Text.Length > 0) ? Convert.ToDecimal(txtNeck.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Shoulders", (txtShoulders.Text.Length > 0) ? Convert.ToDecimal(txtShoulders.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Chest", (txtChest.Text.Length > 0) ? Convert.ToDecimal(txtChest.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Waist", (txtWaist.Text.Length > 0) ? Convert.ToDecimal(txtWaist.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Hips", (txtHips.Text.Length > 0) ? Convert.ToDecimal(txtHips.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Thighs", (txtThigh.Text.Length > 0) ? Convert.ToDecimal(txtThigh.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Calves", (txtCalf.Text.Length > 0) ? Convert.ToDecimal(txtCalf.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Arms", (txtArm.Text.Length > 0) ? Convert.ToDecimal(txtArm.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@ForeArms", (txtForeArm.Text.Length > 0) ? Convert.ToDecimal(txtForeArm.Text) : Convert.DBNull);
            cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        private void saveGoals()
        {
            string sqlQuery;
            string sqlInsert = "INSERT INTO tblBodyGoals (idUser, Weight, Neck, Shoulders, Chest, Waist, Hips, Thighs, Calves, Arms, ForeArms, Date) " +
                                                   "VALUES (@idUser, @Weight, @Neck, @Shoulders, @Chest, @Waist, @Hips, @Thighs, @Calves, @Arms, @ForeArms, @Date)";
            string sqlUpdate = "UPDATE tblBodyGoals SET idUser = @idUser, " +
                                                         "Weight = @Weight, " +
                                                         "Neck = @Neck, " +
                                                         "Shoulders = @Shoulders, " +
                                                         "Chest = @Chest, " +
                                                         "Waist = @Waist, " +
                                                         "Hips = @Hips, " +
                                                         "Thighs = @Thighs, " +
                                                         "Calves = @Calves, " +
                                                         "Arms = @Arms, " +
                                                         "ForeArms = @ForeArms, " +
                                                         "Date = @Date " +
                                                         "WHERE idUser = @idUser";
            if (lastMeasurementDate.Date == DateTime.Now.Date) { sqlQuery = sqlUpdate; }
            else { sqlQuery = sqlInsert; }
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeightGoal.Text));
            cmd.Parameters.AddWithValue("@Neck", Convert.ToDecimal(txtNeckGoal.Text));
            cmd.Parameters.AddWithValue("@Shoulders", Convert.ToDecimal(txtShouldersGoal.Text));
            cmd.Parameters.AddWithValue("@Chest", Convert.ToDecimal(txtChestGoal.Text));
            cmd.Parameters.AddWithValue("@Waist", Convert.ToDecimal(txtWaistGoal.Text));
            cmd.Parameters.AddWithValue("@Hips", Convert.ToDecimal(txtHipsGoal.Text));
            cmd.Parameters.AddWithValue("@Thighs", Convert.ToDecimal(txtThighGoal.Text));
            cmd.Parameters.AddWithValue("@Calves", Convert.ToDecimal(txtCalfGoal.Text));
            cmd.Parameters.AddWithValue("@Arms", Convert.ToDecimal(txtArmGoal.Text));
            cmd.Parameters.AddWithValue("@ForeArms", Convert.ToDecimal(txtForeArmGoal.Text));
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        private void saveNutritionGoals()
        {
            string sqlQuery;
            string sqlInsert = "INSERT INTO tblNutritionGoals (idUser, kCals, Carbs, Fat, Protein, Fiber) " +
                                                   "VALUES (@idUser, @kCals, @Carbs, @Fat, @Protein, @Fiber)";
            string sqlUpdate = "UPDATE tblNutritionGoals SET idUser = @idUser, " +
                                                         "kCals = @kCals, " +
                                                         "Carbs = @Carbs, " +
                                                         "Fat = @Fat, " +
                                                         "Protein = @Protein, " +
                                                         "Fiber = @Fiber " +
                                                         "WHERE idUser = @idUser";
            if (hasNutritionGoals) { sqlQuery = sqlUpdate; }
            else { sqlQuery = sqlInsert; }
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            cmd.Parameters.AddWithValue("@kCals", Convert.ToDecimal(txtEnergyGoal.Text));
            cmd.Parameters.AddWithValue("@Carbs", Convert.ToDecimal(txtCarbsGoal.Text));
            cmd.Parameters.AddWithValue("@Fat", Convert.ToDecimal(txtFatGoal.Text));
            cmd.Parameters.AddWithValue("@Protein", Convert.ToDecimal(txtProteinGoal.Text));
            cmd.Parameters.AddWithValue("@Fiber", Convert.ToDecimal(txtFiberGoal.Text));
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        private void getMealTypes()
        {
            daMealTypes = createMealTypesAdapter();
            tblMealTypes=new DataTable();
            daMealTypes.Fill(tblMealTypes);

            dgvMealNames.DataSource = tblMealTypes;
            dgvMealNames.Columns[0].Visible = false;
            dgvMealNames.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private SqlDataAdapter createMealTypesAdapter()
        {
            SqlDataAdapter a = new SqlDataAdapter();
            string sqlQuery = "SELECT id, Name AS Måltid, SortOrder AS Rekkefølge FROM tblMealTypes WHERE idUser = @idUser ORDER BY SortOrder";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("idUser", Global.idUser);
            a.SelectCommand = cmd;

            sqlQuery = "INSERT INTO tblMealTypes (Name, SortOrder, idUser) VALUES (@Name, @SortOrder, @idUser)";
            cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Måltid");
            cmd.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "Rekkefølge");
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            a.InsertCommand = cmd;

            sqlQuery = "UPDATE tblMealTypes SET Name = @Name, SortOrder = @SortOrder WHERE idUser = @idUser AND id = @idMeal";
            cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.Add("@idMeal", SqlDbType.Int, 4, "id");
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Måltid");
            cmd.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "Rekkefølge");
            cmd.Parameters.AddWithValue("@idUser", Global.idUser);
            a.UpdateCommand = cmd;

            return a;
        }

        private void btnSaveMealTypes_Click(object sender, EventArgs e)
        {
            daMealTypes.Update(tblMealTypes);
            saveNutritionGoals();
            getNutritionGoals();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveMeasurements();
            saveGoals();
            getMeasurements();
            getLastMeasure();
            getWeightList();
            getGoals();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            getMeasurements();
        }
    }
}
