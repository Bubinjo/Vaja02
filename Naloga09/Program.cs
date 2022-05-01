// 9.Naloga: Napiši program, ki bo izračunal provizijo za plačilo položnice.
// Provizija je 0,1% od zneska položnice, največ pa lahko znaša 2,50 €.
// Program naj omogoči vnos zneska položnice in izračun ter prikaz izračunane provizije.

using System;

namespace Naloga09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi znesek poloznice: ");
            double znesek = Convert.ToDouble(Console.ReadLine());

            double provizija = znesek / 1000;

            if (provizija > 2.5)
            {
                Console.WriteLine("Izracunana provizija: {0} €. Znasa nad 2.5 €", provizija);
            }
            else
            {
                Console.WriteLine("Izracunana provizija: {0} €. Znasa pod 2.5 €", provizija);
            }
        }
    }
}