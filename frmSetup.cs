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
        private SqlDataAdapter daMealTypes;
        private DataTable tblMealTypes;

        public frmSetup()
        {
            InitializeComponent();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            getMeals();
        }

        private void getMeals()
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
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            cmd.Parameters.Add("@SortOrder", SqlDbType.Int, 4, "SortOrder");
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
        }
    }
}
