using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Tasks____Methods_List_LINQ_LinkedList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Even Numbers Filter

            //Scenario:

            //You have a list of numbers.You need to extract only even numbers.


            //Requirements:

            //-Create a `List<int>`
            //-Use * *LINQ * *
            //-Store even numbers in a new list

            Console.WriteLine("Task 1: Even Numbers Filter");

            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(string.Join(", ", list1));

            list1 = list1.Where(x => x % 2 == 0).ToList();

            Console.WriteLine("Even numbers: " + string.Join(", ", list1));

             //Task 2: Remove Duplicates

            //Scenario:

            //A list contains duplicate numbers. Clean the list.
            

            //* *Requirements:**

            //-Use `List<int>`
            //-Remove duplicates using LINQ

            Console.WriteLine("Task 2: Remove Duplicates");

            List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 3, 7, 8, 8, 10 };
            Console.WriteLine(string.Join(", ", list2));

            list2 = list2.Distinct().ToList();
            Console.WriteLine(String.Join(", ", list2));

            //Task 3: Find Maximum Number

            //**Scenario:**

            //You want to find the highest number in a list.

            //Requirements:

            //-Use `List<int>`
            //-Use LINQ(Max)

            Console.WriteLine("Task 3: Find Maximum Number");
            Console.WriteLine(string.Join(", ", list2));
            Console.WriteLine(list2.Max());

            //Task 4: Reverse List

            //Scenario:

            //Reverse the order of elements.

            //Requirements:

            //-Use built -in method OR loop

            Console.WriteLine("Task 4: Reverse List");
            Console.WriteLine(string.Join(", ", list2));
            list2.Reverse();
            Console.WriteLine(string.Join(", ", list2));

            //Task 5: Count Numbers Greater Than X

            //Scenario:

            //Count how many numbers are greater than 50.

            //Requirements:

            //-Use LINQ Count

            Console.WriteLine("Task 5: Count Numbers Greater Than 50");
            List<int> list3 = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine(string.Join(", ", list3));
            int countGreaterThan50 = list3.Count(x => x > 50);
            Console.WriteLine("Numbers greater than 50: " + countGreaterThan50);

            //Task 6: Student Scores

            //Scenario:

            //Store student names with their scores.
           
            //Requirements:

            //-Use `Dictionary<string, int>`
            //-Print all students with score > 80

            Console.WriteLine("Task 6: Student Scores");
            Dictionary<string, int> studentScores = new Dictionary<string, int>
            {
                { "Salam", 85 },
                { "Ali", 78 },
                { "Maryam", 92 },
                { "Mohammad", 65 },
                { "Abdalleh", 88 }
            };

            studentScores.Where(s => s.Value > 80)
                         .ToList()
                         .ForEach(s => Console.WriteLine($"{s.Key}: {s.Value}"));

            //Task 7: Search by Key

            //Scenario:

            //User enters a name → return the score.

            //Requirements:

            //-Use `ContainsKey`
            //-Print result or "Not found"

            Console.WriteLine("Task 7: Search by Key");
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            if (studentScores.ContainsKey(name))
            {
                Console.WriteLine($"{name}: {studentScores[name]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }


            //Task 8: Sum of Values

            //Scenario:

            //Calculate total scores.

            //Requirements:

            //-Use LINQ Sum on values

            Console.WriteLine("Task 8: Sum of Values");
            int totalScore = studentScores.Values.Sum();
            Console.WriteLine("Total scores: " + totalScore);


            //Task 9: Remove Low Scores

            //Scenario:

            //Remove students with score < 50

            Console.WriteLine("Task 9: Remove Low Scores");
            var lowScoreStudents = studentScores.Where(s => s.Value < 50).Select(s => s.Key).ToList();
            foreach (var student in lowScoreStudents)
            {
                studentScores.Remove(student);
            }
            Console.WriteLine("Students with score >= 50:");
            studentScores.ToList().ForEach(s => Console.WriteLine($"{s.Key}: {s.Value}"));

            //Task 10: Highest Score

            //Scenario:

            //Find student with highest score
            List<int> numbers = new List<int> { 3, 150, 7, 200, 2, 8, 45, 101, 60, 11 };

            Console.WriteLine("Task 10: Highest Score");
            var highestScoreStudent = studentScores.OrderByDescending(s => s.Value).FirstOrDefault();
            Console.WriteLine($"Highest score: {highestScoreStudent.Key} with {highestScoreStudent.Value}");

            // Task 16: Odd Numbers
            var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
            Console.WriteLine("Task 16 - Odd Numbers:");
            Console.WriteLine(string.Join(", ", oddNumbers));

            // Task 17: Multiply All Numbers by 2
            var multiplied = numbers.Select(n => n * 2).ToList();
            Console.WriteLine("\nTask 17 - Multiply All by 2:");
            Console.WriteLine(string.Join(", ", multiplied));

            // Task 18: Sort Descending
            var sortedDesc = numbers.OrderByDescending(n => n).ToList();
            Console.WriteLine("\nTask 18 - Sort Descending:");
            Console.WriteLine(string.Join(", ", sortedDesc));

            // Task 19: First Number Greater Than 100
            var firstOver100 = numbers.FirstOrDefault(n => n > 100);
            Console.WriteLine("\nTask 19 - First Number > 100:");
            Console.WriteLine(firstOver100);




        }
    }
}


