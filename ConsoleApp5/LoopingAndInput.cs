using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class LoopingAndInput
    {
        public int GetPositiveNumber(string prompt)
        {
            int number;
            do
            {
                Console.Write(prompt);
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number." );
                }
            } while (number <= 0);

            return number;
        }
        public int GetHighNumber(int lowNumber)
        {
            int highNumber;
            do
            {
                Console.Write($"Enter a high number greater than {lowNumber}: ");
                if (!int.TryParse(Console.ReadLine(), out highNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number. ");
                }
            } while (highNumber <= lowNumber);

            return highNumber;
        }
    }
}
