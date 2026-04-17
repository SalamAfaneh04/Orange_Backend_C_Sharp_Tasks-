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
            // 1️ ZigZag Numbers

            //Write a program to print numbers in zigzag pattern.

            //**Input:**

            //n = 5

            //**Output:**

            //1
            //21
            //123
            //4321
            //12345

            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

            //2 Mirror Number Pattern

            //Write a program to print mirrored numbers.

            //Input:

            //n = 4

            //Output:**

            //1   1
            //12 21
            //123321
            //12344321


            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                if (i == 1)
                {
                    Console.Write(new string(' ', 3));
                }
                else if (i == 2)
                {
                    Console.Write(new string(' ', 1));
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }



            //3 Centered Number Pyramid

            //Write a program to print centered pyramid with numbers increasing then decreasing.
            for (int i = 1; i < 5; i++)
            {
                Console.Write(new string(' ', 5 - i));
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            //4 Skip Numbers Pattern

            //Print pattern skipping numbers.

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i * 2; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

            //5 Row Sum Pattern

            //Each row prints sum of previous row.

            int sum = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(sum + " ");
                }
                sum += sum;
                Console.WriteLine();
            }


            //6 Alternating Direction Triangle

            //  Each row reverses direction.

            for (int i = 1; i <= 4; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

            //7 Hollow Pyramid Numbers

            //Numbers only on borders.

            //Input:

            //n = 5

            //Output:

            //    1
            //   1 1
            //  1   1
            // 1     1
            //111111111

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(new string(' ', 5 - i));
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    if (j == 1 || j == i * 2 - 1 || i == 5)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //8 Diagonal Cross Pattern

            //Print X using numbers.

            //Input:

            //n = 5

            //Output:

            //1   1
            // 2 2
            //  3
            // 4 4
            //5   5

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == i || j == 6 - i)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //9 Incremental Blocks

            //Each row repeats number i times but increments globally.

            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.WriteLine();
            }

            // 10 Pattern with Gaps

            //Print pattern with increasing spaces inside.

            //Input:

            //n = 4

            //Output:

            //1 1
            //1  1
            //1   1
            //11111

            for (int i = 1; i < 5; i++)
            {
                Console.Write("1");
                if (i == 4)
                {
                    Console.Write(new string('1', 4));
                    break;
                }
                Console.Write(new string(' ', i));
                Console.Write("1");
                Console.WriteLine();
            }

            // String 1
            string str1 = "aAbbBBcC";
            string newstr1 = "";


            for (int i = 0; i < str1.Length; i = i + 2)
            {
                if (str1[i] == str1[i + 1])
                {
                    newstr1 += str1[i];
                    newstr1 += str1[i + 1];
                }
            }
            Console.WriteLine(str1);
            Console.WriteLine(newstr1);

            //String 2

            string str2 = "Banana";
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char charter in str2)
            {
                if (!charCount.ContainsKey(charter))
                {
                    charCount.Add(charter, 1);
                }
                else
                {
                    charCount[charter]++;
                }
            }

            foreach (var item in charCount)
            {
                Console.Write(item.Key);
                Console.Write(item.Value);
            }

            // String 7

            string str7 = "abcDeFF";
            string newstr7 = "";

            foreach (char c in str7)
            {
                char C = (char)(c + 1);
                newstr7 = newstr7 + C;
            }
            Console.WriteLine(str7);
            Console.WriteLine(newstr7);

            //Array 7
            int[] arr7 = { 5, 7, 10 };
            int[] newarr7 = new int[arr7.Length];
            newarr7[0] = arr7[0];

            for (int i = 1; i < arr7.Length; i++)
            {
                newarr7[i] = arr7[i] - arr7[i - 1];
            }

            foreach (int item in newarr7)
            {
                Console.Write(item + " ");
            }

            //5 Reverse Only Letters

            // اعكس فقط الحروف واترك الرموز مكانها

            //Input:

            //"a-bC-dEf-ghIj"

            //Output:

            //"j-Ih-gfE-dCba"

            string str5 = "a-bC-dEf-ghIj";
            char[] arr5 = str5.ToCharArray();
            for (int i = 0, j = str5.Length - 1; i < j;) { 
                if (!char.IsLetter(arr5[i]))
                {
                    i++;
                }
                else if (!char.IsLetter(arr5[j]))
                {
                    j--;
                }
                else
                {
                    char temp = arr5[i];
                    arr5[i] = arr5[j];
                    arr5[j] = temp;
                    i++;
                    j--;
                }
            }
            Console.WriteLine(str5);
            Console.WriteLine(arr5);
        }
    }
}
