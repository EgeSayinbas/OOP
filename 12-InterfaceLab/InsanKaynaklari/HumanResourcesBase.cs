namespace _12_InterfaceLab.InsanKaynaklari
{
    public class HumanResourcesBase
    {
        public void ReviewApplication(IJobApplication candidate)
        {
            Console.WriteLine($"Adayın İsmi: {candidate.Name}");
            Console.WriteLine($"Eğitim: {candidate.Education}");
            Console.WriteLine($"Askerlik Durumu: {candidate.MilitaryStatus}");
            Console.WriteLine($"Yabancı Dil: {candidate.ForeignLanguage}");
            Console.WriteLine($"Projeler: {string.Join(", ", candidate.Projects)}");
            Console.WriteLine($"İş Tecrübeleri: {string.Join(", ", candidate.WorkExperience)}");

            if (candidate.IsEligible())
            {
                Console.WriteLine("Aday başvuru kriterlerine uygun.");
            }
            else
            {
                Console.WriteLine("Aday başvuru kriterlerine uygun değil.");
            }
        }
        
        
    }
}