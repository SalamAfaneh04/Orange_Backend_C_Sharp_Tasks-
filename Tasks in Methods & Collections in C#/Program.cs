using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks_in_Methods___Collections_in_C_
{
    internal class Program
    {
        //Task 1 – Method

        //Create a method:

        //-Name: `CalculateAverage`
        //-Takes 3 numbers
        //- Returns the average

        static double CalculateAverage(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }

        static void Main(string[] args)
        {
            //Task 2 – List
            //Create a list of **student names**:
            //- Add 5 names
            //- Print all names
            //- Remove one name

            List<string> studentNames = new List<string>();
            studentNames.Add("Salam");
            studentNames.Add("Ali");
            studentNames.Add("Salma");
            studentNames.Add("Salwa");
            studentNames.Add("Omar");

            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }

            studentNames.Remove("Ahmed");

            //Task 3 – Dictionary

            //Create a dictionary:

            //-Key: `int`
            //-Value: `string`
            //-Store 3 users(ID → Name)
            //- Print all users

            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1, "Salam");
            users.Add(2, "Ali");
            users.Add(3, "Salma");

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Key}, Name: {user.Value}");
            }

            // Task 4 – LINQ

            //🎯 Objective

            //Practice using ** LINQ**to filter, sort, and manipulate data from arrays.
            // 📝 Task Description

            //Create a C# program that uses **LINQ** to perform the following operations on an array.

            // 📌 Given Data

            //csharp
            //int[] numbers = { 5, 10, 15, 20, 25, 30 };
            //string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

            //Questions
            //1 Filter Numbers

            //-Get all numbers greater than 15 using LINQ
            //-Print the result

            // 2️ Even Numbers

            //-Get all even numbers from the array
            //-Print them

            // 3️ Sorting

            //-Sort the numbers in ascending order
            //-Then sort them in descending order

            //4️ Names Filtering

            //-Get all names that start with the letter * *'A' * *
            //-Print the result

            //5 First Value

            //-Get the first number greater than 10 using `FirstOrDefault()`

            //Bonus Challenge (Optional)

            //-Use `Select()` to create a new array where each number is multiplied by 2
            //- Print the new values

            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

            var greaterThan15 = numbers.Where(n => n > 15);
            foreach (var number in greaterThan15)
            {
                Console.WriteLine(number);
            }

            var evenNum = numbers.Where(n => n % 2 == 0);
            foreach (var number in evenNum)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Ascending:");
            var ascending = numbers.OrderBy(n => n);
            foreach (var number in ascending)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Descending:");
            var descending = numbers.OrderByDescending(n => n);
            foreach (var number in descending)
            {
                Console.WriteLine(number);
            }

            var namesStartingWithA = names.Where(name => name.StartsWith("A"));
            foreach (var name in namesStartingWithA)
            {
                Console.WriteLine(name);
            }

            var firstGreaterThan10 = numbers.FirstOrDefault(n => n > 10);
            Console.WriteLine($"First number greater than 10: {firstGreaterThan10}");


            var multipliedBy2 = numbers.Select(n => n * 2);
            Console.WriteLine("Numbers multiplied by 2:");
            foreach (var number in multipliedBy2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
