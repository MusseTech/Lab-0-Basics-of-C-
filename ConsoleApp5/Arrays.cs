using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Arrays
    {
        public int[] CreateNumberArray(int low, int high)
        {
            if (low >= high)
            {
                throw new ArgumentException("Low number must be less than high number.");
            }
            int size = high - low + 1;
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = low + i;
            }
            return numbers;
        }
        public void WriteToFile(int[] numbers, string fileName)
        {
            Array.Reverse(numbers); // Added to match requirment of reverse or order
            File.WriteAllLines(fileName, numbers.Select(n => n.ToString()));
            Array.Reverse(numbers); // Reversing back to original order for further operations
        }
        public int CalculateSumFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            return lines.Sum(line => int.Parse(line));
        }
        public void PrintPrimes(int[] numbers)
        {
            Console.WriteLine("Prime numbers in range:");
            foreach (var number in numbers)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
