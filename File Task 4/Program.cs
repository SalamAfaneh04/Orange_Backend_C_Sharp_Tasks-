using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Task_4
{
    internal class Program
    {
        //Task 1
        static void SumAndAvg(int num1, int num2, int num3,int num4, int num5, int num6, int num7, int num8, int num9, int num10)
        {
            int sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            double avg = sum / 10.0;
            Console.WriteLine($"Sum is : {sum}, Avg is : {avg}");
        }

        //Task 2
        static void Cube(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} and cube of the {i} is :" + (i * i * i));
            }
        }

        //Task3
        static int[] getYears(int[] years)
        {
            List<int> result = new List<int> () ;
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    result.Add(year);
                }
            }
            return result.ToArray();
        }

        //Task 4
        static string AgeInDays(int ageInYear) 
        {
            return $"Age in days is {ageInYear * 365}";
        }

        //Task 5
        static int numOfLages(int chickens, int cows, int pigs)
        {
            return (chickens * 2) + (cows * 4)+ (pigs * 4);
        }

        //Task 6
        string LoginFalied (string userName, string password)
        {
            if (userName == "Salam" && password == "123456G")
            {
                return "Pass";
            }
            return "failed";
        }

        //Task 7
        static int Power (int baseNum , int power)
        {
            int total = baseNum;
            for (int i = 0; i < power; i++)
            {
                total *= baseNum;
            }
            return total;
        }

        //Task 8
        static void LeapYear(int year)
        {
            if (year >= 2024 && year<= 1900)
            {
                if(year %4 == 0)
                {
                    Console.Write("This year is Leap");
                }
            }
        }

        //Task 9
        static bool IsPrime(int n)
        {
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (n% i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Task 10
        static int numOfWords(string statement)
        {
            string[] words = statement.Split(' ');
            return words.Length;
        }

        static void Main(string[] args)
        {

        }
    }
}
