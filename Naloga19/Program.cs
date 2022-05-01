// 19.naloga: Napiši program, ki prebere letnico in izpiše, ali predstavlja prestopno leto ali ne. Pogoji za prestopno leto so naslednji:
// Leto je prestopno, če je deljivo s 4, razen;
// ... v primeru, da je leto deljivo s 100 , leto ni prestopno.
// ... v primeru, da je leto deljivo s 400 leto je prestopno.
// Npr. leto 2004 je bilo prestopno; leto 1900 ni bilo prestopno; leto 2013 ni prestopno, leto 2000 je bilo prestopno.

using System;

namespace Naloga19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vpisi leto in ti povem, ce je prestopno: ");
            int leto = Convert.ToInt32(Console.ReadLine());

            if (leto % 4 == 0 && (leto % 100 != 0 || leto % 400 == 0))
            {
                Console.WriteLine("Leto {0} je prestopno!", leto);
            }
            else
            {
                Console.WriteLine("Leto {0} ni prestopno.", leto);
            }
        }
    }
}
