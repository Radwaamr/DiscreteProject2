using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The perfect numbers are :");

            int sum, i, j;
            for (i = n1; i <= n2; i++)
            {
                sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;

                }
                if (sum == i)
                 
                    Console.WriteLine(i);
                
            }

        }
    }
}
