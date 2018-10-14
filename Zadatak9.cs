/*
 
Napisati program koji sabira prvih 100 prostih brojeva. Koristiti funkciju koja proverava da li je broj prost.

 */

using System;

namespace Zadatak9
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
			int brojacBrojeva = 0;
			int suma = 0;
			for (int i = 1; brojacBrojeva < 100; i++)
			{
				if (JeProst(i) == true)
				{
					// Console.WriteLine("Prost je " + i + ".");
					brojacBrojeva++;
					suma = suma + i;
				}

			}
			
			Console.WriteLine("\nSuma je " + suma + ".");
			
		}
	}
}
