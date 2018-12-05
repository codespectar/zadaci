using System;

/*Klasa Krug:
- Privatno polje r koje predstavlja poluprečnik kruga
- Javno svojstvo za postavljanje i čitanje poluprečnika. Obezbediti da se za
  poluprečnik može uneti samo pozitivna vrednost.
- Default konstruktor klase
- Metod Obim za izračunavanje obima kruga
- Metod Povrsina za računanje površine kruga
* U glavnom programu kreirati krug i prikazati njegov obim i površinu.
 * */

namespace KlasaKrugSaIzuzetkom
{
    class Program
    {
        static void Main(string[] args)
        {
            Krug k1 = new Krug();
            Console.Write("Unesi poluprecnik kruga: ");
            try
            {
                k1.R = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Obim je {0}cm, a povrsina {1}cm^2", k1.Obim(), k1.Povrsina());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.Write("Unesi poluprecnik kruga: ");
            try
            {
                double r = Convert.ToDouble(Console.ReadLine());
                Krug k2 = new Krug(r);
                Console.WriteLine("Obim je {0}cm, a povrsina {1}cm^2", k2.Obim(), k2.Povrsina());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
