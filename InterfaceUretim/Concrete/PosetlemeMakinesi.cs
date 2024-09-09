using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    // default contructer
    internal class PosetlemeMakinesi(List<IPosetlenebilir> posetlenebilirs) : BaseMakine("Posetleme Makinesi", "abc") ,IMakine
    {
        public void Calis()
        {

            foreach (var item in posetlenebilirs)
            {
                item.Posetle();
            }

        }
    }
    


    //private readonly List<IPosetlenebilir> posetlenebilirs;

    //public PosetlemeMakinesi(List<IPosetlenebilir> posetlenebilirs)
    //{
    //    this.posetlenebilirs = posetlenebilirs;
    //}
    

}
