using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public enum DiskTipi
    {
        SSD=1,
        HDD
    }
    public class SSD : BaseItem
    {
        public int Kapasite { get; set; }
        public DiskTipi DiskTipi { get; set; }
    }
}
