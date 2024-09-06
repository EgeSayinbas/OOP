using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.LokantaOrnegi
{
    internal class BorsaLokantasi
    {
        //public void YemekPisir(Kofte kofte)
        //{

        //}
        //public void YemekPisir(Kofte kofte, Pilav pilav)
        //{

        //}
        //public void YemekPisir(Kofte kofte, Pilav pilav,Kurufasulye kurufasulye)
        //{

        //}  bunun yerine interface ile aşağıdaki gibi

        public void YemekPisir(List<IPisirilebilir> pisirilecekler)
        {
            foreach (var item in pisirilecekler)
            {
                item.Pisir();
            }
        }
    }
}
