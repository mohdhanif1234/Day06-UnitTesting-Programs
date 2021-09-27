using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class DayOfTheWeek
    {
        public static void DayOfTheWeekMethod()
        {
            // Taking day, month and year as inputs from the user
            Console.Write("Enter the day: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Calculating the day of the week
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            // Checking with day with case statements and displaying the result
            switch (d0)
            {
                case 0:
                    Console.WriteLine("{0}/{1}/{2} falls on Sunday", d, m, y);
                    break;
                case 1:
                    Console.WriteLine("{0}/{1}/{2} falls on Monday", d, m, y);
                    break;
                case 2:
                    Console.WriteLine("{0}/{1}/{2} falls on Tuesday", d, m, y);
                    break;
                case 3:
                    Console.WriteLine("{0}/{1}/{2} falls on Wednesday", d, m, y);
                    break;
                case 4:
                    Console.WriteLine("{0}/{1}/{2} falls on Thursday", d, m, y);
                    break;
                case 5:
                    Console.WriteLine("{0}/{1}/{2} falls on Friday", d, m, y);
                    break;
                default:
                    Console.WriteLine("{0}/{1}/{2} falls on Saturday", d, m, y);
                    break;
            }
            Console.ReadLine();
        }
    }
}
