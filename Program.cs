using System;

namespace enumprimer
{
    class Program
    {
        enum grupa { prva = 10, druga = 20, treca = 23, cetvrta = 4, peta };
        static void Main(string[] args)
        {
            grupa gr = grupa.druga;
            Console.WriteLine("Grupa \"{0}\" ima {1} clanova", grupa.prva, (int)grupa.prva);
            Console.WriteLine("Grupa \"{0}\" ima {1} clanova", grupa.peta, (int)grupa.peta);
            switch (gr)
            {
                case grupa.prva:
                    Console.WriteLine("Pripada prvoj grupi");
                    break;
                case grupa.druga:
                    Console.WriteLine("Pripada drugoj grupi");
                    break;
                case grupa.treca:
                    Console.WriteLine("Pripada drugoj grupi");
                    break;
                case grupa.cetvrta:
                    Console.WriteLine("Pripada drugoj grupi");
                    break;
                case grupa.peta:
                    Console.WriteLine("Pripada drugoj grupi");
                    break;

            }
            Console.WriteLine("Ponedeljkom su prva i druga grupa");
            Console.WriteLine("Ponedeljkom obezbediti {0} pribora ", (int)grupa.prva + (int)grupa.druga);
        }
    }
}
