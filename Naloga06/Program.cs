// 6.naloga: Napiši program, ki prebere dve števili. Če je prvo večje od drugega, zamenja njuni vrednosti. 

using System;

namespace Naloga06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > y) { 
                double tmp = x;
                x = y;
                y = tmp;
            }

            Console.WriteLine("Vrednost x: {0}, vrednost y: {1}", x, y);
        }
    }
}