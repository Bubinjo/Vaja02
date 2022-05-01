// 17.naloga: Napiši program, ki prebere dve celi števili in aritmetično operacijo, ki naj se izračuna (+, -, *, /, %, drugi vnosi predstavljajo napako).
// Nalogo reši z uporabo switch-case. 

using System;

namespace Naloga17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vpisi prvo celo stevilo: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi drugo celo stevilo: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uporabi eno izmed naslednjih + - * / % : ");
            char operacija = Convert.ToChar(Console.ReadLine());

            switch (operacija)
            {
                case '+':
                    Console.WriteLine("Sestevek {0} + {1} = {2}", x, y, x + y);
                    break;
                case '-':
                    Console.WriteLine("Sestevek {0} - {1} = {2}", x, y, x - y);
                    break;
                case '*':
                    Console.WriteLine("Sestevek {0} * {1} = {2}", x, y, x * y);
                    break;
                case '/':
                    Console.WriteLine("Sestevek {0} / {1} = {2}", x, y, (float)x / y);
                    break;
                case '%':
                    Console.WriteLine("Sestevek {0} % {1} = {2}", x, y, x % y);
                    break;
                default:
                    Console.WriteLine("Vnesi veljavno racunsko operacijo.");
                    break;
            }
        }
    }
}
