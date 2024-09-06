using _7_Abstract.AlanHesaplari;

namespace _7_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MuzikOrnegi
            //Gitar gitar= new Gitar() { Marka="Fender",Model="xyz"};
            //Flut flut= new Flut() { Marka="Yamaha", Model="abc"};

            //Piyano piyano = new Piyano() { Marka="Roland",Model="qweq"} ;
            //Console.WriteLine(piyano);

            //Console.WriteLine(gitar);
            //Console.WriteLine(flut);

            //Console.WriteLine(gitar.Cal());
            //Console.WriteLine(flut.Cal());

            //flut.AkortYap();
            //gitar.AkortYap();

            //List<MuzikAleti> muzikAletis = new List<MuzikAleti>();
            //muzikAletis.Add(gitar);
            //muzikAletis.Add(flut);
            //muzikAletis.Add(piyano);

            //Muzisyen Ismail = new Muzisyen(muzikAletis);
            //Console.WriteLine(Ismail); 
            #endregion

            #region Sekil Ornegi

            DİkUcgen dikUcgen = new DİkUcgen() { KısaKenar=3,UzunKenar=4};
            Kare kare = new Kare() { UzunKenar=5,KısaKenar=5};

            List<Sekil> sekils = new List<Sekil>() { kare, dikUcgen };

            AlanHesaplayici hesaplayici = new AlanHesaplayici(sekils);
            //AlanHesaplayici hesaplayici2 = new AlanHesaplayici(); // sekil verilmek zorunda hata verir

            //Console.WriteLine(hesaplayici.AlanHesapla());
            //Console.WriteLine(hesaplayici.CevreHesapla());

            Console.WriteLine(hesaplayici);
                
            

            #endregion
        }
    }
}
