using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassOrnekler
{
    public class Kitap
    {
        //prop adi class adi ile ayni olamaz
        public string KitapAdi { get; set; }
        public  string Yazar { get; set; }

        public  string Cevirmen { get; set; }
        public string Yayinevi { get; set; }
        public DateOnly BaskiYili { get; set; }
        public string Barkod { get; set; }
        public short SayfaSayisi { get; set; }



    }
}
