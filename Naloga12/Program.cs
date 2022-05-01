// 12.naloga: Napiši program, ki prebere letnico in izpiše, ali predstavlja prestopno leto ali ne. 

using System;

namespace Naloga12
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
