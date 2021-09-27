using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class BinaryRepresentation
    {
        public static void ToBinary()
        {
            // Taking an input
            Console.Write("Enter the number whose equivalent binary number is to be generated: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;

            // Declaring an array to store the count of powers of 2
            int[] powerCount = new int[8];
            int i = 0;
            int n1 = 1;

            //Checking for condition
            while (n1 > 0)
            {
                double n = Math.Log(number, 2);
                n1 = (int)n;
                powerCount[i] = n1;
                if (n1 == -2147483648)
                {
                    break;
                }
                i++;
                number = (int)(number - Math.Pow(2, n1));
            }

            // Displaying the equivalent binary number of the given decimal number
            Console.Write("Binary representation of {0} is: ",temp);
            int m = 0;
            for (int j = powerCount[0]; j >= 0; j--)
            {
                if (j == powerCount[m])
                {
                    Console.Write("1");
                    m++;
                    
                }
                else
                {
                    Console.Write("0");
                }
            }
            Console.ReadLine();
        }
    }
}
