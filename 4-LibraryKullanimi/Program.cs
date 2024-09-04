using _3_ClassLib.Bilgisayarlar;


namespace _4_LibraryKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cpu cpu = new Cpu();
            cpu.Marka = "AMD";
            
            Anakart anaKart = new Anakart();

            //Abstract classlardan instance alinamaz.
            //BaseItem baseItem = new BaseItem();
            //baseItem.Marka = "xyz";
            //baseItem.Model = "abc";
            //baseItem.Fiyat = 12;

            Bilgisayar bilgisayar = new Bilgisayar();
            OyuncuBilgisayari oyuncu = new();

            //bilgisayar.Anakart = anaKart;
            //bilgisayar.Cpu = cpu;
            //bilgisayar.Ramler = new List<Ram>();
            //bilgisayar.Ramler.Add(new Ram() { Marka = "Kingston" });
            //bilgisayar.Ramler.Add(new Ram() { Model = "1.23" });
            //bilgisayar.Diskler = new List<SSD>();
            //bilgisayar.Diskler.Add(new SSD() { Marka = "CORSAIR" , DiskTipi=DiskTipi.SSD});
            //bilgisayar.EkranKartlari = new List<EkranKarti>();

            //oyuncu = null;

            Console.WriteLine("oyuncupc fiyat=" +oyuncu.FiyatHesapla());
            Console.WriteLine("pc fiyat=" + bilgisayar.FiyatHesapla());

        }
    }
}
