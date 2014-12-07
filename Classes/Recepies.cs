using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsedagbok.Classes
{
    class Recepies
    {
        public static RecepieProperties GetRecepieProperties(int idRecepie)
        {
            RecepieProperties props = new RecepieProperties();
            props.Categories = new List<string>();
            string sql = "SELECT tblRecepieCategories.CategoryName " +
                         "FROM tblRecepies " +
                         "JOIN tblRecepie_categories ON tblRecepie_categories.id_recepie = tblRecepies.idRecepie " +
                         "JOIN tblRecepieCategories ON tblRecepieCategories.idCategory = tblRecepie_categories.id_Category " +
                         "WHERE tblRecepies.idRecepie = @idRecepie";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idRecepie", idRecepie);
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    props.Categories.Add(reader.GetString(0));
                }
            }
            reader.Close();
            sql = "SELECT tblRecepies.Time " +
                                ", tblRecepies.Porsjoner " +
                                ", tblRecepieDifficulties.Difficulty " +
                                ", tblRecepieDifficulties.idDifficulty " +
                                "FROM tblRecepies " +
                                "JOIN tblRecepieDifficulties ON tblRecepieDifficulties.idDifficulty = tblRecepies.idDifficulty " +
                                "WHERE tblRecepies.idRecepie = @idRecepie";
            cmd = Global.conn1.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@idRecepie", idRecepie);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                props.Time = (reader.IsDBNull(0)) ? "-" : reader.GetString(0);
                props.Servings = (reader.IsDBNull(1)) ? 1 : reader.GetInt32(1);
                props.Difficulty = (reader.IsDBNull(2)) ? "-" : reader.GetString(2);
                props.IdDifficulty = (reader.IsDBNull(3)) ? 0 : reader.GetInt32(3);
            }
            reader.Close();
            Global.conn1.Close();
            return props;
        }

        public static int NewRecepie(string name, string time, int servings, int idDifficulty, List<int> idCategory)
        {
            int idRecepie = 0;
            string sql = "INSERT INTO tblRecepies (Name, Time, Porsjoner, idDifficulty) VALUES(@Name, @Time, @Porsjoner, @idDifficulty)";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Time", time);
            cmd.Parameters.AddWithValue("@Porsjoner", servings);
            cmd.Parameters.AddWithValue("@idDifficulty", idDifficulty);
            if (Global.conn1.State!=ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();

            sql = "SELECT idRecepie FROM tblRecepies WHERE Name=@Name";
            cmd = Global.conn1.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Name", name);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idRecepie = reader.GetInt32(0);
            }
            reader.Close();

            sql = "INSERT INTO tblRecepie_Categories (id_recepie, id_category) VALUES(@idRecepie, @idCategory)";
            foreach (int idCat in idCategory)
            {
                cmd = Global.conn1.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@idRecepie", idRecepie);
                cmd.Parameters.AddWithValue("@idCategory", idCat);
                cmd.ExecuteNonQuery();
            }

            Global.conn1.Close();

            return idRecepie;
        }

        
    }

    public struct RecepieProperties
    {
        public List<string> Categories;
        public string Time;
        public int Servings;
        public string Difficulty;
        public int IdDifficulty;
    }
}
