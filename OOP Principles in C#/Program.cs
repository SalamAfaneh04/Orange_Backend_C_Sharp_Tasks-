using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    //Task 1
    static class MathUtilities
    {
        static public int Square(int number)
        {
            return number * number;
        }
        static public double RootSquare(double number)
        {
            return Math.Sqrt(number);
        }
        static public int MaxFromTwoNumbers(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
    }

    public class Converter
    {
        static public double CelToFah(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
            return fahrenheit;
        }

        public static double KiloToMiles(double kilometers)
        {
            double miles = kilometers * 0.621371;
            Console.WriteLine($"{kilometers} km is equal to {miles} miles");
            return miles;
        }
    }

    //Task 3
    public class VisitorCounter
    {
        static private int visitorsCount = 0;
        public VisitorCounter()
        {
            visitorsCount++;
        }
        public static int GetVisitorsCount()
        {
            return visitorsCount;
        }
    }

    //Task 4
    public class Company
    {
        public static string CompanyName { get; set; }
        public string employeeName { get; set; }
    }

    //Task 5
    public class MyMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    
    public class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("Animal Speak");
        }
    }
    public class Cats : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Cat is speak");
        }
    }
    public class Person
    {
        private string name;
        public string Name { set; get; }
    }
    public abstract class Shap
    {
        public abstract double Area();
    }
    public class Rectangle : Shap
    {
        public double width { get; set; }
        public double height { get; set; }
        public override double Area()
        {
            return width * height;
        }
    }

    //Task 6
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }

    //Task 7
    public abstract class  Animals
    {
        public abstract void MakeSound();
    }
    public class Dog : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    //Task 8
    public abstract class Appliance
    {
        public string Brand;
        public abstract void TurnOn();
        public abstract void TurnOff();
        
    }
    public class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Washing Machine Turn On");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Washing Machine Turn Off");
        }
    }
    public class AirConditioner : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Air Conditioner Turn On");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Air Conditioner Turn Off");
        }
    }
    //Task 9
    public class BankAccount
    {
        private decimal balance; 
        public decimal Balance
        {
            get { return balance; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew: {amount:C}. New Balance: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }
    }

    //Task 10
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public abstract decimal CalculateSalary();
    }

    public class FullTimeEmployee: Employee
    {
        public decimal MonthlySalary { get; set; }
        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }
    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine(MathUtilities.Square(5)); // Output: 25
            Console.WriteLine(MathUtilities.RootSquare(25)); // Output: 5
            Console.WriteLine(MathUtilities.MaxFromTwoNumbers(10, 20)); // Output: 20

            //Task2
            Converter.CelToFah(25);
            Converter.KiloToMiles(10);

            //Task3
            VisitorCounter visitor1 = new VisitorCounter();
            VisitorCounter visitor2 = new VisitorCounter();
            VisitorCounter visitor3 = new VisitorCounter();
            Console.WriteLine($"Total visitors: {VisitorCounter.GetVisitorsCount()}"); 

            //Task4
            Company.CompanyName = "Orange Coding School";
            Company employee1 = new Company() { employeeName = "Salam" };
            Company employee2 = new Company() { employeeName = "Ali" };
            Console.WriteLine($"Company Name: {Company.CompanyName}");



        }
    }
}
