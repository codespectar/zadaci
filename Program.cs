/*Napisati program koji slučajno bira broj od 1 do 7 i u zavisnosti od generisanog broja prikazuje
neku od sledećih poruka: "Dobar dan.“, "Nije fer!“ i dalje: "Ludo se provodim.", "Da li ste
raspolozeni za ples?", "Oladi malo.", "Dovidjenja", "Zauzeto!“. Ispisivanje poruka vršiti svakim
pritiskom na ENTER. Kraj je kada se pritisne slovo 'K' ili 'k'.
 * */
using System;
namespace Lab2Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            ConsoleKeyInfo keyInfo;
            Random rnd = new Random();
            do
            {
                broj = rnd.Next(1, 8);
                switch (broj)
                {
                    case 1:
                        Console.WriteLine("Dobar dan.");
                        break;
                    case 2:
                        Console.WriteLine("Nije fer!");
                        break;
                    case 3:
                        Console.WriteLine("Ludo se provodim.");
                        break;
                    case 4:
                        Console.WriteLine("Da li ste raspolozeni za ples?");
                        break;
                    case 5:
                        Console.WriteLine("Oladi malo.");
                        break;
                    case 6:
                        Console.WriteLine("Dovidjenja.");
                        break;
                    case 7:
                        Console.WriteLine("Zauzeto!");
                        break;
                }
                keyInfo = Console.ReadKey(true);
                while (keyInfo.Key != ConsoleKey.Enter)
                {
                    if (keyInfo.Key == ConsoleKey.K)
                    {
                        Console.WriteLine("\n\nK R A J\n\n");
                        return;
                    }
                    keyInfo = Console.ReadKey(true);
                }  
            } while (keyInfo.Key == ConsoleKey.Enter);
        }
    }
}
