using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class SquareRoot
    {
        public static void Sqrt()
        {
            // Taking input
            Console.Write("Enter a non negative number: ");

            // Declaring and initializing the variables
            double c = Convert.ToDouble(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;

            // Checking the condition
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }

            // Displaying the result
            Console.Write("Square root of {0} = {1}", c, t);
            Console.ReadLine();
        }
    }
}
