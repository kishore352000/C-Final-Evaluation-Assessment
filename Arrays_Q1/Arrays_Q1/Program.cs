using System;

namespace Arrays_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int n, min, max, i;
            Console.WriteLine("Enter number of elements in the array=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + n+ " "+ "elements in the array");
            for (i = 0; i < n; i++)
            {
                Console.Write(" element"+" " +i+" " +"=");
                arr[i] = int.Parse(Console.ReadLine());

            }
            min = arr[0];
            max = arr[0];
            for (i = 1; i < n; i++)
            {
                if ( arr[i]<min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The maximum element in the array is" + max);
            Console.WriteLine("The minimum element in the array is" + min);

        }
    }
}
