using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    internal class baza
    {
        public class taksowki
        {
            public int id { get; set; }
            public string samochod { get; set; }
            public string status { get; set; }
            public string aktualnadzielnica { get; set; }


            List<taksowki> BAZATAXI = new List<taksowki>
        {
        new taksowki {id = 1, samochod = "ford mondeo", status = "wolny", aktualnadzielnica = "retkinia"},

        new taksowki {id = 2, samochod = "dacia logan", status = "wolny", aktualnadzielnica = "łódź kaliska"},

        new taksowki {id = 3, samochod = "toyota avensis", status = "wolny", aktualnadzielnica = "śródmieście"},

        new taksowki {id = 4, samochod = "mercedes e220", status = "wolny", aktualnadzielnica = "widzew"},

        new taksowki {id = 5, samochod = "huindai lantra", status = "wolny", aktualnadzielnica = "janów"}
        };

        }

        public void TAXI12()
        {
           // foreach (int number in taksowki)
           // {
            //    Console.WriteLine(number);
         //   }
        }


    }
}
