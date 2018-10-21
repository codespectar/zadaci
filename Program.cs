using System;

namespace UbaciElemUNiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int pos = 0;
            int item = 0;

            Console.WriteLine("Enter numbers of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            //Read numbers into array
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[" + (i) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());

            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());

            Array.Resize<int>(ref arr, arr.Length + 1);

            //Perform shift opearation
            for (i = arr.Length - 1; i >= pos; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[pos - 1] = item;

            //print array after insertion
            Console.WriteLine("Array elements after insertion : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element[" + i + "]: " + arr[i]);
            }
            Console.WriteLine();
        }
    }
}
