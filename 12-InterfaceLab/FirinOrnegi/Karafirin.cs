using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.FirinOrnegi
{
    public class Karafirin
    {
        //public void EkmekPisir(Usta usta)
        //{
        //    usta.HamurYogur();
        //}
        //public void EkmekPisir(Makina makina)
        //{
        //    makina.HamurYogur();
        //}  // interface olunca buna gerrek kalmiyo

        public void EkmekPisir(IYogurma yogurucu)
        {
            yogurucu.HamurYogur();
        }
    }
}
