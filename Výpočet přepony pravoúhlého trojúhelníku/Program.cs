using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Výpočet_přepony_pravoúhlého_trojúhelníku
{
    class Program
    {
        static void Main(string[] args)
        {
            double odvesna1 = 0;
            double odvesna2 = 0;

            Console.Write("Zadejte 1. odvesnu: ");
            odvesna1 = double.Parse(Console.ReadLine());

            Console.Write("Zadejte 2. odvesnu: ");
            odvesna2 = double.Parse(Console.ReadLine());

            double odvesna3 = odvesna1 * odvesna1 + odvesna2 * odvesna2;

            Console.WriteLine("Délka odvěsny je: {0}", odvesna3);
            Console.ReadKey();

        }
    }
}
