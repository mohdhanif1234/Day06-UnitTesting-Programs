using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class MonthlyPayment
    {
        public static void MonthlyPaymentMethod()
        {
            // Taking the inputs
            Console.Write("Enter the principal amount in Rs: ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of years: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rate of interest: ");
            double R = Convert.ToDouble(Console.ReadLine());

            // Declaring and initializing the constants
            double r = R /  (12 * 100);
            double n = 12 * Y;
            double payment = P * (1 + r);

            // Checking the condition
            for (int i=1; i<n; i++) 
            {

                // Displaying the result
                //Console.WriteLine("Payment for month {0} = Rs {1}", i, Math.Round(payment,2));
                payment = payment * (1 + r);
            }
            Console.WriteLine("Monthly payment for next {0} months = Rs {1}", n, Math.Round((payment / n),2));
            Console.ReadLine();
        }
    }
}
