/*Napiši program koji ubacuje element E u vektor realnih brojeva A dužine N na
K-tu poziciju (0<=k<n) ne menjajući relativni poredak članova vektora.
*/
using System;

namespace UbaciElemUNiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int k = 0;
            int elem = 0;

            Console.WriteLine("Unesi broj elementa: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            //Unesi brojeve u vektor
            Console.WriteLine("Unesi brojeve : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[" + (i) + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Unesi poziciju : ");
            k = int.Parse(Console.ReadLine());

            Console.Write("Unesi novi elemenat : ");
            elem = int.Parse(Console.ReadLine());

            Array.Resize<int>(ref a, a.Length + 1);

            //Pomeranje elemenata od k-te pozicije za 1 mesto navise
            for (i = a.Length - 1; i >= k; i--)
            {
                a[i] = a[i - 1];
            }
            a[k - 1] = elem;

            //Stampaj vektor posle ubacivanja elementa
            Console.WriteLine("Vektor posle ubacivanja : ");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Element[" + i + "]: " + a[i]);
            }
            Console.WriteLine();
        }
    }
}
