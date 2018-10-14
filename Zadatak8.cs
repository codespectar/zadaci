/*
 
Napisati program koji sabira proste brojeve u intervalu od 1 do 100. Koristiti funkciju koja proverava da li je broj prost.


 */

using System;

namespace Zadatak8
{
	class Program
	{

		public static bool JeProst(int number)
		{
			if (number <= 1) return false;
			if (number == 2) return true;

			for (int i = 2; i < number; i++)
			{
				if (number % i == 0) return false;
			}
			return true;
		}

		static void Main(string[] args)
		{
			int suma = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (JeProst(i) == true)
				{
					Console.WriteLine("Broj je prost " + i + ".");
					suma = suma + i;
				}

			}
			
			Console.WriteLine("\nSuma je " + suma + ".");
		}
	}
}
