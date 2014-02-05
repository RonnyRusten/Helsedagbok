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
            Boolean Connected = clsFunctions.dbConnect();
            if (Connected)
                getUsers();
        }

        private void getUsers()
        {
            string sqlQuery = "SELECT idUser, FirstName + ' ' + LastName AS Name FROM tblUsers";
            SqlDataAdapter a = new SqlDataAdapter(sqlQuery, clsGlobal.conn1);
            tblUsers = new DataTable();
            a.Fill(tblUsers);
            cmbUsers.DataSource = tblUsers;
            cmbUsers.DisplayMember = "Name";
            cmbUsers.ValueMember = "idUser";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            clsGlobal.idUser = (int)cmbUsers.SelectedValue;
            this.Close();
        }
    }
}
