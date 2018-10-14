/*Za 10 nasumično generisanih prirodnih brojeva u intervalu od 100 do 10000 odrediti sumu
 * cifara svakog broja. Prikayati generisane brojeve i njihove sume cifara. Odrediti i 
 * prikazati maksimalnu sumu cifara i broj kome pripada data suma.
 */
 using System;

namespace Lab1Zad2J
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojMax = 0;
            int sumaCifMax = 0;
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int r = random.Next(100, 10000);
                int rBroj = r;
                int sum = 0;
                
                while (r != 0)
                {
                    int m = r % 10;
                    r = r / 10;
                    sum = sum + m;
                }
                Console.WriteLine("Suma cifara broja: {0,4} je {1}", rBroj, sum);
                if(sumaCifMax < sum)
                {
                    sumaCifMax = sum;
                    brojMax = rBroj;
                }
            }
            //Primena konkatenacije
            Console.WriteLine("\nMaksimalna suma cifara je " + sumaCifMax + " broja " + brojMax + ".");
        }
    }
}
