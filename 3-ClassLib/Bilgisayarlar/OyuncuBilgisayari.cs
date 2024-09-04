using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public class OyuncuBilgisayari 
    {

        //propertylere ilk atama bu sekilde yapilabilir. 
        public Anakart Anakart { get; set; }=new Anakart();
        public Cpu Cpu { get; set; }=new Cpu("Intel","I9",8,5000);

        public List<Ram> Ramler { get; set; }=new List<Ram>();
        public List<EkranKarti> EkranKartlari { get; set; }=new List<EkranKarti>();

        public List<SSD> Diskler { get; set; }=new List<SSD>();

        public string Aciklama { get; set; } = string.Empty;
        public OyuncuBilgisayari()
        {
            //Anakart=new Anakart();
            //if (Cpu != null) Cpu.Marka = "AMD";
            Anakart.Marka = "Gigabyte";
            Cpu.Marka = "AMD";
        }
        public bool RamEkle(Ram ram)
        {
            Ramler.Add(ram);
            return true;
        }
        public bool DiskEkle(SSD disk)
        {
            Diskler.Add(disk);
            return true;
        }
        public double FiyatHesapla()
        {
            double toplamtutar = 0;
            foreach (var item in Ramler)
            {
                toplamtutar += toplamtutar + item.Fiyat;
            }
            foreach(var item in Diskler)
            {
                toplamtutar += toplamtutar + item.Fiyat;
            }
            foreach(var item in EkranKartlari)
            {
                toplamtutar += toplamtutar + item.Fiyat;
            }
            toplamtutar += Anakart.Fiyat;
            toplamtutar += Cpu.Fiyat;

            return toplamtutar;
        }
    }
}
