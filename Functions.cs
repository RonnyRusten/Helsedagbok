using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Helsedagbok
{
    public class Functions
    {
        private string ProductName = "Helsedagbok";

        public static Boolean dbConnect()
        {
            string dbServer = "rruw8\\sqlexpress";
            Global.str_Connetion = "Server=" + dbServer + "; Database=Recepies; User Id=sa; Password=Doelle01;";
            Global.conn1 = new SqlConnection(Global.str_Connetion);
            try
            {
                Global.conn1.Open();
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

        public static object getRegistry(string subKeyName, string ValueName)
        {
            RegistryKey mainKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
            RegistryKey ValueKey = mainKey.CreateSubKey("Software\\RuSoft\\Helsedagbok");
            if (subKeyName.Length > 0)
            {
                ValueKey = ValueKey.CreateSubKey(subKeyName);
            }
            object value = ValueKey.GetValue(ValueName, 0);
            return value;
        }

        public static void setRegistryKey(string subKeyName, string ValueName, object Value)
        {
            RegistryKey mainKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
            RegistryKey ValueKey = mainKey.CreateSubKey("Software\\RuSoft\\Helsedagbok");
            if (subKeyName.Length > 0)
            {
                ValueKey = ValueKey.CreateSubKey(subKeyName);
            }
            ValueKey.SetValue(ValueName, Value);
        }

        public static void GetFormPositionSize(Form Form)
        {
            string FormName = Form.Name;
            Form.Top = (int)getRegistry(FormName, "xPos");
            Form.Left = (int)getRegistry(FormName, "yPos");
            Form.Width = (int)getRegistry(FormName, "Width");
            Form.Height = (int)getRegistry(FormName, "Height");
        }

        public static void SetFormPositionSize(Form Form)
        {
            string FormName = Form.Name;
            setRegistryKey(FormName, "xPos", Form.Top);
            setRegistryKey(FormName, "yPos", Form.Left);
            setRegistryKey(FormName, "Width", Form.Width);
            setRegistryKey(FormName, "Height", Form.Height);
        }
    }
}
