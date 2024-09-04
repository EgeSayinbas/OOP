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
            Ramler = new List<Ram>() { new Ram { Fiyat = 5 } };
            EkranKartlari= new List<EkranKarti>() { new EkranKarti { Fiyat = 10 } };
            Diskler = new List<SSD>() { new SSD { Fiyat=30} };
            Anakart= new Anakart();
        }
        public double FiyatHesapla()
        {
            double toplamtutar = 0;
            foreach (var item in Ramler)
            {
                toplamtutar +=  item.Fiyat;
            }
            foreach (var item in Diskler)
            {
                toplamtutar +=  item.Fiyat;
            }
            foreach (var item in EkranKartlari)
            {
                toplamtutar +=  item.Fiyat;
            }
            toplamtutar += Anakart.Fiyat;
            toplamtutar += Cpu.Fiyat;

            return toplamtutar;
        }
    }
}
