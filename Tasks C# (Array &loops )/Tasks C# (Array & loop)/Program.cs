using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks_C___Array___loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 :  Analyze an Array with Loops

            //Objective: Practice using loops to analyze and manipulate an array.

            //Instructions:

            //Write a program that:

            //1. Creates an array of integers.
            //2. Uses a loop to:
            //    - Count how many numbers are **even**.
            //    - Count how many numbers are **odd**.
            //    - Calculate the **sum** of all numbers.
            //3. Then, use another loop to create a **new array** that contains only the numbers greater than the average.
            //4. Print:
            //    - The number of even values
            //    - The number of odd values
            //    - The total sum
            //    - The average
            //    - The new filtered array

            //Example Input:

            //[10, 15, 22, 7, 8, 13, 30]

            //Expected Output:

            //Even count: 4
            //Odd count: 3
            //Sum: 105
            //Average: 15
            //Filtered array: [22, 30]

            int[] arrOfNumbers = new int[] { 10, 15, 22, 7, 8, 13, 30 };
            int countEven = 0;
            int countOdd = 0;
            int sum = 0;
            int average;
            int[] numbersAboveAverage = new int[arrOfNumbers.Length];

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if (arrOfNumbers[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
                sum += arrOfNumbers[i];
            }

            average = sum / (countEven + countOdd);

            for (int i = 0, j = 0; i < arrOfNumbers.Length; i++)
            {
                if (arrOfNumbers[i] > average)
                {
                    numbersAboveAverage[j] = arrOfNumbers[i];
                    j++;
                }
            }

            Console.WriteLine($"Count of even numbers: {countEven}");
            Console.WriteLine($"Count of odd numbers: {countOdd}");
            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine($"Average of numbers: {average}");
            Console.Write("Numbers above average(Filtered array):");
            for (int i = 0; i < numbersAboveAverage.Length; i++)
            {
                if (numbersAboveAverage[i] != 0)
                {
                    Console.Write($" {numbersAboveAverage[i]}, ");
                }
            }



            //Task 2 :  Find the Largest Number in an Array

            //**Objective:** Use a loop to find the maximum value in an array.

            //**Instructions:**

            //Write a program that:

            //1. Creates an array of numbers.
            //2. Uses a loop to compare all elements.
            //3. Finds and prints the largest number in the array.

            //**Example Input:**

            //[12, 45, 7, 23, 56, 19]

            //**Expected Output:**

            //56

            int[] arrOfNumbers2 = new int[] { 12, 45, 7, 23, 56, 19 };
            int largestNumber = arrOfNumbers2[0];

            for (int i = 1; i < arrOfNumbers2.Length; i++)
            {
                if (arrOfNumbers2[i] > largestNumber)
                {
                    largestNumber = arrOfNumbers2[i];
                }
            }
            Console.WriteLine($"\nLargest number: {largestNumber}");

            // Task 3

            //Using a loop:

            //-Print numbers from 1 → 10
            //- Print only even numbers

            Console.WriteLine("\nEven numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }

            // Task 4: Data Conversion Using `Convert`

            //🎯 Objective

            //Practice converting user input from * *string * *to different data types using the `Convert` class.

            //📝 Task Description

            //Write a C# program that asks the user to enter the following information:

            //1. Full Name
            //2. Age
            //3. Height(in meters, e.g., 1.75)
            //4. Is Employed(true / false)

            // ⚙️ Requirements

            //- Use `Console.ReadLine()` to get input from the user
            //- Use `Convert` methods to convert data into:
            //    - `int` (for age)
            //    - `double` (for height)
            //    - `bool` (for employment status)
            //- Print all the information in a clear format

            //📌 Expected Output Example

            //Enter your full name: Ahmad Ali
            //Enter your age: 22
            //Enter your height: 1.75
            //Are you employed(true/false) : true

            //--- User Profile ---
            //Name: Ahmad Ali
            //Age: 22
            //Height: 1.75
            //Employed: True
            // 🚀 Bonus Challenge (Optional)

            //- Add error handling using `try-catch`
            //- If the user enters invalid data, show a friendly error message instead of crashing

            string fullName;
            int age;
            double height;
            bool isEmployed;

            try
            {
            Console.Write("\nEnter your full name: ");
            fullName = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Are you employed(true/false) : ");
            isEmployed = Convert.ToBoolean(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter the correct data type.");
                return;
            }

            Console.WriteLine("\n--- User Profile ---");
            Console.WriteLine($"Name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Employed: {isEmployed}");


            //Task 5 – Strings

            //🎯 Objective

            //Practice working with strings and their operations in C#.

            // 📝 Task Description

            //Write a C# program that:

            // ❓ Requirements

            //1️⃣ Ask the user to enter their name

            //2️⃣ Convert the name to:

            //-Upper case
            //-Lower case

            //3️⃣ Ask the user to enter their age

            //4️⃣ Print a sentence using:

            //-Concatenation
            //- String Interpolation

            //5️⃣ Print the **first letter** of the name

            //6️⃣ Print the following format using special characters:

            //Name: Ahmad
            //Age: 22

            //🚀 Bonus Challenge

            //-Print the** last letter** of the name
            //-Add a tab between "Name" and the value using `\t`

            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();
            name.ToLower();
            name.ToUpper();

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Using Concatenation: " + "Name: " + name + ", Age: " + userAge);

            Console.WriteLine($"First character of the name: {name[0]}");

            Console.WriteLine("Name:\t" + name + "\nAge: " + userAge);

            Console.WriteLine($"Last character of the name: {name[name.Length - 1]}");


            //Task – Break & Continue

            //🎯 Objective

            //Practice controlling loops using `break` and `continue`.

            // 📝 Task Description

            //Write a C# program that:

            //1.Loops from 1 to 10
            //2.Skips printing** numbers divisible by 3 * * using `continue`
            //3.Stops the loop completely if the number** reaches 8 * * using `break`

            // 📌 Expected Output

            //1
            //2
            //4
            //5
            //7

            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
