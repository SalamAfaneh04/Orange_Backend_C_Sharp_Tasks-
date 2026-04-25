using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Task_5
{
    //Task 1
    public class MyClass 
    {
        public MyClass()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
    }

    //Task 2
    public class MyClass2
    {
        private string value = "Scott";
        public MyClass2()
        {
            Console.WriteLine($"Hello All, I am {value}");
        }
    }

    //Task 3
    public class Fraction
    {
        private int result = 1;
        public Fraction(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine($"The factorial of {num} is {result}");
        }
    }
    //Task 4,5,6 Repeted in privous Tasks

    internal class Program
    {

           static void Main(string[] args)
        {

        }
    }
}
