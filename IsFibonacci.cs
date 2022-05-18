using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciExample
{
    public class Fibonacci
    {
        public void isFibonacci(List<int> evenNumbers)
        {
            int[] fibonacciNumbers = { 0, 2, 8 };
            evenNumbers.Sort();
            evenNumbers.Reverse();
            Console.Write("\nSorted even numbers : ");
            for (int i = 0; i < evenNumbers.Count; i++)
                Console.Write(evenNumbers[i] + " ");

            bool control = false;
            for (int i = 0; i < 3; i++) {
                if (fibonacciNumbers[i] == evenNumbers[0])
                {
                    Console.WriteLine("\n\nBiggest even number is a fibonacci number.");
                    control = true;
                }
            }
            if (!control)
            {
                Console.WriteLine("\n\nBiggest even number is not a fibonacci number.");
            }
        }
    }
}
