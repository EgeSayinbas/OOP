using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorizimWindow.Hayvanlar
{
    internal class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyav miyav");
        }
        public override void HareketEt()
        {
            Console.WriteLine(" kedi kostu");
        }
    }
}
