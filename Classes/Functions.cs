﻿using System;
using System.Collections.Generic;
using System.Data;
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
            string dbServer = "rru-w8";
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

        public static DataTable GetTable(string sql)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Global.conn1);
            adapter.Fill(tbl);
            return tbl;
        }

        public static bool RunSql(string sql)
        {
            ConnectionState tempState = Global.conn1.State;
            try
            {
                SqlCommand cmd = Global.conn1.CreateCommand();
                cmd.CommandText = sql;
                if (Global.conn1.State != ConnectionState.Open)
                    Global.conn1.Open();
                cmd.ExecuteNonQuery();
                if (tempState == ConnectionState.Closed)
                    Global.conn1.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool RunSqlCommand(SqlCommand cmd)
        {
            ConnectionState tempState = Global.conn1.State;
            try
            {
                if (Global.conn1.State != ConnectionState.Open)
                    Global.conn1.Open();
                cmd.ExecuteNonQuery();
                if (tempState == ConnectionState.Closed)
                    Global.conn1.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
