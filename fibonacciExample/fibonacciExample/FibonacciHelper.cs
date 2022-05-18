using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciExample
{
    public class FibonacciHelper
    {
        public bool IsFibonacci(int number)
        {
            bool isFibonacciNumber = false;
            int pastFibonacciNumber = 1;
            int secondPastFibonacciNumber = 0;
            int currentFibonacciNumber;

            if (number == secondPastFibonacciNumber)
            {
                isFibonacciNumber = true;
            }
            while (true)
            {
                currentFibonacciNumber = pastFibonacciNumber + secondPastFibonacciNumber;

                if (currentFibonacciNumber > number)
                {
                    break;
                }
                else if (number == currentFibonacciNumber)
                {
                    isFibonacciNumber = true;
                    break;
                }
                secondPastFibonacciNumber = pastFibonacciNumber;
                pastFibonacciNumber = currentFibonacciNumber;

            }
            return isFibonacciNumber;
        }

        public int FindBiggestNumber(List<int> evenNumbers)
        {
            evenNumbers.Sort();
            evenNumbers.Reverse();
            Console.Write("\nSorted even numbers : ");
            for (int i = 0; i < evenNumbers.Count; i++)
                Console.Write(evenNumbers[i] + " ");

            Console.WriteLine("\nBiggest Number : {0}", evenNumbers[0]);
            return evenNumbers[0];
        }
    }
}
