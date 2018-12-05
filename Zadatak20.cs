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
  class Krug
    {
        private double r;
        public double R
        {
            get {
                Console.Write("get blok");
                return r; }
            set
            {
                Console.Write("set blok");
                if (value > 0) r = value;
                else
                {
                    Exception ex = new Exception("Poluprecnik kruga ne sme biti nula ili negativan!");
                    throw ex;
                }
            }
        }
        public Krug() { }
        public Krug(double r)
        {
            R = r;
        }
        public double Obim()
        {
            return 2 * R * Math.PI;
        }
        public double Povrsina()
        {
            return Math.Pow(R, 2) * Math.PI;
        }
    }
  
  
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
