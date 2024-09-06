using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface.Personeller
{
    public class ITYazilim:Personel,IBilisimPersoneli,IYazilimci
    {
        public ITYazilim(string ad, string soyad) : base(ad, soyad)
        {
            Maas = base.Maas * 2.5;
        }
    }
}
