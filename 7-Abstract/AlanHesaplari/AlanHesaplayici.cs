using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract.AlanHesaplari
{
    public class AlanHesaplayici
    {
        public readonly List<Sekil> Sekiller;  // readonly sadece constructer icerisinde ya da ilk tanimlandiginda deger atanabilir.
        public AlanHesaplayici(List<Sekil> sekils)  // constructer
        {
            Sekiller = sekils;
        }
        public string AlanHesapla()
        {
            string sonuc = string.Empty;
            foreach (var item in Sekiller)
            {
               
                sonuc += item.GetType().Name + "Alani: " +item.AlanHesapla() + "\n";
            }
            return sonuc;
        }
        public string CevreHesapla()
        {
            string sonuc=string.Empty;
            foreach (var item in Sekiller)
            {
                sonuc+=item.GetType().Name + "Ceversi: " + item.CevreHesapla() + "\n";
            }
            return sonuc;
        }
        public override string ToString()
        {
            string sonuc = "";
            sonuc = AlanHesapla();
            sonuc += CevreHesapla();
            return sonuc;
        }

    }
}
