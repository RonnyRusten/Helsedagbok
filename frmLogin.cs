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
    public partial class frmLogin : Form
    {
        private DataTable tblUsers;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Boolean Connected = Functions.dbConnect();
            if (Connected)
                getUsers();
        }

        private void getUsers()
        {
            string sqlQuery = "SELECT idUser, FirstName + ' ' + LastName AS Name FROM tblUsers";
            SqlDataAdapter a = new SqlDataAdapter(sqlQuery, Global.conn1);
            tblUsers = new DataTable();
            a.Fill(tblUsers);
            cmbUsers.DataSource = tblUsers;
            cmbUsers.DisplayMember = "Name";
            cmbUsers.ValueMember = "idUser";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedValue == null)
                AddUser();
            else
            {
                Global.idUser = (int)cmbUsers.SelectedValue;
                this.Close();
            }
        }

        private void AddUser()
        {
            string fName;
            string lName;
            string sqlQuery;
            int pos;
            int idUser;

            pos = cmbUsers.Text.LastIndexOf(" ");
            fName = cmbUsers.Text.Substring(0, pos);
            lName = cmbUsers.Text.Substring(pos + 1);
            sqlQuery = "INSERT INTO tblUsers (FirstName, LastName) VALUES (@fName, @lName); SELECT CAST(idUser AS int) FROM tblUsers";
            SqlCommand cmd = new SqlCommand(sqlQuery, Global.conn1);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            if (Global.conn1.State != ConnectionState.Open)
            {
                Global.conn1.Open();
            }
            cmd.ExecuteNonQuery();

            sqlQuery = "SELECT idUser FROM tblUsers WHERE FirstName = @fname AND LastName = @lName";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            idUser = reader.GetInt32(0);
            Global.conn1.Close();
            Global.idUser = idUser;
            this.Close();
        }
    }
}
