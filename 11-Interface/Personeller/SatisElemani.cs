using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface.Personeller
{
    public class SatisElemani : Personel
    {
        //protected sadece kalitim verdigi yerlerde ulasilabilir
        //Instance alininca erisilemez
        internal double Prim { get; set; }
        public SatisElemani(string ad, string soyad) : base(ad, soyad)
        {
            Maas = base.Maas * 1.5+ Prim;
        }
        
        //Yikici metod
        public void Deconstruct()
        {

        }

        public void MusterileriAra()
        {

        }

        public void MusterileriZiyaretEt()
        {

        }

        public void SatisYap()
        {

        }

        
    }
}
