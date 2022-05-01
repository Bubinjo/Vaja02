// 2.Naloga: Kakšna je vrednost spremenljivk a, b in x na koncu izvajanja naslednjih programskih stavkov?

// int a = 13, b = 1;
// int x = ((a % b) > 1) ? a : b;

using System;

namespace Naloga22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 13, b = 1; // vrednost spremeljivk a in b ostane enaka
            int x = ((a % b) > 1) ? a : b; // spremeljivka x dobi vrednost 1. Ostanek pri deljenju je 0, sledi da pogoj ni izpolnjen

            // Console.WriteLine(x);
        }
    }
}
