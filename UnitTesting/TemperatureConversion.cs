using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class TemperatureConversion
    {
        public static double Temperature()
        {
            // Taking input
            Console.Write("Enter the temperature: ");
            double temp1 = Convert.ToDouble(Console.ReadLine());
            return temp1;
        }
        public void CelciusToFarenheitMethod()
        {
            // Calculating the temperature in degree Farenheit
            double tempNew = Temperature();
            double farenheit = (tempNew * 9) / 5 + 32;
            Console.WriteLine("Temperature in degree Farenheit = {0}", Math.Round(farenheit,2));
            Console.ReadLine();
        }
        public void FarenheitToCelciusMethod()
        {
            // Calculating the temperature in degree Celcius
            double tempNew = Temperature();
            double celcius = (tempNew - 32) * 5 / 9;
            Console.WriteLine("Temperature in degree Celcius = {0}", Math.Round(celcius,2));
            Console.ReadLine();
        }
        public void TemperatureConversionMethod()
        {
            // Taking a choice for temperature conversion
            Console.Write("Enter 1 for celcius to farenheit conversion\nEnter 2 for farenheit to celcius conversion\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Checking the choice with case statements
            switch (choice)
            {
                case 1:
                    CelciusToFarenheitMethod();
                    break;
                case 2:
                    FarenheitToCelciusMethod();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input!!!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
