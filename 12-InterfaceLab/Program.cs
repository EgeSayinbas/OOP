using _12_InterfaceLab.FirinOrnegi;
using _12_InterfaceLab.InsanKaynaklari.Concrete;
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
             * is tanimlarinin oldugu bir interface
             * onu bilsin bunu bilsin yaptıgı isler yabanci diller cv bakma gibi okullar projeler
             * asp.net yaz java yaz vb.
             * askerlik kadınsa çıkmasın erkekse çıksın
             * 
             */
            ITBasvuru basvuru = new ITBasvuru()
            {
                EhliyetVarMi = true,
                Departman = InsanKaynaklari.Abstract.Departman.IT,
                isAjax = true,
                isCSS3 = true,
                isEDP = true,
                isJavaScript = true,
                isJQUERY = true,
                isOOP = true,
                isWCF = true,

                Basvuran = new Kisi { Ad="Ali",Soyad="Yilmaz",Cinsiyet=true,Askerlik=true},  //object initialize da alt propertyleri  gelmiyo
                isRazor = true
            };
            
            ITBasvuru basvuru2 = new ITBasvuru()
            {
                EhliyetVarMi = true,
                Departman = InsanKaynaklari.Abstract.Departman.IT,
                isAjax = true,
                isCSS3 = true,
                isEDP = true,
                isJavaScript = true,
                isJQUERY = true,          
                isRazor = true,
                isJson = true,
                isOOP = true,
                isWCF = true,
                SeyahateEngelVarMi = true,
                UniversiteMezunumu = true,
                Basvuran= new Kisi { Ad = "Ayse", Soyad = "Kaya", Cinsiyet = false },
                
            };
            FinansBasvuru basvuru3 = new FinansBasvuru()
            {
                EhliyetVarMi = true,
                Departman = InsanKaynaklari.Abstract.Departman.Finans,
                isExcel = true,
                isMicro=false,
                SeyahateEngelVarMi = true,
                UniversiteMezunumu = true,
                Basvuran = new Kisi { Ad = "Fatma", Soyad = "Kaya", Cinsiyet = false },

            };
            FinansBasvuru basvuru4 = new FinansBasvuru()
            {
                EhliyetVarMi = true,
                Departman = InsanKaynaklari.Abstract.Departman.Finans,
                isExcel = true,
                isMicro = true,
                
                SeyahateEngelVarMi = true,
                UniversiteMezunumu = true,
                Basvuran = new Kisi { Ad = "Hasan", Soyad = "Kaya", Cinsiyet = true },

            };

            IK ik = new IK();
            ik.FinansBasvurusuAL(basvuru4);
            ik.FinansBasvurusuAL(basvuru3);

            ik.ITBasvursuAl(basvuru2);
            ik.ITBasvursuAl(basvuru);

            ik.GenelBasvuruAl(basvuru);
            ik.GenelBasvuruAl(basvuru2);
            ik.GenelBasvuruAl(basvuru3);
            ik.GenelBasvuruAl(basvuru4);

            //ik.GenelBasvuruListele();
            var sonuc=ik.ITBasvurulariniVer().Where(p=>p.isOOP==true&&p.Basvuran.Askerlik==true&&p.Basvuran.Cinsiyet==true).ToList();
            sonuc.ForEach(p => Console.WriteLine(p));

        }

        #endregion
    
    }
}
