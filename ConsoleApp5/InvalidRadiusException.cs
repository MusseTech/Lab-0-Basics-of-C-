using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(string message) : base(message)
        {
        }
    }
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            SetRadius(radius);
        }

        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException("Radius must be greater than zero.");
            }
            this.radius = radius;
        }

        public override string ToString()
        {
            return $"Circle with radius: {radius}";
        }
    }
}



