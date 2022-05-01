// 2.naloga: Napiši program, ki prebere celo število in ugotovi, ali je manjše od 0. Če je, izpiše »Vpisano število je negativno.«

using System;

namespace Naloga02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Vpisano stevilo je negativno.");
            }
        }
    }
}