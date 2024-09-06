using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    public class Piyano : MuzikAleti
    {
        public override string Model { get; set; }
        public override string Marka { get; set; }
        public override string Cal()
        {
            throw new NotImplementedException();
        }
        public override void AkortYap()
        {
            Console.WriteLine("piyano akort edildi");
        }
        //public override string ToString()
        //{
        //    return $"Marka {Marka}  Model  {Model}";
        //}
    }
}
