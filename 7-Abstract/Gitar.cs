using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    public class Gitar : MuzikAleti
    {
        public override string Model { get; set; }
        public override string Marka { get; set; }


        //public string Cal()
        //{
        //    return "Gitar Caldi";

        //}

        public override string Cal()
        {
            return "Gitar Caldi";
        }
        public override void AkortYap()
        {
            Console.WriteLine("Gitar akort edildi");
        }
        public override string ToString()
        {
            return $"Marka {Marka}  Model  {Model}";
        }

    }
}
