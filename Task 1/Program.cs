using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        //1
        static void convertMinToSec(int min)
        {
            Console.WriteLine(min * 60);
        }

        //2
        static int incrematByOne(int num)
        {
            return num + 1;
        }

        //3
        static int firstElementOnArray(int[] arr)
        {
            return arr[0];
        }

        //4
        static double areaOfTriangle(double baseLength, double height)
        {
            return baseLength * height * .5;
        }

        //5
        static List<int> evenNumberEvenIndex(int[] arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i+=2)
            {
                if (arr[i] % 2 == 0)
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }

        //6
        static string[] evenIndexOddLength(string[] arr)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < arr.Length; i+=2)
            {
                if (arr[i].Length % 2 != 0)
                {
                    result.Add(arr[i]);
                }
            }
            return result.ToArray();
        }

        //7
        static int[] powerElementIndex(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = (int)Math.Pow(arr[i], i);
            }
            return result;
        }

        //8
        static int multiplication2(int a, int b)
        {
            return a * b;
        }

        //9
        static int muti2(int a, int b)
        {
            int result = 1;
            for (int i = a; i <= b; i++)
            {
                result *= i;
            }
            return result;
        }

        //10
        static double aveArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }

        static void Main(string[] args)
        {
           

        }
    }
}
