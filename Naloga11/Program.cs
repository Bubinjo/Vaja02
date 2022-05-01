// 11.naloga: Napiši program, ki prebere tri števila in izpiše največje ter najmanjše.

using System;

namespace Naloga11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vpisi prvo stevilo: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi drugo stevilo: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi tretje stevilo: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            if (x < y && x < z)
            {
                Console.WriteLine("Stevilo {0} je najmanjse", x);
            }
            else if (y < x && y < z)
            {
                Console.WriteLine("Stevilo {0} je najmanjse", y);
            }
            else
            {
                Console.WriteLine("Stevilo {0} je najmanjse", z);
            }

            if (x > y && x > z)
            {
                Console.WriteLine("Stevilo {0} je najvecje", x);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("Stevilo {0} je najvecje", y);
            }
            else
            {
                Console.WriteLine("Stevilo {0} je najvecje", z);
            }
        }
    }
}