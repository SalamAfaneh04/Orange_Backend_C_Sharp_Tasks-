using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface___Exception___try_and_catch__
{
    internal class Program
    {
        // Task – Interface & Exception
        interface ICalculator
        {
            int Add(int a, int b);
        }

        public class Calculator : ICalculator
        {
            public int Add(int a, int b) { return a + b; }
        }




        static void Main(string[] args)
        {
            // Task – Interface & Exception
            try
            {
                Calculator calculator = new Calculator();
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(calculator.Add(num1, num2));

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


            //Task – File Handling & Library
            //Task 1
            try
            {
                File.AppendAllText($"C:\\Users\\salam\\source\\repos\\Orange C# Tasks\\OOP(Interface , Exception , try and catch )\\data.txt", "\nHello World" + Environment.NewLine);

                StreamReader reader = new StreamReader($"C:\\Users\\salam\\source\\repos\\Orange C# Tasks\\OOP(Interface , Exception , try and catch )\\data.txt");
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Task 2
            try
            {
                File.WriteAllText($"C:\\Users\\salam\\source\\repos\\Orange C# Tasks\\OOP(Interface , Exception , try and catch )\\Info.txt",
                    "My Name is Salam, I am 22 years old,\n I work with Orang Coding School as a full stack developer");
                StreamReader reader = new StreamReader($"C:\\Users\\salam\\source\\repos\\Orange C# Tasks\\OOP(Interface , Exception , try and catch )\\Info.txt");
                string line;
                int CharCount = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c != ' ')
                        {
                            CharCount++;
                        }
                    }
                }
                Console.WriteLine("Number of characters (excluding spaces): " + CharCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
