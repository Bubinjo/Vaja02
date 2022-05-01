// 16.naloga: Kaj je rezultat naslednjega zaporedja stavkov (dopiši kako se spremenljivki a in b spreminjata v vsaki programski vrstici): 
// int a = 3, b = 0;
// switch (a)
// {
//    case 2: b = b + 1;
//    case 3: b = b + 2;
//    case 4: b = b + 3;
// }

using System;

namespace Naloga16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 0;
            switch (a)
            {
                case 2: b = b + 1;
                case 3: b = b + 2; // spremeljivka v se poveca iz 0 -> 2
                case 4: b = b + 3;
            }
        }
    }
}
