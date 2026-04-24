using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming__OOP__in_C___Notion_
{
    //Task 1 Start
    public class Person
    {
        public string name { set; get; }
        private int age;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }

    public class Student : Person
    {
        public void PrintStudentMarks()
        {
            Console.WriteLine($"Student Name is {name}");
        }
    }
    //Task 1 End


    //Task 2 Start
    public class Car
    {
        public string mark { set; get; }
        public int year { set; get; }
        public string type { set; get; }
        private int price { set; get; }
        public string model { set; get; }
        public int palletNo { set; get; }
        public string color { set; get; }
        public Car(string mark, int year, string type, int price, string model, int palletNo, string color)
        {
            this.mark = mark;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNo = palletNo;
            this.color = color;
        }
        
        public void startEngine()
        {
            Console.WriteLine("Car engine started.");
        }
        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
    //Task 2 End

    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Task 1
            Student student = new Student();
            student.name = "Salam Ata";
            student.PrintStudentMarks();
            student.PrintInfo();

            //Test Task 2
            Car carOne = new Car("BMW", 2024, "type", 56890, "bmw2023", 897543214, "Red");
            carOne.startEngine();
            carOne.stopEngine();
        }
    }
}
