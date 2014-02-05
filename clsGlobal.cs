using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Helsedagbok
{
    public class clsGlobal
    {
        public static string str_ProductName = "Helsedagbok 2014";
        public static string str_Company = "RuSoft";
        public static string str_Connetion;
        public static SqlConnection conn1;
        public static int idUser;

        public struct Food
        {
            public int idDiary;
            public int idFood;
            public string DisplayName;
            public decimal Count;
            public int idUnit;
            public decimal Energy;
            public string Name;
            public string Unit;
            public decimal unitWeight;
            public decimal Carbs;
            public decimal Sugar;
            public decimal Fat;
            public decimal FatSat;
            public decimal FatMono;
            public decimal FatPoly;
            public decimal FatTrans;
            public decimal Protein;
            public decimal Alcohol;
        }
    }
}
