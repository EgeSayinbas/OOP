namespace _7_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gitar gitar= new Gitar() { Marka="Fender",Model="xyz"};
            Flut flut= new Flut() { Marka="Yamaha", Model="abc"};

            Piyano piyano = new Piyano();
            Console.WriteLine(piyano);

            Console.WriteLine(gitar);
            Console.WriteLine(flut);

            Console.WriteLine(gitar.Cal());
            Console.WriteLine(flut.Cal());

            flut.AkortYap();
            gitar.AkortYap();


        }
    }
}
