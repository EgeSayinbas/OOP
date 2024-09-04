using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class SatisElemani : Personel
    {
        public SatisElemani()
        {
            Maas=base.Maas*1.5;
        }
    }
}
