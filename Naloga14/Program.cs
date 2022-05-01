// 14.naloga: Program naj omogoči vnos realnega števila, ki predstavlja število doseženih točk na testu. Meje za doseganje ocene so določene tukaj:
// [0%, 50%>	- 1
// [50%, 63%>	- 2
// [63%, 76%>	- 3
// [76%, 88%>	- 4
// [88%, 100%] -5
// Program naj izračuna, katera ocena ustreza vnešenim točkam ter to oceno izpiše.

using System;

namespace Naloga14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double max_tock = 100;

            Console.Write("Vseh moznih tock na testu je {0}. Vpisi stevilo tock, ki si jih dosegel in dobis oceno: ", max_tock);

            double tocke = Convert.ToDouble(Console.ReadLine());

            double ocena = (tocke / max_tock) * 100;

            Console.Write("\nTvoja ocena je: ");

            if (ocena < 50)
            {
                Console.WriteLine("1");
            }
            else if (ocena >= 50 && ocena < 63)
            {
                Console.WriteLine("2");
            }
            else if (ocena >= 63 && ocena < 76)
            {
                Console.WriteLine("3");
            }
            else if (ocena >= 76 && ocena < 88)
            {
                Console.WriteLine("4");
            }
            else
            {
                Console.WriteLine("5");
            }
        }
    }
}
