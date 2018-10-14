/*
 Napisati program koji izracunava da li je broj prost.


 */

using System;

namespace Zadatak7
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

			//broj
			Console.WriteLine("Unesite broj koji ispitujemo?\n");
			int b = Convert.ToInt32(Console.ReadLine());

			if (JeProst(b)==true)
				Console.WriteLine("\nBroj je prost.");
			else
				Console.WriteLine("\nBroj je slozen.");
		}
	}
}
