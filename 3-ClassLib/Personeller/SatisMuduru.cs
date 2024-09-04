using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class SatisMuduru : SatisElemani 
    {
          //prim property si instance alindiginda gorunmeyecek
        public SatisMuduru()
        {
            Maas = base.Maas + PrimHesapla();
            //base.Prim=100;
        }

        public List<SatisElemani> BagliElemanlar { get; set; }
        public void SatisToplantisiYap()
        {

        }

        public void BayiToplantilariYap()
        {

        }
        
        private double PrimHesapla()
        {
            double primToplami = 0;
            foreach(var item in BagliElemanlar)
            {
                primToplami += item.Prim*0.1;
            }

            return Maas += primToplami;
        }
    }
}
