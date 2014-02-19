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
    public partial class frmSetup : Form
    {
        private DateTime lastMeasurementDate;
        private SqlDataAdapter daMealTypes;
        private DataTable tblMealTypes;
        private bool hasNutritionGoals;

        public frmSetup()
        {
            InitializeComponent();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            getMeasurements();
            getGoals();
            getWeightList();
            getMealTypes();
            getNutritionGoals();
        }

        private void getWeightList()
        {
            string sqlQuery = "SELECT * FROM tblMeasurement WHERE idUser = @idUser ORDER BY Date DESC";
            SqlDataAdapter a = new SqlDataAdapter(sqlQuery, clsGlobal.conn1);
            a.SelectCommand.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            DataTable tblWeight = new DataTable();
            a.Fill(tblWeight);
            WeightChart.DataSource = tblWeight;
            WeightChart.Series["Series1"].XValueMember = "Date";
            WeightChart.Series["Series1"].YValueMembers = "Weight";
            WeightChart.DataBind();
        }

        private void getMeasurements()
        {
            string sqlQuery = "SELECT TOP 1 * FROM tblMeasurement WHERE idUser = @idUser ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtHeight.Text = reader.GetDecimal(3).ToString("0");
                txtWeight.Text = reader.GetDecimal(2).ToString("0.0");
                if (!reader.IsDBNull(4))
                    txtNeck.Text = reader.GetDecimal(4).ToString("0.0");
                if (!reader.IsDBNull(5))
                    txtShoulders.Text = reader.GetDecimal(5).ToString("0.0");
                if (!reader.IsDBNull(6))
                    txtChest.Text = reader.GetDecimal(6).ToString("0.0");
                if (!reader.IsDBNull(7))
                    txtWaist.Text = reader.GetDecimal(7).ToString("0.0");
                if (!reader.IsDBNull(8))
                    txtHips.Text = reader.GetDecimal(8).ToString("0.0");
                if (!reader.IsDBNull(9))
                    txtThigh.Text = reader.GetDecimal(9).ToString("0.0");
                if (!reader.IsDBNull(10))
                    txtCalf.Text = reader.GetDecimal(10).ToString("0.0");
                if (!reader.IsDBNull(11))
                    txtArm.Text = reader.GetDecimal(11).ToString("0.0");
                if (!reader.IsDBNull(12))
                    txtForeArm.Text = reader.GetDecimal(12).ToString("0.0");
                if (!reader.IsDBNull(13))
                {
                    lastMeasurementDate = reader.GetDateTime(13);
                    lblMeasureDate.Text = lastMeasurementDate.ToString("dd.MM.yyyy");
                }
            }
            clsGlobal.conn1.Close();
        }

        private void getGoals()
        {
            string sqlQuery = "SELECT TOP 1 * FROM tblBodyGoals WHERE idUser = @idUser ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
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
            clsGlobal.conn1.Close();
        }

        private void getNutritionGoals()
        {
            string sqlQuery = "SELECT * FROM tblNutritionGoals WHERE idUser = @idUser";
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
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
            clsGlobal.conn1.Close();
        }

        private void saveMeasurements()
        {
            string sqlQuery;
            string sqlInsert = "INSERT INTO tblMeasurement (idUser, Height, Weight, Neck, Shoulders, Chest, Waist, Hips, Thighs, Calves, Arms, ForeArms, Date) " +
                                                   "VALUES (@idUser, @Height, @Weight, @Neck, @Shoulders, @Chest, @Waist, @Hips, @Thighs, @Calves, @Arms, @ForeArms, @Date)";
            string sqlUpdate = "UPDATE tblMeasurement SET idUser = @idUser, " +
                                                         "Height = @Height, " +
                                                         "Weight = @Weight, " +
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
            if (lastMeasurementDate.Date == DateTime.Now.Date) { sqlQuery = sqlUpdate; }
            else { sqlQuery = sqlInsert; }
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            cmd.Parameters.AddWithValue("@Height", Convert.ToDecimal(txtHeight.Text));
            cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeight.Text));
            cmd.Parameters.AddWithValue("@Neck", Convert.ToDecimal(txtNeck.Text));
            cmd.Parameters.AddWithValue("@Shoulders", Convert.ToDecimal(txtShoulders.Text));
            cmd.Parameters.AddWithValue("@Chest", Convert.ToDecimal(txtChest.Text));
            cmd.Parameters.AddWithValue("@Waist", Convert.ToDecimal(txtWaist.Text));
            cmd.Parameters.AddWithValue("@Hips", Convert.ToDecimal(txtHips.Text));
            cmd.Parameters.AddWithValue("@Thighs", Convert.ToDecimal(txtThigh.Text));
            cmd.Parameters.AddWithValue("@Calves", Convert.ToDecimal(txtCalf.Text));
            cmd.Parameters.AddWithValue("@Arms", Convert.ToDecimal(txtArm.Text));
            cmd.Parameters.AddWithValue("@ForeArms", Convert.ToDecimal(txtForeArm.Text));
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
            cmd.ExecuteNonQuery();
            clsGlobal.conn1.Close();
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
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
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
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
            cmd.ExecuteNonQuery();
            clsGlobal.conn1.Close();
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
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            cmd.Parameters.AddWithValue("@kCals", Convert.ToDecimal(txtEnergyGoal.Text));
            cmd.Parameters.AddWithValue("@Carbs", Convert.ToDecimal(txtCarbsGoal.Text));
            cmd.Parameters.AddWithValue("@Fat", Convert.ToDecimal(txtFatGoal.Text));
            cmd.Parameters.AddWithValue("@Protein", Convert.ToDecimal(txtProteinGoal.Text));
            cmd.Parameters.AddWithValue("@Fiber", Convert.ToDecimal(txtFiberGoal.Text));
            if (clsGlobal.conn1.State != ConnectionState.Open)
                clsGlobal.conn1.Open();
            cmd.ExecuteNonQuery();
            clsGlobal.conn1.Close();
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
            SqlCommand cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.AddWithValue("idUser", clsGlobal.idUser);
            a.SelectCommand = cmd;

            sqlQuery = "INSERT INTO tblMealTypes (Name, SortOrder, idUser) VALUES (@Name, @SortOrder, @idUser)";
            cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Måltid");
            cmd.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "Rekkefølge");
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
            a.InsertCommand = cmd;

            sqlQuery = "UPDATE tblMealTypes SET Name = @Name, SortOrder = @SortOrder WHERE idUser = @idUser AND id = @idMeal";
            cmd = new SqlCommand(sqlQuery, clsGlobal.conn1);
            cmd.Parameters.Add("@idMeal", SqlDbType.Int, 4, "id");
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Måltid");
            cmd.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "Rekkefølge");
            cmd.Parameters.AddWithValue("@idUser", clsGlobal.idUser);
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
            getWeightList();
            getGoals();
        }
    }
}
