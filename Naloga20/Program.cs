// 20.naloga: Kakšna je vrednost spremenljivk a, b in x na koncu izvajanja naslednjih programskih stavkov?
// int a = 25, b = 9;
// int x = ((a % b) == 7) ? a : b;

using System;

namespace Naloga20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 25, b = 9; // vrednosti spremeljivk a in b ostanejo enake
            int x = ((a % b) == 7) ? a : b; // spremeljivka x dobi vrednost spremeljivke a

            Console.Write(x);
        }
    }
}
