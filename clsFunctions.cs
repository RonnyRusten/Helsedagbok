using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Helsedagbok
{
    public class clsFunctions
    {
        public static Boolean dbConnect()
        {
            string dbServer = "rruw8\\sqlexpress";
            clsGlobal.str_Connetion = "Server=" + dbServer + "; Database=Recepies; User Id=sa; Password=Doelle01;";
            clsGlobal.conn1 = new SqlConnection(clsGlobal.str_Connetion);
            try
            {
                clsGlobal.conn1.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection failed!" + ex.Message);
                return false;
            }
        }

        public static Boolean IsNumeric (System.Object Expression)
        {
            if(Expression == null || Expression is DateTime)
                return false;

            if(Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            try 
            {
                if(Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                    return true;
            } 
            catch {} // just dismiss errors but return false
                return false;
        }
    }
}
