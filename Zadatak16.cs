using System;

namespace StructPrimer
{
    class Program
    {
        struct Tacka
        {
            public int x;
            public int y;
        };
        static void Main(string[] args)
        {
            Tacka tacka1, tacka2;
            double rast;
            Console.WriteLine("Unesi koordinate prve tacke:");
            Console.Write("X1: ");
            tacka1.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1: ");
            tacka1.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi koordinate druge tacke:");
            Console.Write("X2: ");
            tacka2.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2: ");
            tacka2.y = Convert.ToInt32(Console.ReadLine());
            rast = Math.Sqrt(Math.Pow((tacka2.x - tacka1.x), 2) + Math.Pow((tacka2.y - tacka1.y), 2));
            Console.WriteLine("Ratojanje je: {0:f3}",rast);

        }
    }
}
