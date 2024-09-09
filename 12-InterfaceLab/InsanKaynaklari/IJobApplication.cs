using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari
{
    public interface IJobApplication
    {
        string Name { get; set; }
        string Gender { get; set; }
        int Age { get; set; }
        string Education { get; set; }
        List<string> Skills { get; set; }
        string ForeignLanguage { get; set; }
        string MilitaryStatus { get; }
        List<string> Projects { get; set; }
        List<string> WorkExperience { get; set; }

        public bool IsEligible()
        {
            // Örnek koşul: ASP.NET ve Java bilen adaylar kabul edilsin
            if (Skills.Contains("ASP.NET") && Skills.Contains("Java"))
            {
                return true;
            }

            return false;
        }
    }
}
