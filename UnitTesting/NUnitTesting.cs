using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class NUnitTesting
    {
        static void Main(string[] args)
        {
            // Displaying the options for a program to run
            Console.WriteLine("Enter 1 for vending machine program");
            Console.WriteLine("Enter 2 for day of the week program");
            Console.WriteLine("Enter 3 for temperature conversion program");
            Console.WriteLine("Enter 4 for monthly payment program");
            Console.WriteLine("Enter 5 for square root program");
            Console.WriteLine("Enter 6 for binary representation program");
            Console.WriteLine("Enter 7 for swap nibble program");
            Console.Write("Select any one option to run a program of your choice: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    VendingMachine.VendingMachineMethod();
                    break;
                case 2:
                    DayOfTheWeek.DayOfTheWeekMethod();
                    break;
                case 3:
                    TemperatureConversion temp = new TemperatureConversion();
                    temp.TemperatureConversionMethod();
                    break;
                case 4:
                    MonthlyPayment.MonthlyPaymentMethod();
                    break;
                case 5:
                    SquareRoot.Sqrt();
                    break;
                case 6:
                    BinaryRepresentation.ToBinary();
                    break;
                case 7:
                    SwapNibble.SwapNibbleMethod();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input!!!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
