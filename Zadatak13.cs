using System;
/*Napisati program za razmenu minimalnog i maksimalnog člana u vektoru a.
*/
namespace MaxMinNiza
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Ucitaj clanove niza:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i +"]" + " = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int tmax = a[0];
            int tmin = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (tmax < a[i])
                    tmax = a[i];
                if (tmin > a[i])
                    tmin = a[i];
            }
            // korišćenje metode Array.IndexOf(vektor, vrednostElem)
            int maxInd = Array.IndexOf(a, tmax);
            int minInd = Array.IndexOf(a, tmin);
            a[maxInd] = tmin;
            a[minInd] = tmax;
            Console.WriteLine("Maksimalni clan vektora a je: " + tmax);
            Console.WriteLine("Minimalni clan vektora a je: " + tmin);
            Console.WriteLine("Vektor a sa razmenom: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = {1} \n", i, a[i]);
            }
        }
    }
}
