using System;

namespace MetodiMatrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj redova n : \n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesi broj kolona m : \n");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] x = new int[n, m];
            UnosMatrice(x);
            PrikazMatrice( x);
            Postoji(x);
        }
        //Metode
        static void UnosMatrice(int[,] x)
        {
            Console.Write("Unesi elmente matrice.\n");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("\tElement[" + i + "," + j + "]: ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void PrikazMatrice(int[,] x)
        {
            Console.Write("Ispis matrice.\n");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.WriteLine("\tElement[" + i + "," + j + "]: {0} ", x[i, j]);
                }
            }
        }

        static void Postoji(int[,] x)
        {
            Console.Write("Koji broj treba da postoji : \n");
            int p = Convert.ToInt32(Console.ReadLine());
            foreach (int element in x)
                if (p == element)
                {
                    Console.WriteLine("Broj {0} postoji u matrici.", element);
                }
                else
                {
                    Console.WriteLine("Broj {0} ne postoji u matrici.", element);
                }

        }
    }
}
