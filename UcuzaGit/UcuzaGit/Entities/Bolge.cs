using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace UcuzaGit.Entities
{
    public class Bolge
    {
        public int bolge_ID { get; set; }
        public string bolge_Adi { get; set; }

        public Bolge(int ID)
        {
            SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SaS; Integrated Security=True");
            bag.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM Bolge WHERE Bolge_ID=" + ID.ToString(),bag);
            SqlDataReader sqldataReader = sqlcommand.ExecuteReader();
            while (sqldataReader.Read())
            {
                bolge_ID = sqldataReader.GetInt32(0);
                bolge_Adi = sqldataReader.GetString(1);
            }
            sqldataReader.Close();
            bag.Dispose();
            bag.Close();

        }
    }
}
