using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function2
{
    internal class Program
    {

        //1
        static double getDays(DateTime date1, DateTime date2)
        {
            TimeSpan difference = date2 - date1;
            return difference.TotalDays;
        }

        //2
        static string[] stringWithNum(string[] arr)
        {
            List<string> result = new List<string>();
            foreach (string str in arr)
            {
                if (str.Any(char.IsDigit))
                {
                    result.Add(str);
                }
            }
            return result.ToArray();
        }

        //3
        static string reverseOdd(string str)
        {
            if (str.Length % 2 != 0)
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            else
            {
                return str;
            }
        }

        //4
        static bool isPandigital(long number)
        {
            string numStr = number.ToString();
            for (char digit = '0'; digit <= '9'; digit++)
            {
                if (!numStr.Contains(digit))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
