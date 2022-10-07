using System;

namespace Math_Q5
{
    class Program
    {
            int fa=1;
            void factorial(int f)
            {
                for (int i = 1; i <= f; i++)
                {
                    fa = fa * i;

                }
                Console.WriteLine("Factorial =" + fa);
            Console.WriteLine("The table is");
            }
           
            void table(int t)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} X {1} = {2} \n", t, j, t * j);
                }
            }
        static void Main(string[] args)
        {
            Program p = new Program();
            int n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            p.factorial(n);
            p.table(n);

        }
    }
}
