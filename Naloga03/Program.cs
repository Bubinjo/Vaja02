// 3.naloga: Napiši program, ki prebere znak in preveri, ali je vpisan znak mala črka angleške abecede.
// Če je, izpiše npr. »Znak x je mala črka, velika pa bi izgledala takole: X!« (v besedilu torej izpiše malo črko in še ustrezno veliko črko).

using System;

namespace Naloga03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x = Convert.ToChar(Console.ReadLine());

            if (x >= 'a' && x <= 'z')
            {
                Console.WriteLine("Znak {0} je mala crka, velika pa bi zgledala takole: {1}!", x, Char.ToUpper(x));
            }
        }
    }
}