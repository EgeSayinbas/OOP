using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class SatisElemani : Personel
    {
        //protected sadece kalitim verdigi yerlerde ulasilabilir
        //Instance alininca erisilemez
        internal double Prim { get; set; }
        public SatisElemani()
        {
            Maas = base.Maas * 1.5+ Prim;
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
