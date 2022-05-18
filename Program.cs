using System;
using System.Collections.Generic;

namespace fibonacciExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> evenNumbers = new List<int>();
            evenNumbers = IsEven();
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.isFibonacci(evenNumbers);
        }
        static List<int> IOprocesses()
        {

            int controlKey = 0;
            int sum = 0;
            List<int> numbers = new List<int>();
            string allValues = "";
            while (controlKey == 0)
            {

                char ch;
                Console.Write("\n\nEnter the value : ");
                ch = Console.ReadKey().KeyChar;
                //Console.WriteLine("\nchar is : {0}", ch);

                allValues = allValues + ch.ToString();

                if (ch == 'E')
                {
                    controlKey = 1;
                }
                else if (ch < 58 && ch > 47)
                {
                    int number = (int)Char.GetNumericValue(ch);
                    sum = sum + number;
                    numbers.Add(number);
                }
                else
                {
                    Console.Write("\nvalue could not be added : {0}", ch);
                }
            }

            Console.Write("\n\nsum : {0}", sum);
            Console.Write("\nall values : {0}\n", allValues);
            Console.Write("Numbers : ");
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + " ");

            return numbers;
        }

        static List<int> IsEven()
        {
            List<int> numbers = new List<int>();
            numbers = IOprocesses();
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int isEven = numbers[i] % 2;
                if (isEven == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            Console.Write("\nEven numbers : ");
            for (int i = 0; i < evenNumbers.Count; i++)
                Console.Write(evenNumbers[i] + " ");

            return evenNumbers;
        }

    }

}

