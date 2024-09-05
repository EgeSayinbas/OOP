using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    internal class Flut : MuzikAleti
    {
        public override string Model { get; set; }
        public override string Marka { get; set; }
        //Normal classlar icerisinde abstract metod tanımlanamaz
        //asagidaki kod hata verecektir

        //public abstract void Test(); 
        public override string Cal()
        {
            return "Flut Caldi";
        }
        public override string ToString()
        {
            return $"Marka {Marka}  Model  {Model}";
        }
    }
}
