// 8.naloga: Napišite program, ki bo prebral dve števili in sicer težo v kg in višino osebe v m, ter na podlagi teh parametrov
// izračunal BMI (Body Mass Index) te osebe.Formula za izračun BMI je naslednja:
// BMI = (teža) / (višina)2


// Naj podlagi BMI naj program še izpiše ali ima oseba telesno težo:
//     • Premajhno (BMI pod 18.5)
//     • Normalno(BMI med 18.5 in 25)
//     • Prekomerno(BMI med 25 in 30)
//     • Preveliko(BMI več kot 30)

using System;

namespace Naloga08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi tezo v kg: ");
            double teza = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vnesi visino v cm: ");
            double visina = Convert.ToDouble(Console.ReadLine());

            double bmi = (teza) / (visina * visina / 10000);

            if (bmi < 18.5)
            {
                Console.WriteLine("Premajhno");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Normalno");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Prekomerno");
            }
            else
            {
                Console.WriteLine("Preveliko");
            }
        }
    }
}