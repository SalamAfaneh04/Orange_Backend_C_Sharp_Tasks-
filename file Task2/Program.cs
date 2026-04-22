using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_Task2
{
    internal class Program
    {
        //1
        static int smallNumber(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //2
        static char signOfNumber(int a)
        {
            if (a > 0)
            {
                return '+';
            }
            else if (a < 0)
            {
                return '-';
            }
            else
            {
                return '0';
            }
        }

        //3
        static void order(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                    if (b > c)
                    {
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    else
                    {
                        Console.WriteLine(c);
                        Console.WriteLine(b);
                    }
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }
            else if (b > c)
            {
                Console.WriteLine(b);
                if (a > c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine(c);
                if (a > b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }

            }
        }

        //4
        static void maxNum(int num1, int num2, int num3, int num4, int num5)
        {
            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                Console.WriteLine(num2);
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            {
                Console.WriteLine(num3);
            }
            else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                Console.WriteLine(num4);
            }
            else
            {
                Console.WriteLine(num5);
            }
        }

        //5
        static double convertKiloTomiles(double kilo) 
        {
            return (kilo * 0.621371192);
        }

        //6
        static int totalMin(int hours, int min)
        {
            return (hours * 60 + min);
        }

        //7
        static string timeInHoursAndMin(int totalMin)
        {
            int hours = totalMin / 60;
            int min = totalMin % 60;
            return $"{hours} hours and {min} minutes";
        }

        //8
        static void statmentInTheSameLength(string[] statments)
        {
            foreach (string statment in statments)
            {
                string newStatment = statment.Substring(0,6);
                Console.WriteLine(newStatment);
            }
        }

        //9
        static void reveseOddLength(string statments)
        {
            string[] strings = statments.Split(' ');
            foreach (string statment in strings)
            {
                if (statment.Length % 2 != 0)
                {
                    char[] charArray = statment.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine(new string(charArray));
                }
                else
                {
                    Console.WriteLine(statment);
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
