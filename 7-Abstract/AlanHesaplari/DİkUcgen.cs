using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract.AlanHesaplari
{
    public class DİkUcgen : Sekil
    {
        public override double AlanHesapla()
        {
            return KısaKenar * UzunKenar / 2;
        }

        public override double CevreHesapla()
        {
            return KısaKenar + UzunKenar + Math.Sqrt(Math.Pow(KısaKenar, 2) + Math.Pow(UzunKenar, 2));
        }
    }
}
