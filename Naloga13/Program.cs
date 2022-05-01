// 13.naloga: Napiši program, ki generira tri naključna števila med 1 in 6, vsa števila prikaže ter na koncu ugotovi ali so vse številke enake – če so, 
// izpiše 'Jackpot!!!' 
// Naključno število generiraš takole: 
// Random r = new Random();
// int st = r.Next(100);

using System;

namespace Naloga13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int prvo = r.Next(1, 7);
            int drugo = r.Next(1, 7);
            int tretje = r.Next(1, 7);

            if (prvo == drugo && prvo == tretje && drugo == tretje)
            {
                Console.WriteLine("Jackpot!!!");
            }
        }
    }
}
