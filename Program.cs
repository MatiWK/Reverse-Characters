using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmiana_Znaków
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj słowo: ");
            string zdanie = Console.ReadLine();

            char[] arrayZdanie = zdanie.ToCharArray();

            Array.Reverse (arrayZdanie);
            Console.Write("Odwrócone słowo: ");
            Console.Write(arrayZdanie);




            Console.ReadLine();
        }
    }
}
