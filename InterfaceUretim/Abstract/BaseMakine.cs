using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Abstract
{
    internal class BaseMakine
    {
        //public string Marka { get; set; }
        //public string Model { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public BaseMakine(string marka,string model)
        {
            this.Marka = marka;
            this.Model = model; 
        }
    }
}
