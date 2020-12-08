using System;

namespace JensNeergaardBiblotek
{
    class Program
    {
        public static Bibliotek bibliotek = new Bibliotek("Sønderborg Bibliotek");
        static void Main(string[] args)
        {
            Console.WriteLine(bibliotek.HentBibliotek() +  " " + DateTime.Now);
            Console.ReadKey();
        }
    }
}
