// 10.naloga: Napiši program, ki prebere tri števila in ugotovi ali je prvo najmanjše ali ne (z gnezdenjem if in s sestavljenim pogojem).

using System;

namespace Naloga10
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

            if (x < y)
            {
                if (x < z)
                {
                    Console.WriteLine("Stevilo {0} je najmanjse.", x);
                }

            }
            if (x > y || x > z)
            {
                Console.WriteLine("Stevilo {0} ni najmanjse.", x);
            }
        }
    }
}
