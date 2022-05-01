// 1.Naloga: Napiši program, ki prebere črko angleške abecede in izpiše ustrezno Morseovo kodo (kombinacija črtic in pik).
// Tabelo najdi na spletu. Upoštevaj majhne in velike črke. Nalogo reši z uporabo switch-case.

using System;

namespace Naloga21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morseovo-a koda");
            Console.Write("Vpisi crko angleske abecede: ");
            char crka = Char.ToLower(Convert.ToChar(Console.ReadLine()));

            switch (crka)
            {
                case 'a':
                    Console.WriteLine("Preveden znak:  .-");
                    break;
                case 'b':
                    Console.WriteLine("Preveden znak:  -...");
                    break;
                case 'c':
                    Console.WriteLine("Preveden znak:  -.-.");
                    break;
                case 'd':
                    Console.WriteLine("Preveden znak:  -..");
                    break;
                case 'e':
                    Console.WriteLine("Preveden znak:  .");
                    break;
                case 'f':
                    Console.WriteLine("Preveden znak:  ..-.");
                    break;
                case 'g':
                    Console.WriteLine("Preveden znak:  --.");
                    break;
                case 'h':
                    Console.WriteLine("Preveden znak:  ....");
                    break;
                case 'i':
                    Console.WriteLine("Preveden znak:  ..");
                    break;
                case 'j':
                    Console.WriteLine("Preveden znak:  .---");
                    break;
                case 'k':
                    Console.WriteLine("Preveden znak:  -.-");
                    break;
                case 'l':
                    Console.WriteLine("Preveden znak:  .-..");
                    break;
                case 'm':
                    Console.WriteLine("Preveden znak:  --");
                    break;
                case 'n':
                    Console.WriteLine("Preveden znak:  -.");
                    break;
                case 'o':
                    Console.WriteLine("Preveden znak:  ---");
                    break;
                case 'p':
                    Console.WriteLine("Preveden znak:  .--.");
                    break;
                case 'q':
                    Console.WriteLine("Preveden znak:  --.-");
                    break;
                case 'r':
                    Console.WriteLine("Preveden znak:  .-.");
                    break;
                case 's':
                    Console.WriteLine("Preveden znak:  ...");
                    break;
                case 't':
                    Console.WriteLine("Preveden znak:  -");
                    break;
                case 'u':
                    Console.WriteLine("Preveden znak:  ..-");
                    break;
                case 'v':
                    Console.WriteLine("Preveden znak:  ...-");
                    break;
                case 'w':
                    Console.WriteLine("Preveden znak:  .--");
                    break;
                case 'x':
                    Console.WriteLine("Preveden znak:  -..-");
                    break;
                case 'y':
                    Console.WriteLine("Preveden znak:  -.--");
                    break;
                case 'z':
                    Console.WriteLine("Preveden znak:  --..");
                    break;
                default:
                    Console.WriteLine("Neveljaven znak ...");
                    break;
            }
        }
    }
}
