using System;
using System.Collections.Generic;
using System.Linq;

namespace fibonacciExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            FibonacciHelper fibonacci = new FibonacciHelper();

            //flow
            numbers = ReadInputAndFindNumbers();
            evenNumbers = FindEvenNumbers(numbers);
            int biggestNumber = fibonacci.FindBiggestNumber(evenNumbers);
            bool isFibonacciNumber = fibonacci.IsFibonacci(biggestNumber);
            //end of the flow
            
            if (isFibonacciNumber)
            {
                Console.WriteLine("\n\n************The biggest even number is a Fibonacci number.************");
            }
            else
            {
                Console.WriteLine("\n\n************The biggest even number is not a Fibonacci number.************");
            }
        }
        static List<int> ReadInputAndFindNumbers()
        {

            int sum = 0;
            List<int> numbers = new List<int>();
            int indexOfAllInputs = 1;
            List<string> allInputs = new List<string>();


            while (true)
            {
                string singleInput;

                Console.Write("\nEnter the value : ");
                singleInput = Console.ReadLine();

                allInputs.Add(singleInput);
                bool isIntString = singleInput.All(char.IsDigit);

                if (singleInput == "E")
                {
                    break;
                }
                else if (isIntString) 
                {
                    int intNumber = Int32.Parse(singleInput);
                    sum = sum + intNumber;
                    numbers.Add(intNumber);
                }
                else
                {
                    Console.Write("Value could not be added : {0}\n", singleInput);
                }

                indexOfAllInputs++;
            }

            Console.Write("\n\nsum : {0}", sum);
            Console.Write("\nall values : ");
            for (int i = 0; i < allInputs.Count; i++)
                Console.Write(allInputs[i] + " ");
            Console.Write("\nNumbers : ");
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + " ");

            return numbers;
        }

        static List<int> FindEvenNumbers(List<int> numbers)
        {
            //List<int> numbers = new List<int>();
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

