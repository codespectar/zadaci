/*
 Napisati program koji sabira sve brojeve deliive sa 4 a manje od 1000
 */

using System;

namespace Zadatak6
{
	class Program
	{
		static void Main(string[] args)
		{
			int suma = 0;

			for (int i = 1; i < 1000; i++)
			{
				if (i % 4 == 0)
					suma = suma + i;

			}
			//Primena konkatenacije
			Console.WriteLine("\nSuma je " + suma + ".");
		}
	}
}
