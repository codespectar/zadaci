/*

Napisati program koji ispituje broj parnih i neparnih brojeva u skupu. Skup se zadaje sa unosom: 2,3,6,45,55,111,0,34,4,2,5

 */

using System;

namespace Zadatak12
{
	class Program
	{
		static void Main(string[] args)
		{
			int brojParnih = 0;
			int brojNeparnih = 0;
			int[] brojevi = /*new int[]*/ { 2, 3, 6, 45, 55, 111, 0, 34, 4, 2, 5 };
						
			foreach (int i in brojevi)
			{
				if (i == 0)
					continue;
				if (i%2==0)				
					brojParnih++;
				else
					brojNeparnih++;

			}

			Console.WriteLine("Broj parnih je: " + brojParnih + ".");
			Console.WriteLine("Broj neparnih je: " + brojNeparnih + ".");

		}
	}
}
