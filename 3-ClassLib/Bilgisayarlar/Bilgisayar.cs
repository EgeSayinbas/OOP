using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public class Bilgisayar
    {
        public Anakart Anakart { get; set; }
        public Cpu Cpu { get; set; }
        public List<Ram> Ramler { get; set; }
        public List<EkranKarti> EkranKartlari { get; set; }
        
        public List<SSD> Diskler { get; set; }

        //constructor metod * geri donus tipi yoktur * parametre alabilir * kurucu/yapıcı metod ta denir.
        //eger propertylere ilk deger atamasi yapilmis ise once propertylere deger atanir sonra constructor calistirilir.
        //Constructor lar class ismi ile ayni olmak zorundadir
        public Bilgisayar()
        {
            Cpu = new Cpu("AMD");
            Ramler = new List<Ram>();
            EkranKartlari= new List<EkranKarti>();
            Diskler = new List<SSD>();
            Anakart= new Anakart();
        }

    }
}
