using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassOrnekler.Otomotiv
{
    public class Otomobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public KasaTipi KasaTipi { get; set; }
        public Vites Vites { get; set; }
        public DateOnly UretimYili { get; set; }

        public Cekis Cekis { get; set; }

        public YakitTipi YakitTipi { get; set; }
    }
}
