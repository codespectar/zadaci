/*
 Napisati program koji sabira prvih 100 brojeva deljivih sa 5
  
 */

using System;

namespace Zadatak5
{
	class Program
	{
		static void Main(string[] args)
		{
			int brojacBrojeva = 0;
			int suma = 0;

			for (int i = 1; brojacBrojeva < 100; i++)
			{
				if (i % 5 == 0)
				{
					brojacBrojeva++;
					suma = suma + i;
					//Console.WriteLine("\nBrojac " + brojacBrojeva + "/" + "Suma je " + suma + ".");
					
				}

			}
			//Suma
			Console.WriteLine("\nSuma je " + suma + ".");
		}
	}
}
