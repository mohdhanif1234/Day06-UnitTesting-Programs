using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class SwapNibble
    {
        public static void SwapNibbleMethod()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] binary = new int[8];
            int i = 7;
            while (number > 1)
            {
                binary[i] = number % 2;
                number = number / 2;
                i--;
            }
            binary[i] = 1;
            for (int j=0; j < i; j++)
            {
                binary[j] = 0;
            }
            //for (int t=0; t<=7;t++)
            //{
            //    Console.Write(binary[t]);
            //}
            int sum1 = 0, sum2 = 0;
            for (int p=0;p<=3;p++)
            {
                int pow1 = 3;
                int res1 = (int)Math.Pow(2, pow1);
                sum1 = sum2 + binary[p] * res1;
                pow1--;
            }
            //Console.WriteLine("sum1=" + sum1);
            for (int q=4;q<=7;q++)
            {
                int pow2 = 7;
                int res2 = (int)Math.Pow(2, pow2);
                sum2 = sum2 + binary[q] * res2;
                pow2--;
            }
            //Console.WriteLine("sum2=" + sum2);
            Console.Write("Number after swapping the nibble = " + (sum1 + sum2));
            Console.ReadLine();

        }
    }
}
