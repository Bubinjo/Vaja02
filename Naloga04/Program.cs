// 4.naloga: Napiši program, ki prebere celo število in ugotovi, ali je število liho. Če je, izpiše »Število je liho.«

using System;

namespace Naloga04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 1)
            {
                Console.WriteLine("Stevilo je liho.");
            }
        }
    }
}