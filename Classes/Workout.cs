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
            string sql = "SELECT idWorkout, Name, Duration, Location FROM tblWoWorkouts WHERE Dato = @Date";
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

        public static DataTable GetExersises(int idWorkout)
        {
            string sql = "SELECT tblWoWorkoutExercises.idWorkoutExercise, tblWoExerciseTypes.Name " +
                         "FROM tblWoWorkoutExercises " +
                         "JOIN tblWoExerciseTypes ON tblWoWorkoutExercises.idExerciseType=tblWoExerciseTypes.idWorkoutExercise " +
                         "WHERE idWorkout=" + idWorkout + ";";
            return Functions.GetTable(sql);
        }

        public static DataTable GetWorkoutSets(int idExercise)
        {
            DataTable tbl = new DataTable();
            string sql = "SELECT tblWoSets.idWorkoutSet, tblWoSets.Reps, tblWoSets.Weight " +
                         "FROM tblWoExerciseSets " +
                         "INNER JOIN tblWoSets ON tblWoExerciseSets.idSet = tblWoSets.idWorkoutSet " +
                         "INNER JOIN tblWoWorkoutExercises ON tblWoExerciseSets.idExercise = tblWoWorkoutExercises.idWorkoutExercise " +
                         "WHERE tblWoSets.idWorkoutExercise = " + idExercise + " " +
                         "ORDER BY idWorkoutSet";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Global.conn1);
            adapter.Fill(tbl);
            return tbl;
        }
    }
}
