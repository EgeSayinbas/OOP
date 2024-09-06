using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorizimWindow.Hayvanlar
{
    public class Hayvan
    {

        public virtual void SesCikar()
        {
            Console.WriteLine("Hirr");
        }
        public virtual void HareketEt()
        {
            Console.WriteLine("hayvan hareket etti");
        }


    }
}
