// 5.naloga: Napiši program, ki prebere dve realni števili in ugotovi, ali je njun produkt večji od njune vsote. 
// V vsakem primeru izpiše produkt in vsota v eksponentni obliki, če je produkt večji, pa izpiše še »Produkt je večji od vsote.«

using System;

namespace Naloga05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double vsota = x + y;
            double produkt = x * y;

            Console.WriteLine("Njuna vsota je: {0, 0:E0}", vsota);
            Console.WriteLine("Njun produkt je: {0, 0:E0}", produkt);

            if (produkt > vsota)
            {
                Console.WriteLine("Produkt je vecji od vsote.");
            }
        }
    }
}