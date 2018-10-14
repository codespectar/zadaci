/*
Dve tačke nazivamo bliskim ako rastojanje među njima ne prelazi dati realni
broj d. Napisati aplikaciju kojom se generišu na slučajan način tačke u polju NxM (dve su N i M
prirodni brojevi), sve dok su međusobno bliske. Prikazati koordinate generisanih tačaka.
Program treba da ispiše i broj generisanih tačaka.
*/

using System;

namespace Lab1Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite granicne koordinate polja u okviru koga trazimo bliske tacke:");
            Console.Write("N -> ");   //max vrednost x koordinate 
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("M -> ");   //max vrednost y koordinate 
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite rastojanje na kome trazimo bliske tacke?\nd -> ");
            double d = Convert.ToDouble(Console.ReadLine());   //zaglavlje tabele
            Console.WriteLine("\nParovi bliskih tacaka u polju {0}x{1}", n, m);
            Random r = new Random();    //kreiramo generator slucajnih brojeva
            int br = 0;     //brojac ce da broji kreirane parove bliskih tacaka
            while (true)
            { //kad hocemo da generator bira brojeve od 1 do 10,
                //granice postavljamo 1 do 11 zato sto donja granica ulazi u opseg, a gornja ne 
                int x1 = r.Next(0, n + 1);
                int y1 = r.Next(0, m + 1);
                int x2 = r.Next(0, n + 1);
                int y2 = r.Next(0, m + 1);
                double rast = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                if (rast > d) break;
                else
                { //tacke su bliske i stampamo njihove koordinate 
                    //FORMATIRANJE: 
                    //{0,2}... znaci da se broj stampa na dve pozicije 
                    //{4:f2}... znaci da tu treba da se prikaze realni broj na dve decimale
                    Console.WriteLine("({0,2}, {1,2})\t({2,2}, {3,2})\tna rastojanju {4:f2}", x1, y1, x2, y2, rast); br++; //brojimo ovaj  par bliskih tacaka
                }
            }
            Console.WriteLine("\n\nGenerisano je {0} parova bliskih tacaka", br);
            //Console.ReadLine();
        }
    }
}
