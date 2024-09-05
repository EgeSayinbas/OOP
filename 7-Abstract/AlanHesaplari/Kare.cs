using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract.AlanHesaplari
{
    internal class Kare : Sekil
    {
        public override double AlanHesapla()
        {
            return KısaKenar * UzunKenar;
        }

        public override double CevreHesapla()
        {
            return (KısaKenar + UzunKenar) * 2;
        }
    }
}
