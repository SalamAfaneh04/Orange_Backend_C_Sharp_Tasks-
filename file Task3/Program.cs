using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace file_Task3
{
    //1
    //Correct the syntax error:
    //•	string[] ARR = [1, 7  9  45,] ----> string[] ARR = { "1", "7", "9", "45" };
    //•	int arr2 = ["Str" "alex","moh" --> int[] arr2 = { 1, 2, 3 };
    //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ] --> string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

    //2
    //What the index of "Banana","Tomato"?
    //String[]  fruits=["Tomato", "Banana", "Watermelon"]
    //Answer: The index of "Banana" is 1 and the index of "Tomato" is 0.

    internal class Program
    {

        //5
        static void printOddNumbers()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        //6
        static void printNumbers()
        {
            int space = 3;
            int startnuber = 1;
            for (int i = 1; i <5; i++)
            {
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <startnuber; k++)
                {
                    Console.Write("*");
                   
                }
                startnuber++;
                space--;
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //3
            string[] fivFood = { "Pizza", "Burger", "Pasta", "Sushi", "Salad" };
            string[] fivSport = { "Basketball", "Tennis", "Running" };
            string[] fivMovie = { "Inception", "The Dark Knight", "Interstellar" , "The Death"};
            foreach (var item in fivMovie)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < fivFood.Length; i++)
            {
                Console.WriteLine(fivFood[i]);
            }
            foreach (var item in fivSport)
            {
                Console.WriteLine(item);

            }

            //4
            string numbers = "3,67,9";
            string[] number= numbers.Split(',');
            int sum = 0;
            foreach (string item in number) 
            {
                sum += int.Parse(item);
            }
            Console.WriteLine("Sum: " + sum);

            printNumbers();

        }
    }
}
