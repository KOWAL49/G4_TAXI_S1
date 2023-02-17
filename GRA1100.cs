using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI
{
    internal class GRA1100
    {
        public void minigra()
        {
            Random random = new Random();
            int tajemniczaliczba = random.Next(1, 101);
            int pruba = 0;
            int liczbagracz;

            Console.WriteLine("Witamy w mini gierce twoim zadaniem jest odgadnąć tajemnicą liczbe !!!!!!");

            do
            {
                Console.Write("Zgadnij liczbę między 1 a 100: ");
                liczbagracz = int.Parse(Console.ReadLine());

                pruba++;

                if (liczbagracz < tajemniczaliczba)
                {
                    Console.WriteLine(" ^ Większa \r\n |");
                }
                else if (liczbagracz > tajemniczaliczba)
                {
                    Console.WriteLine(" | Mniejsza \r\n V");
                }
            } while (liczbagracz != tajemniczaliczba);

            Console.WriteLine($" Udało ci się Brawo!!  \r\n Zgadłeś za {pruba} razem \r\n gratulacje !!!  ");
            Console.WriteLine("Wracaj na główną strone i cicho nie mów nikomu o tym easter egg to tajemnica ");
        }
    }
}

