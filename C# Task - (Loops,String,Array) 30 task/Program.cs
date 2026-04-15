using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__Task____Loops_String_Array__30_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1️ ZigZag Numbers

            ////Write a program to print numbers in zigzag pattern.

            ////**Input:**

            ////n = 5

            ////**Output:**

            ////1
            ////21
            ////123
            ////4321
            ////12345

            //for (int i = 1; i <= 5; i++)
            //{
            //    while()

            //}
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,3} ", num);
            }

        }
    }
}
