using System.Collections.Generic;
using System.Threading.Channels;
using taxi;
using TAXI;
using static System.Net.Mime.MediaTypeNames;
using static taxi.baza;

// var bazatest = new testbazyzneta();
// bazatest.Main();

Console.WriteLine("WYBIERZ OPCJĘ:\r\n\r\n1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK\r\n\r\n2 => ZAMÓW TAKSÓWKĘ\r\n\r\n3 => ZAKOŃCZ PROGRAM\r\n\r\nWYBIERZ 1, 2 LUB 3:");
while (true)
{
    var Wk = Console.ReadLine();
    Console.WriteLine(Wk);
    Console.Clear();
    if (Wk == "1")
    {
        //to ma być tabela więc jak wam się nudzi to zrubcie z tego tabele bo będzie potrzebna do obliczeń 
        Console.WriteLine("LISTA DZIELNIC\r\n\r\n--List<Taksówki>---------------------------------------\r\n\r\nNUMER | NAZWA | ILOŚĆ TAKSÓWEK\r\n\r\n1 | Retkinia | 1\r\n\r\n2 | Łódź Kaliska | 1\r\n\r\n3 | Śródmieście | 1\r\n\r\n4 | Widzew | 1\r\n\r\n5 | Janów | 1\r\n\r\nLISTA TAKSÓWEK\r\n\r\n-----------------------------------------\r\n\r\nSAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA\r\n\r\nFord Mondeo | wolny | Retkinia\r\n\r\nDacia Logan | wolny | Łódź Kaliska\r\n\r\nToyota Avensis | wolny | Śródmieście\r\n\r\nMercedes E220 | wolny | Widzew\r\n\r\nHuindai Lantra | wolny | Janów\r\n\r\nWYBIERZ OPCJĘ:\r\n\r\n1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK\r\n\r\n2 => ZAMÓW TAKSÓWKĘ\r\n\r\n3 => ZAKOŃCZ PROGRAM\r\n\r\nWYBIERZ 1, 2 LUB 3:");

    }
    else if (Wk == "2")
    {
        //a tu będom obliczenia z tabeli 
        Console.WriteLine("PROSZĘ PODAĆ NUMER DZIELNICY DO KTÓREJ CHCESZ WEZWAĆ TAKSÓWKĘ:");
        //no i git

    }
    else if (Wk == "2137")
    {
        var gra = new GRA1100();
        gra.minigra();
    }

    else if (Wk == "3")
    {
      
    }

    else
    {

        List<string> texts = new List<string>()
        {
            "O rety kotlety coś się nie udało niestety",
            "na pewno potrafisz kliknąć pare przycisków więc na pewno jest to nasz błąt",
            "Coś mi się zdaje że kliknołeś złe przyciski",
            "Masz do wyboru 5 przycisków Nie klikaj innych",
            "jeżeli sobie nie dajesz rady samemu to może niech ktoś ci pomoże",
            "Może spróbujesz jeszcze raz",
            "yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy",
            "Tego się nie spodziewałem"
        };

        Random random = new Random();
        int coś = random.Next(texts.Count);
        string cośText = texts[coś];

        Console.WriteLine(cośText);
    }
};
