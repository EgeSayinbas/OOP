using _2_ClassOrnekler.Otomotiv;
using _2_ClassOrnekler.Otomotiv.Ticariler.Kamyonlar;

using _2_ClassOrnekler.Bilgisayarlar;


namespace _2_ClassOrnekler
{
    internal class Program
    {
        //struct lar stack te tutulurken class lar heap alaninda tutulur.
        static void Main(string[] args)
        {
            #region Class Instance Alma
            ////1.yol

            //Kitap kitap = new Kitap();
            //kitap.KitapAdi = "Ince Mehmet";
            //kitap.Yazar = "Yasar Kemal";
            //kitap.BaskiYili = new DateOnly(1967, 1, 1);
            //kitap.SayfaSayisi = 300;
            //kitap.Yayinevi = "YKB";

            ////2.yol Object initilation

            //Kitap kitap2 = new Kitap()
            //{
            //    Yazar = "Orhan Pamuk",
            //    Yayinevi="YKB",
            //    KitapAdi="Yeni Hayat",
            //    BaskiYili=new DateOnly(2000,1,1),
            //    SayfaSayisi=250,
            //    Barkod="123123123"
            //};

            ////enum iceren classlardan instance alma

            //Otomobil otomobil = new Otomobil();
            //otomobil.KasaTipi = KasaTipi.Sedan;
            //otomobil.YakitTipi = YakitTipi.Dizel;
            //otomobil.Cekis = Cekis.ArkadanItis;
            //otomobil.Marka = "BMW";
            //otomobil.Model = "3.20";


            //Kamyon kamyon = new Kamyon();
            //kamyon.UstYapi = UstYapi.AcıkKasa;
            ////var kasalar = Enum.GetNames(typeof(KasaTipi));
            ////foreach (var item in kasalar)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.WriteLine(Enum.GetValues(typeof(KasaTipi)));
            ////Console.WriteLine(Enum.GetNames(typeof(KasaTipi)));

            #endregion

            #region Bilgisayarlar
            Bilgisayar Bilgisayar = new Bilgisayar();
            Bilgisayar.Anakart = Anakartlar.MSI_4;
            Bilgisayar.Islemciler = Islemciler.Intel_4;
            Bilgisayar.Bellekler=Bellekler.Kingstong_4;
            Bilgisayar.EkranKartlari=EkranKartlari.Asus_4;
            Bilgisayar.Depolamalar = Depolamalar.Samsung_4;

            Console.WriteLine("Anakart: " + Bilgisayar.Anakart+ "\nEkran Karti: " + Bilgisayar.EkranKartlari + "\nDepolama: " + Bilgisayar.Depolamalar + "\nIslemci: " + Bilgisayar.Islemciler + "\nBellek: " + Bilgisayar.Bellekler);
            
            //otomobil.KasaTipi = KasaTipi.Sedan;
            #endregion
        }
    }
}
