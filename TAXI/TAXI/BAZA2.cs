using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI
{
    internal class BAZA2
    {
        public class Dzielnica
        {
            public int Numer { get; set; }
            public string Nazwa { get; set; }
            public string Odległość_od_centrum { get; set; }


            List<Dzielnica> Dzielnica1 = new List<Dzielnica>
        {
        new Dzielnica {Numer = 1, Nazwa = "Retkinia", Odległość_od_centrum = "-2 km"},

        new Dzielnica {Numer = 2, Nazwa = "Łódź Kaliska", Odległość_od_centrum = "-1 km"},

        new Dzielnica {Numer = 3, Nazwa = "Śródmieście", Odległość_od_centrum = "0 km"},

        new Dzielnica {Numer = 4, Nazwa = "Widzew", Odległość_od_centrum = "1 km"},

        new Dzielnica {Numer = 5, Nazwa = "Janów",Odległość_od_centrum = "3 km"}
        };

        }
    }
}
