// 18.naloga: Napiši program, ki prebere tri števila, ki predstavljajo LETO, MESEC in DAN.
// Za vsak tako vnešen datum naj program izračuna in izpiše z besedo, kateri je to dan v tednu.
// Dan v tednu se računa po naslednjem algoritmu:

//    • če je MESEC<3, potem MESEC=MESEC+12, LETO = LETO - 1;
//    • a = 2 * MESEC + 6 * (MESEC + 1) / 10
//    • b = LETO + LETO / 4 – LETO / 100 + LETO / 400
//    • f1 = DAN + a + b + 1
//    • f = f1 MOD 7
// kjer je f dan v tednu (0=nedelja, 1=ponedeljek, ...), a, b in f1 pa so pomožne spremenljivke.
// Vsa deljenja so celoštevilčna deljenja (decimalke se odrežejo). Uporabi switch-case stavek.

using System;

namespace Naloga18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spodaj vpisi vse s stevilkami");
            Console.Write("Vpisi leto: ");
            int leto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi mesec: ");
            int mesec = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi dan: ");
            int dan = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            if (mesec < 3)
            {
                mesec += 12;
            }
            else
            {
                leto -= 1;
            }

            int a = 2 * mesec + 6 * (mesec + 1) / 10;
            int b = leto + leto / 4 - leto / 100 + leto / 400;
            int f1 = dan + a + b + 1;
            int f = f1 % 7;

            switch (f)
            {
                case 0:
                    Console.WriteLine("To je ponedeljek");
                    break;
                case 1:
                    Console.WriteLine("To je torek");
                    break;
                case 2:
                    Console.WriteLine("To je sreda");
                    break;
                case 3:
                    Console.WriteLine("To je cetrtek");
                    break;
                case 4:
                    Console.WriteLine("To je petek");
                    break;
                case 5:
                    Console.WriteLine("To je sobota");
                    break;
                case 6:
                    Console.WriteLine("To je nedelja");
                    break;
                default:
                    Console.WriteLine("Nekaj je bilo narobe...");
                    break;
            }


        }
    }
}
