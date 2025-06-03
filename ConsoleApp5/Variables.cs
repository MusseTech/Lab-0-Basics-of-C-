using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Variables
    {
        public int LowNumber { get; private set; }
        public int HighNumber { get; private set; }

        public void GetNumbers()
        {
            Console.Write("Enter a low number: ");
            LowNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a high number: ");
            HighNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Difference: {HighNumber - LowNumber}");
        }
    }
}
