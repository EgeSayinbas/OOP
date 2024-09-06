using _12_InterfaceLab.FirinOrnegi;
using _12_InterfaceLab.LokantaOrnegi;

namespace _12_InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Firin Ornegi
            //#region Concrete instance alma

            //Usta usta = new Usta() { AdSoyad="Hasan Usta"};
            //Makina makina = new Makina() { MakinaAdi = "Yogurma makinasi" };


            //#endregion

            //#region Interface uzerinden instance alma

            //IYogurma usta1 = new Usta() { AdSoyad = "Hasan Usta" };
            //IYogurma makina1 = new Makina() { MakinaAdi = "Yogurma makinasi" };
            //usta1.HamurYogur();
            //makina1.HamurYogur();
            //#endregion          

            //Karafirin karafirin = new Karafirin();
            //karafirin.EkmekPisir(usta);
            //karafirin.EkmekPisir(makina); 
            #endregion

            #region Lokanta Ornegi

            #region Concrete instance alma
            //Pilav pilav = new Pilav();
            //Kofte kofte = new Kofte();
            //Kurufasulye kurufasulye = new Kurufasulye();
            //Sutlac sutlac = new Sutlac(); 
            #endregion

            #region Interface uzerinden instance alma
            //IPisirilebilir pilav = new Pilav();
            //IPisirilebilir kofte = new Kofte();
            //IPisirilebilir kurufasulye = new Kurufasulye();
            //IPisirilebilir sutlac = new Sutlac(); 
            ////IPisirilebilir salata=new Salata();
            #endregion


            //List<IPisirilebilir> pisirilebilirs= new List<IPisirilebilir>();
            //pisirilebilirs.Add(kofte);
            //pisirilebilirs.Add(pilav);
            //pisirilebilirs.Add(kurufasulye);
            //pisirilebilirs.Add(sutlac);
            ////pisirilebilirs.Add(salata);


            //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
            //borsaLokantasi.YemekPisir(pisirilebilirs);
            #endregion

            #region InsanKaynaklari ornegi

            /*
             * IT elemani arayan bir firmanin insan kaynaklarindaki basvuru surecini modelleyin
             * 
             */
            #endregion
        }
    }
}
