using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{

    /*
     * Abstract Class lar instance alinamaz ama kalitim verebilir
     * Varlik sebebi kalitim vermektir.Yani base class olarak calisirlar.
     */
    public abstract class BaseItem
    {
        public double Fiyat { get; set; } //= 1;
        public string Marka { get; set; }
        public string Model { get; set; }
        protected BaseItem()
        {
            Fiyat = 1;
        }
    }
}
