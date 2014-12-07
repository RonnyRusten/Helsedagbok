using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;

namespace Helsedagbok
{
    public struct WorkoutHeader
    {
        public int IdWorkout;
        public string Name;
        public DateTime Duration;
        public string Location;
    }

    public struct WorkoutSet
    {
        public int SetId;
        public int ExerciseId;
        public int Reps;
        public decimal Weight;
        public string Notes;
    }

    public class Exercise
    {
        private DataTable _sets = new DataTable();
        private int _totalReps;
        private decimal _totalWeight;
        private DateTime _totalPause;

        public int TotalReps
        {
            get { return _totalReps; }
        }

        public decimal TotalWeight
        {
            get { return _totalWeight; }
        }

        public DateTime TotalPause
        {
            get { return _totalPause; }
        }

        public void AddSet(int setId, int exerciseId, int reps, decimal weight, string notes, TimeSpan pause)
        {
            WorkoutSet set = new WorkoutSet {SetId = setId, ExerciseId = exerciseId, Reps = reps, Weight = weight, Notes = notes};
            //_sets.Add(set);
            _totalReps += reps;
            _totalWeight = TotalWeight + weight * reps;            ;
            _totalPause = TotalPause.Add(pause);
        }
    }


    public class Workout
    {
        public static WorkoutHeader[] GetWorkouts(DateTime date)
        {
            date = date.Date;
            DataTable tbl = new DataTable();
            string sql = "SELECT idWorkout, Name, Duration, Location FROM tblWoWorkouts WHERE Date = @Date";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Global.conn1);
            adapter.SelectCommand.Parameters.AddWithValue("@Date", date);
            adapter.Fill(tbl);
            if (tbl.Rows.Count > 0)
            {
                WorkoutHeader[] header = new WorkoutHeader[tbl.Rows.Count];
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    header[i].IdWorkout = (int) tbl.Rows[i]["idWorkout"];
                    header[i].Name = tbl.Rows[i]["Name"].ToString();
                    header[i].Duration = (DateTime) tbl.Rows[i]["Duration"];
                    header[i].Location = tbl.Rows[i]["Location"].ToString();
                }
                return header;
            }
            else
                return null;
        }

        public static void AddWorkout(string name, string location, DateTime date, DateTime duration)
        {
            date = new DateTime(date.Year, date.Month, date.Day);
            string sql = "INSERT INTO tblWoWorkouts (Date, Name, Duration, Location) " +
                         "VALUES (@date, @name, @duration, @location);";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.CommandText = sql;
            if (Global.conn1.State!=ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        public static void EditWorkout(string name, string location, DateTime date, DateTime duration, int idWorkout)
        {
            date = new DateTime(date.Year, date.Month, date.Day);
            string sql = "UPDATE tblWoWorkouts SET Date = @date, Name = @Name, Duration = @Duration, Location = @Location WHERE idWorkout = @idWorkout;";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@idWorkout", idWorkout);
            cmd.CommandText = sql;
            if (Global.conn1.State!=ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        public static void DeleteWorkout(List<ucExercise> exercises)
        {
            
        }

        public static DataTable GetExersises(int idWorkout)
        {
            string sql = "SELECT tblWoWorkoutExercises.idWorkoutExercise, tblWoExerciseTypes.Name, tblWoWorkoutExercises.idExerciseType,tblWoWorkoutExercises.SortOrder " +
                         "FROM tblWoWorkoutExercises " +
                         "JOIN tblWoExerciseTypes ON tblWoWorkoutExercises.idExerciseType = tblWoExerciseTypes.idExerciseType " +
                         "WHERE idWorkout = " + idWorkout +
                         "ORDER BY tblWoWorkoutExercises.SortOrder;";
            return Functions.GetTable(sql);
        }

        public static void AddExercise(string name, int idBodyPart)
        {
            string sql = "INSERT INTO tblWoExerciseTypes (Name, idBodyPart) VALUES (@name, @idBodyPart)";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@idBodyPart", idBodyPart);
            cmd.CommandText = sql;
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        public static DataTable GetWorkoutSets(int idExercise)
        {
            DataTable tbl = new DataTable();
            string sql = "SELECT tblWoSets.idWorkoutSet, tblWoSets.Reps, tblWoSets.Weight " +
                         "FROM tblWoSets " +
                         "INNER JOIN tblWoWorkoutExercises ON tblWoWorkoutExercises.idWorkoutExercise = tblWoSets.idWorkoutExercise " +
                         "WHERE tblWoSets.idWorkoutExercise = " + idExercise + " " +
                         "ORDER BY idWorkoutSet";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Global.conn1);
            adapter.Fill(tbl);
            return tbl;
        }

        public static void AddSet(int idWorkoutExercise, int idExerciseType, int reps, decimal weight, string notes)
        {
            string sql = "INSERT INTO tblWoSets (idWorkoutExercise, idExerciseType, Reps, Weight, Notes) " +
                         "VALUES(@idWorkoutExercise, @idExerciseType, @reps, @weight, @notes)";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@idWorkoutExercise", idWorkoutExercise);
            cmd.Parameters.AddWithValue("@idExerciseType", idExerciseType);
            cmd.Parameters.AddWithValue("@reps", reps);
            cmd.Parameters.AddWithValue("@weight", weight);
            cmd.Parameters.AddWithValue("@notes", notes);
            cmd.CommandText = sql;
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            Global.conn1.Close();
        }

        public static ucExercise AddWorkoutExercise(int idWorkout, int idExerciseType, string exerciseName, int sortOrder)
        {
            string sql = "INSERT INTO tblWoWorkoutExercises (idWorkout, idExerciseType, SortOrder) VALUES (@idWorkout, @idExerciseType, @SortOrder);";
            SqlCommand cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@idWorkout", idWorkout);
            cmd.Parameters.AddWithValue("@idExerciseType", idExerciseType);
            cmd.Parameters.AddWithValue("@SortOrder", sortOrder);
            cmd.CommandText = sql;
            if (Global.conn1.State != ConnectionState.Open)
                Global.conn1.Open();
            cmd.ExecuteNonQuery();
            //Get the new idWorkoutExercise
            int idWorkoutExercise = 0;
            sql = "SELECT idWorkoutExercise FROM tblWoWorkoutExercises WHERE idWorkout=@idWorkout AND idExerciseType = @idExerciseType AND SortOrder = @SortOrder";
            cmd = Global.conn1.CreateCommand();
            cmd.Parameters.AddWithValue("@idWorkout", idWorkout);
            cmd.Parameters.AddWithValue("@idExerciseType", idExerciseType);
            cmd.Parameters.AddWithValue("@SortOrder", sortOrder);
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idWorkoutExercise = reader.GetInt32(0);
            }
            reader.Close();
            //Add a new set
            if (idWorkoutExercise > 0)
                AddSet(idWorkoutExercise, idExerciseType, 0, 0, "");
            //Get the ucExercise for the new exercise
            ucExercise ex = new ucExercise();
            ex.Title = exerciseName;
            ex.IdExercise = idWorkoutExercise;
            ex.IdExerciseType = idExerciseType;
            ex.SortOrder = sortOrder;
            Global.conn1.Close();

            return ex;
        }
    }
}
