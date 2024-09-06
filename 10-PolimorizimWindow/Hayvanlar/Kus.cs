using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorizimWindow.Hayvanlar
{
    internal class Kus : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Cik cik");
        }
        public override void HareketEt()
        {
            Console.WriteLine("kus uctu");
        }
    }
}
