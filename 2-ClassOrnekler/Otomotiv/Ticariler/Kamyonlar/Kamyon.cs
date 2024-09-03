using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_ClassOrnekler.Otomotiv;

namespace _2_ClassOrnekler.Otomotiv.Ticariler.Kamyonlar
{
    internal class Kamyon
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public YakitTipi YakitTipi { get; set; }
        public UstYapi UstYapi { get; set; }
    }
}
