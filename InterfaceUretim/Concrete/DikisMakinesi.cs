using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    internal class DikisMakinesi(List<IDikilebilir> dikilebilirUrunler) : BaseMakine("Posetleme Makinesi", "abc"), IMakine
    {
        //public string Marka { get; set; }
        //public string Model { get; set; }
        //public DikisMakinesi(List<IDikilebilir> dikilebilirUrunler)
        //{

        //}
        public void Calis()
        {
            
                foreach (var item in dikilebilirUrunler)
                {
                item.Dik();
                }
            
        }
    }
}
