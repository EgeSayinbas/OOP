using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    public class Muzisyen
    {
        //public  Gitar Gitar { get; set; }
        //public  Flut Flut { get; set; }
        //public Piyano Piyano { get; set; }

        public  string AdSoyad { get; set; }
        /*
         * Caldigi aletleri tek tek prop olarak ifade etmek ilerleyen durumda yeni bir muzik aleti caldiginda kodda  degisiklige neden olacaktır
         * Bu istenilen bir durum degildir.(SOLID=> O  open close)
         * 
         * Bu nedenle butun muzik aletlerinin base class i olan MuzikAletleri sinifini tutan bir liste de ifade etmek dogru yoldur
         */
        public List<MuzikAleti> caldigiAletler { get; set; }

        public Muzisyen(List<MuzikAleti> muzikAletis)
        {
            caldigiAletler=muzikAletis;

        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in caldigiAletler)
            {
                str += $"{item.Marka}  {item.Model} ";
            }
            return str + "caliyor \n";
            
        }


    }
    
}
