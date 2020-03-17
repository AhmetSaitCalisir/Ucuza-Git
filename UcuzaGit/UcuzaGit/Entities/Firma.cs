using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace UcuzaGit.Entities
{
    public class Firma
    {
        public Firma(int ID)
        {
            SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SaS; Integrated Security=True");
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Firma WHERE firma_ID=" + ID.ToString(), bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                firma_ID = sqlDataReader.GetInt32(0);
                firma_Adi = sqlDataReader.GetString(1);
                tur = new Tur(sqlDataReader.GetInt32(2));
                firma_Web = sqlDataReader.GetString(3);
            }
            sqlDataReader.Close();
            bag.Dispose();
            bag.Close();
        }
        public Tur tur { get; set; }
        public int firma_ID { get; set; }
        public string firma_Adi { get; set; }
        public string firma_Web { get; set; }
        public string firma_Logo { get; set; }
    }
}
