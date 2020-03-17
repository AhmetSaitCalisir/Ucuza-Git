using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UcuzaGit.Entities
{
    public class Kullanici
    {
        public int kullanici_ID { get; set; }
        public string kullanici_Lakap { get; set; }
        public string kullanici_Sifre { get; set; }
        public string kullanici_Adi { get; set; }
        public string kullanici_Soyadi { get; set; }

        public int kullanici_SehirID { get; set; }
        public string kullanici_Resim { get; set; }
    }
}
