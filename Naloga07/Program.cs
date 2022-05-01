// 7.naloga: Napiši program, ki prebere dve celi števili, preveri ali je prvo število večkratnik drugega števila in, če je, izpiše ustrezno besedilo.

using System;

namespace Naloga07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (y % x == 0)
            {
                Console.WriteLine("Stevilo {0} je vekratnik stevila {1}", y, x);
            }
        }
    }
}