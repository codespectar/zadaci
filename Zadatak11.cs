/*
Napisati program koji odredjuje hipotenuzu pravouglog trougla za katete 3 i 4.

 */

using System;

namespace Zadatak11
{
	class Program
	{
		static void Main(string[] args)
		{
			float a = 3;
			float b = 4;

			float c = (float) Math.Sqrt(b * b + a * a);

			Console.WriteLine("Treca stranica je: " + c  );
			// 23596
		}
	}
}
