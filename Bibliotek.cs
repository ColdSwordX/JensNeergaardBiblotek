using System;
using System.Collections.Generic;
using System.Text;

namespace JensNeergaardBiblotek
{
    public class Bibliotek
    {
        public string biblioteksNavn;

        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;
        }

        public string HentBibliotek()
        {
            string temp = "Velkommen til " + biblioteksNavn;
            return temp;
        }
    }
}
