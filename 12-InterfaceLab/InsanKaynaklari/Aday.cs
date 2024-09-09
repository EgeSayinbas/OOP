using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari
{

    


    public class Aday : IJobApplication
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Education { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public string ForeignLanguage { get; set; }
        public string MilitaryStatus
        {
            get
            {
                if (Gender.ToLower() == "erkek")
                {
                    return "Askerlik durumu kontrol ediliyor.";
                }
                else
                {
                    return "Askerlik durumu gerekmiyor.";
                }
            }
        }
        public List<string> Projects { get; set; } = new List<string>();
        public List<string> WorkExperience { get; set; } = new List<string>();

        
    }

    


}
