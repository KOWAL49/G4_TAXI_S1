using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI
{
    public class testbazyzneta
    {
        public void Main()
        {

        // Tworzenie listy liczb całkowitych
        List<int> numbers = new List<int>();

            // Dodawanie elementów do listy
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(1);

            // Wyświetlanie elementów listy
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}