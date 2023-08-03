using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>()
        { 6,7,21};

            //display all elements 
            DisplayElements(numbers);

            //ADD 2 & 7
            numbers.Add(2);
            numbers.Add(7);

            //Display elements
            DisplayElements(numbers);

            //INSERT 3
            numbers.Insert(3, 3);
            DisplayElements(numbers);

            //Remove
            numbers.Remove(7);
            numbers.Remove(100);
            numbers.RemoveAt(numbers.Count - 2);

            DisplayElements(numbers);
            Console.WriteLine(CheckNumber(5, numbers));
            Console.WriteLine($"Sum of Evens: {SumOfEvens(numbers)}");
            AverageOfOdd(numbers);
            MultiplesOf3And7(numbers);
            Console.WriteLine(CheckforNumber(8));
            Console.WriteLine(CheckforNumber(59));
            Console.WriteLine(CheckforNumber(98));

            Console.Read();
        }

        static void DisplayElements(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item );
            }
            Console.WriteLine("=================\n");
        }
        
        static bool CheckNumber(int x , List<int> num)
        {
            return num.Contains(x);
        }

        static int SumOfEvens (List<int> numbers)
        {
            int Sum = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    Sum += n;
                }
            }
            return Sum;
        }

        static void AverageOfOdd(List<int> num)
        {
            int sum = 0;
            int count = 0;
            double average = 0;

            foreach(int n in num)
            {
                if (n % 2 != 0)
                {
                    sum += n;
                    count++;  
                }
            }
            average = sum / count;
            Console.WriteLine($"Average: {average.ToString("N2")}");
        }

        static void MultiplesOf3And7(List<int> num)
        {
            foreach (int n in num)
            {
                if (n % 3 == 0 && n % 7 == 0)
                {
                    Console.WriteLine(n);
                }
            }
        }

        static string CheckforNumber(int x)
        {
            return = x % 2 == 0 ? "Even" :
                x % 3 == 0 ? "Multiple of 3" : "Odd";

         
        }
    }
}
