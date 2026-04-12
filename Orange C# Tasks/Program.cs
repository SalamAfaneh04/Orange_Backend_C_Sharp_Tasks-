using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Orange_C__Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            //Create a program that:

            //-Stores your name
            //-Stores your age
            //-Prints a message:

            //My name is Ahmad and I am 25 years old

            string yourName = Console.ReadLine();
            int yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("My name is " + yourName + " and I am " + yourAge + " years old.");

            //Task 2

            //Write a program that:

            //-Takes a number from user
            //-Checks if number is **even or odd

            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            //Task 3

            //Create console application that read string from user and print the same string

            string text = Console.ReadLine();

            Console.WriteLine(text);


            //Task 4

            //Write a C# program that checks if a number is positive, negative, or zero using `if`.

            double checkPositiveNum = Convert.ToDouble(Console.ReadLine());

            if (checkPositiveNum == 0)
            {
                Console.WriteLine("Zero num");
            }
            else if (checkPositiveNum > 0)
            {
                Console.WriteLine("Positive num");
            }
            else
            {
                Console.WriteLine("Negative num");
            }


            //Task 5

            //Write a program that checks if a year is a leap year using if

            int yesr = Convert.ToInt32(Console.ReadLine());

            if (yesr % 4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }


            //Task 6 

            //Create a program that takes a student's grade and prints "Pass" or "Fail" using `if`.

            int markOfStudent = Convert.ToInt32(Console.ReadLine());

            if (markOfStudent >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            //Task 7 

            //Write a program that finds the أكبر رقم بين رقمين باستخدام `if`.

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }

            //Task 8 

            //Write a program that checks if a number is divisible by 5 and 3 using `if`.

            double checkNumIfDivBy3And5 = Convert.ToDouble(Console.ReadLine());

            if (checkNumIfDivBy3And5 % 3 == 0 && checkNumIfDivBy3And5 % 5 == 0)
            {
                Console.WriteLine("Num Div By 3 & 5");
            }
            else
            {
                Console.WriteLine("Num Not Div By 3 & 5");
            }


            //Task 9 

            //Create a program that checks if a character is a vowel or consonant using `if`.

            char checkChar = Convert.ToChar(Console.ReadLine().ToLower());

            if (checkChar == 'a' || checkChar == 'e' || checkChar == 'u' || checkChar == 'o' || checkChar == 'i')
            {
                Console.WriteLine("Vowel Char");
            }
            else
            {
                Console.WriteLine("Not Vowel Char");
            }

            //Task 10 

            //Write a program that takes age as input and determines if the person is a child, teenager, or adult using `if`.

            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 19)
            {
                Console.WriteLine("Adult");
            }
            else if (age > 12)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Child");
            }

            //Task 11 

            //Write a C# program that uses `switch` to print the day name based on a number (1–7).

            int dayInNumbers = Convert.ToInt32(Console.ReadLine());

            switch (dayInNumbers)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not valid number ");
                    break;

            }

            //Task 12 

            //Create a program using `switch` to display the month name based on user input(1–12).


            int monthInNumbers = Convert.ToInt32(Console.ReadLine());

            switch (monthInNumbers)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;


                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }



            //Task 13

            //Write a program that uses `switch` to perform basic calculator operations(+, -, *, /).

            int number1 = 5;
            int number2 = 8;
            int result;
            char op = '*';

            switch (op)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine($"Result: {number1} + {number2} = {result}");
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine($"Result: {number1} - {number2} = {result}");
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine($"Result: {number1} * {number2} = {result}");
                    break;

                case '/':
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Result: {number1} / {number2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
                    break;
            }

            //Task 14 

            //Create a program that uses `switch` to categorize a grade(A, B, C, D, F).

            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Category: Excellent! You have a top-tier understanding of the material.");
                    break;
                case 'B':
                    Console.WriteLine("Category: Good Job! You have a solid grasp of the concepts.");
                    break;
                case 'C':
                    Console.WriteLine("Category: Satisfactory. You have met the basic requirements.");
                    break;
                case 'D':
                    Console.WriteLine("Category: Below Average. You may need to review some core topics.");
                    break;
                case 'F':
                    Console.WriteLine("Category: Failure. Significant improvement and study are required.");
                    break;
                default:
                    Console.WriteLine("Category: Invalid input. Please enter a valid letter grade (A-F).");
                    break;
            }

            //Task 15 

            //Write a program that takes a number(1–3) and prints a message using `switch`.

            int number15 = Convert.ToInt32(Console.ReadLine());

            switch (number15)
            {
                case 1:
                    Console.WriteLine("Number1");
                    break;
                case 2:
                    Console.WriteLine("Number2");
                    break;
                case 3:
                    Console.WriteLine("Number3");
                    break;
                default:
                    Console.WriteLine("another number");
                    break;
            }


            //Task 16 

            //Convert an `if` condition(even / odd check) into a `switch` statement.


            int num16 = Convert.ToInt32(Console.ReadLine());
            switch (num16 % 2 == 0)
            {
                case true:
                    Console.WriteLine("Even");
                    break;
                case false:
                    Console.WriteLine("Odd");
                    break;
            }

            //Task 17 

            //Write a program that checks login role(Admin, User, Guest) using `switch`.

            string role = "Admin";
            switch (role)
            {
                case "Admin":
                    Console.WriteLine("Admin Role");
                    break;
                case "User":
                    Console.WriteLine("User Role");
                    break;
                case "Guest":
                    Console.WriteLine("Guest Role");
                    break;
            }

            //Task 18 

            //Create a menu - driven program using `switch` that lets the user choose different options.

            Console.WriteLine("=== User Dashboard ===");
            Console.WriteLine("1. Show Current Date and Time");
            Console.WriteLine("2. Display a Greeting");
            Console.WriteLine("3. System Status Check");
            Console.WriteLine("4. Exit");
            Console.Write("\nSelect an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"\nCurrent Date/Time: {DateTime.Now}");
                    break;

                case "2":
                    Console.WriteLine("\nHello! We hope you're having a productive coding session.");
                    break;

                case "3":
                    Console.WriteLine("\nSystem Status: All modules are running optimally.");
                    break;

                case "4":
                    Console.WriteLine("\nExiting program... Goodbye!");
                    break;

                default:
                    Console.WriteLine("\nInvalid selection. Please try again.");
                    break;
            }


            //Task 1 

            //A company gives bonuses based on employee performance rating:

            //-90–100 → “Excellent” +20 % bonus
            //- 75–89 → “Very Good” +15 % bonus
            //- 60–74 → “Good” +10 % bonus
            //- Below 60 → “No bonus”

            //Write a program that takes the rating and prints the performance level and bonus.

            int performanceRating = 99;
            if (performanceRating > 89)
            {
                Console.WriteLine("“Excellent” get +20 % bonus");
            }
            else if (performanceRating > 74)
            {
                Console.WriteLine("“Very Good” +15 % bonus");
            }
            else if (performanceRating > 59)
            {
                Console.WriteLine("“Good” +10 % bonus");
            }
            else
            {
                Console.WriteLine("No bonus");

            }



            //Task 2 

            //A student is eligible for university admission if:

            //-GPA ≥ 85 AND has passed English test
            //- OR has a special recommendation

            //Write a program that checks eligibility using `if`.

            int gpa = 87;
            bool passEnglish = false;
            bool specialReco = true;

            if ((gpa >= 85 && passEnglish) || specialReco)
            {
                Console.WriteLine("checks eligibility");
            }
            else
            {
                Console.WriteLine(" No checks eligibility");
            }


            //Task 3 

            //A shipping company calculates delivery cost:

            //-Weight ≤ 1kg → $5
            //- 1–5kg → $10
            //- 5–10kg → $20
            //- Above 10kg → $50 + extra warning “Heavy package”

            //Write a program using `if`.

            double weight = 6;
            if (weight < 1)
            {
                Console.WriteLine("$5");
            }
            else if (weight < 6)
            {
                Console.WriteLine("$10");
            }
            else if (weight < 11)
            {
                Console.WriteLine("$20");
            }
            else
            {
                Console.WriteLine("$50 + extra warning “Heavy package”");

                //}

                //Task 4 

                //A login system checks:

                //-Correct username AND password → “Login successful”
                //-Wrong username OR password → “Invalid credentials”
                //-More than 3 failed attempts → “Account locked”

                //Write a program using `if`.


                bool userNameChecked = true;
                bool passwordChecked = true;
                int timesChecked = 2;

                if (userNameChecked && passwordChecked)
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Invalid credentials");
                }

                if (timesChecked > 3)
                {
                    Console.WriteLine("Account locked");
                }

                //Task 1 

                //A restaurant menu system:

                //-1 → Burger($5)
                //- 2 → Pizza($8)
                //- 3 → Pasta($7)
                //- 4 → Salad($4)

                //User selects an item, print name and price using `switch`.

                int selectItemNum = Convert.ToInt32(Console.ReadLine());

                switch (selectItemNum)
                {
                    case 1:
                        Console.WriteLine("Burger($5)");
                        break;
                    case 2:
                        Console.WriteLine("Pizza($8)");
                        break;
                    case 3:
                        Console.WriteLine("Pasta($7)");
                        break;
                    case 4:
                        Console.WriteLine("Salad($4)");
                        break;

                }


                //Task 2 

                //A university grading system:

                //-A → Excellent
                //- B → Very Good
                //-C → Good
                //- D → Pass
                //- F → Fail
                //Input a grade and display meaning using `switch`.


                char gradeUni = 'A';
                switch (gradeUni)
                {
                    case 'A':
                        Console.WriteLine("Excellent");
                        break;
                    case 'B':
                        Console.WriteLine("Very Good");
                        break;
                    case 'C':
                        Console.WriteLine("Good");
                        break;
                    case 'D':
                        Console.WriteLine("Pass");
                        break;
                    case 'F':
                        Console.WriteLine("Fail");
                        break;
                }



                //Task 3 

                //A simple ATM system:

                //-1 → Check Balance
                //-2 → Deposit Money
                //-3 → Withdraw Money
                //-4 → Exit

                //Use `switch` to simulate menu actions.

                int select = 4;

                switch (select)
                {
                    case 1:
                        Console.WriteLine("Check Balance");
                        break;

                    case 2:
                        Console.WriteLine("Deposit Money");
                        break;
                    case 3:
                        Console.WriteLine("Withdraw Money");
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                }


                //Task 4 

                //A calculator system:

                //-1 → Addition
                //- 2 → Subtraction
                //- 3 → Multiplication
                //- 4 → Division

                //User enters two numbers +operation choice, perform calculation using `switch`.

                Console.WriteLine("--- C# Console Calculator ---");

            // Step 1: Get the numbers from the user
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Step 2: Display the menu
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1 -> Addition");
            Console.WriteLine("2 -> Subtraction");
            Console.WriteLine("3 -> Multiplication");
            Console.WriteLine("4 -> Division");
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            // Step 3: Perform calculation using switch
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;

                case 4:
                    // Handling division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        validOperation = false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select 1, 2, 3, or 4.");
                    validOperation = false;
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
