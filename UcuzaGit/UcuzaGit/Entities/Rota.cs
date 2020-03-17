using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace UcuzaGit.Entities
{
    public class Rota
    {
        public Rota(int ID)
        {
            SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SaS; Integrated Security=True");
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Rota WHERE Rota_ID=" + ID.ToString(), bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                rota_ID = sqlDataReader.GetInt32(0);
                rota_BaslangicID = sqlDataReader.GetInt32(1);
                rota_VarisID = sqlDataReader.GetInt32(2);
                firma = new Firma(sqlDataReader.GetInt32(3));
                rota_Ucret = sqlDataReader.GetInt32(4);
                rota_Tarih = sqlDataReader.GetDateTime(5);
                rota_Saat = sqlDataReader.GetString(6);
                rota_Seyahat = sqlDataReader.GetInt32(7);
                tur = new Tur(sqlDataReader.GetInt32(8));
                sehir_baslangic = new Sehir(rota_BaslangicID);
                sehir_varis = new Sehir(rota_VarisID);
            }
            sqlDataReader.Close();
            bag.Dispose();
            bag.Close();
        }
        public Sehir sehir_baslangic { get; set; }
        public Sehir sehir_varis { get; set; }
        public Tur tur { get; set; }
        public Firma firma { get; set; }
        public int rota_ID { get; set; }
        public int rota_BaslangicID { get; set; }
        public int rota_VarisID { get; set; }
        public int rota_Ucret { get; set; }
        public DateTime rota_Tarih { get; set; }
        public String rota_Saat { get; set; }

        public int rota_Seyahat { get; set; }
    }
}
