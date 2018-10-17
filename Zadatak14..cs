using System;
/*Uneti niz koji se sastoji od imena i prezimena takmičara i niz koji za svakog
takmičara sadrži postignuto vreme u trci (na i-toj poziciji, rezultati i-tog takmičara). Prikazati
rang listu. 
 * */

namespace SortVektor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] takmicari = new string[5];
            int[] poeni = new int[5];
            Console.WriteLine("Unesite ime i prezime takmicara i poene: ");
            for (int i = 0; i < takmicari.Length; i++)
            {
                Console.Write("Ime i prezime: ");
                takmicari[i] = Console.ReadLine();
                Console.Write("Poeni: ");
                poeni[i] = Convert.ToInt32(Console.ReadLine());
            }
     
            Console.WriteLine("Nesortirani vektori");
            for (int j = 0; j < poeni.Length; j++)
            {
                Console.WriteLine("Ime i prezime: " + takmicari[j] + "\tpoeni: " +poeni[j]);
            }
            Array.Sort(poeni, takmicari);
            Console.WriteLine("Sortirani vektori");
            for (int j = 0; j < poeni.Length; j++)
            {
                Console.WriteLine("Ime i prezime: " + takmicari[j] + "\tpoeni: " + poeni[j]);
            }
            Array.Reverse(poeni);
            Array.Reverse(takmicari);
            Console.WriteLine("Reverse");
            for (int j = 0; j < poeni.Length; j++)
            {
                Console.WriteLine("Ime i prezime: " + takmicari[j] + "\tpoeni: " + poeni[j]);
            }
        }
    }
}
