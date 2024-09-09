using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari.Concrete
{
    public class IK
    {
        public List<object> GenelBasvurular {  get; set; } = new List<object>();
        //public List<ITBasvuru> ITBasvurulari { get; set; }
        public HashSet<ITBasvuru> ITBasvurulari { get; set; } = new();  //listten farki aynı objeyi 2 kere atamazsın //ayni objeden 2 kere kayit atilamaz
        public HashSet<FinansBasvuru> FinansBasvurulari { get; set; } = new();
        public void FinansBasvurusuAL(FinansBasvuru basvuru)
        {
            FinansBasvurulari.Add(basvuru);
        }
        public void ITBasvursuAl(ITBasvuru basvuru)
        {
            ITBasvurulari.Add(basvuru);
        }
        public HashSet<ITBasvuru> ITBasvurulariniVer()

        {
            return ITBasvurulari;
        }

        public void GenelBasvuruAl(object basvuru)
        {
            GenelBasvurular.Add(basvuru);
        }

        public void GenelBasvuruListele()
        {
            foreach (var item in GenelBasvurular)
            {
                if (item is ITBasvuru)
                {
                    ITBasvuru basvuru1 = (ITBasvuru)item;
                    Console.WriteLine(basvuru1);
                }
                else if (item is FinansBasvuru)
                {
                    var basvuru = item as FinansBasvuru;
                    Console.WriteLine(basvuru);
                }
            }
        }
    }
}
