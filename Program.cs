/*Ako je visina osobe izražena u cm, idealna težina za osobe muškog pola računa se kao visina - 100, a za osobe ženskog pola kao visina -110. Kreirati aplikaciju kojom se unosi visina i težina osobe i unosi se pol osobe unosom slova ‘m’ za muški ili ‘z’ za ženski pol. Kao rezultat ispisuje se odgovarajuća poruka:
Vi imate idealnu tezinu.
Treba da se ugojite ... kg. (navesti koliko kg)
Treba da smrsate …kg. (navesti koliko kg)
Primer:
Ulaz: visina -> 178
tezina -> 70
pol -> m
Izlaz: Treba da se ugojite 8kg.
Metodom TryParse izvršiti proveru unosa i ne dozvoliti da se unese neočekivana
(nenumerička) vrednost.
 * */
using System;

namespace Lab2Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Visina osobe preko 100cm
            Console.Write("\nUnesite visinu osobe (cm): ");
            if (!Int32.TryParse(Console.ReadLine(), out int vis))
            {
                Console.WriteLine("Niste uneli ispravno!");
                return;
            }
            Console.Write("\nUnesite tezinu osobe (kg): ");
            if (!Int32.TryParse(Console.ReadLine(), out int tez))
            {
                Console.WriteLine("Niste uneli ispravno!");
                return;
            }

            int provera;
            Console.Write("\nUnesite pol (m/z): ");
            ConsoleKeyInfo ck = Console.ReadKey();
            if (ck.Key == ConsoleKey.M)
                provera = vis - 100;
            else if (ck.Key == ConsoleKey.Z)
                provera = vis - 110;
            else
            {
                Console.WriteLine("\nNiste uneli ispravno!");
                return;
            }

            if (provera == tez)
                Console.WriteLine("\n\nVi imate idealnu tezinu.");
            else if (provera > tez)
                Console.WriteLine("\n\nTreba da se ugojite {0} kg.", provera - tez);
            else
                Console.WriteLine("\n\nTreba da smrsate {0} kg.", tez - provera);

            Console.Read();
        }
    }
}
