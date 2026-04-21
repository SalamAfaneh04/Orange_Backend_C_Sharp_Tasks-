using Lucene.Net.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Function_3
{
    internal class Program
    {
        //1
        static int add(int a, int b)
        {
            return a + b;
        }

        //2
        static string removeLeadingTrailing(string num)
        {
            if (num.Contains('.'))
            {
                num = num.TrimStart('0').TrimEnd('0').TrimEnd('.');
            }
            else
            {
                num = num.TrimStart('0');
            }
            return num;

        }

        //3
        static int secondLargest(int[] arrOfNum)
        {
            return arrOfNum.OrderByDescending(x => x).ElementAt(1);
        }

        //4
        static bool isRepdigit(int num)
        {
            int lastDigit = num % 10;
            if (num < 0)
            {
                return false;
            }
            while (num > 0)
            {
                if (num % 10 != lastDigit)
                {
                    return false;
                }
                num /= 10;
            }
            return true;
        }

        //5
        static string reverseWords(string str)
        {
            string[] revese = str.Split(' ');
            revese = revese.Reverse().ToArray();
            str = string.Join(" ", revese);

            return str;
        }

        //6
        static string sevenBoom(int[] numbers)
        {
            if (numbers.Contains(7))
            {
                return "Boom!";
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].ToString().Contains('7'))
                {
                    return "Boom!";
                }
            }
            
            return "there is no 7 in the array";
        }
        
        //7
        static string insertWhitespace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]) && i != 0)
                {
                    if (char.IsLower(str[i - 1]))
                    {

                        str = str.Insert(i, " ");
                        i++;

                    }
                }
            }
            return str;
        }

        //8
        static int countTrue(string[] str)
        {
            int count = 0;
            foreach (string s in str) 
            {
                if (s.ToLower() == "true")
                {
                    count++;
                }
            }
            return count;
        }

        //9
        static string capToFront(string str)
        {
            string upper = "";
            string lower = "";
            foreach(char c in str)
            {
                if (char.IsUpper(c))
                {
                    upper = upper + c;
                }else if (char.IsLower(c))
                {
                    lower = lower + c;
                }
            }
            return upper+lower;
        }

        //10 
        static bool matchLastItem(string[] arr)
        {
            string allValuesWithoutLast = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                allValuesWithoutLast += arr[i];
            }
            return arr[arr.Length - 1] == allValuesWithoutLast;
        }

        //11
        static int findNaN(double[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (double.IsNaN(num[i]))
                {
                    return i;
                }
            }
            return -1;
        
        }

        //12
        static List<string> removeDups(string[] str)
        {
            List<string> result = new List<string>();
            foreach (string s in str)
            {
                if (!result.Contains(s))
                {
                    result.Add(s);
                }
            }
            return result;
        }

        //13
        static string convertTime(string time)
        {
            int hour = int.Parse(time.Substring(0, 2));
            int minute = int.Parse(time.Substring(3, 2));
            int secound = int.Parse(time.Substring(6, 2));
            string amPm = time.Substring(8, 2);
            if (amPm == "PM" && hour != 12)
            {
                hour += 12;
            }
            else if (amPm == "AM" && hour == 12)
            {
                hour = 0;
            }
            return $"{hour}:{minute}:{secound}";
        }

        //14
        static string removeLastVowel(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                foreach(char c in words[i])
                {
                    if ("aeiouAEIOU".Contains(c))
                    {
                        int lastVowelIndex = words[i].LastIndexOf(c);
                        words[i] = words[i].Remove(lastVowelIndex, 1);
                        break;
                    }
                }
            }
            str = string.Join(" ", words);
            return str;
        }

        //15
        static int sumOfCubes(int[] num)
        {
            int sum = 0;
            foreach (int n in num)
            {
                sum += n * n * n;
            }
            return sum;
        }


        static void Main(string[] args)
        {            
        }
    }
}
