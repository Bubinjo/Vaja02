// 15.naloga: Indiana Jones najde v starem templju tri zlate kipce, ker pa ima samo dve roki, mora enega pustiti tam.
// Napiši program, ki bo prebral vrednosti vsakega od kipcev in izpisal, katera dva kipca se najbolj splača vzeti s sabo.
// Vrednosti kipcev so realna števila.

using System;

namespace Naloga15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vrednost prvega kipca: ");
            double prvi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vrednost drugega kipca: ");
            double drugi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vrednost tretjega kipca: ");
            double tretji = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");

            if (prvi < drugi && prvi < tretji)
            {
                Console.WriteLine("S seboj naj vzame drugi in tretji kipec!");
            }
            else if (drugi < prvi && drugi < tretji)
            {
                Console.WriteLine("S seboj naj vzame prvi in treji kipec!");
            }
            else
            {
                Console.WriteLine("S seboj naj vzame prvi in drugi kipec!");
            }
        }
    }
}
