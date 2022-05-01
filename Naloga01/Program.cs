// 1.Naloga: Kaj izpiše naslednji program (dopiši kako se spremenljivki i spreminja vrednost v vsaki programski vrstici):
// int i = 0;

// if (i == 0)
//    i++;
//    i++;

// if (i == 3)
//    i += 2;
//    i += 2;

// Console.WriteLine(i);

using System;

namespace Naloga01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            if (i == 0)
                i++;
                i++;

            if (i == 3)
                i += 2;
                i += 2;

            Console.WriteLine(i);

            // vrednost spremeljivke i je 4
        }
    }
}