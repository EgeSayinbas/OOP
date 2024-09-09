using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    internal class KesimMakinesi(List<IKesilebilir> kesilebilirs,string Marka,string Model):BaseMakine(Marka,Model), IMakine
    {
       public void Calis()
        {
            foreach (var item in kesilebilirs)
            {
                item.Kes();
            }
        }

    }
}
