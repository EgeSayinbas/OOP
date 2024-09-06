using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    #region Konu Anlatimi
    //Abstract classlar sadece kalitim verir
    //Instance alınmaz

    //seales class abstractın tersidir
    #endregion
    public abstract class MuzikAleti
    {
        public abstract string Marka {  get; set; }
        public abstract string Model { get; set; }


        //public string Cal()
        //{
        //    return "Muzik Aleti Caldi";
        //}
        //public string AkortYap()
        //{
        //    return "Muzik Aleti Akort yapti";
        //}


        //1- Abstract metodlarin govdesi olmaz Sadece metod imzalari vardir 
        //2- Kalitim verdikleri yerde govdesinin yazilmasi şarttir.
        //3- Abstract metodlar ancak abstract siniflar icerisinde tanimlanabilir.
        //4- abstract olarak isaretlenmis tum metodlar mutlaka kalitim verildigi yerde override edilmelidir
        public abstract string Cal();


        //Virtual olarak isaretlenen metodlarin govdesi yazilabilir
        //virtual metodlar abstract olsun ya da olmasin butun classlarda tanimlanabilir.
        public virtual void AkortYap()
        {
            Console.WriteLine("Muzik aleti akort edildi");
        }

    }
}
