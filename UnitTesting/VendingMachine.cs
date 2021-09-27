using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class VendingMachine
    {
        public static void VendingMachineMethod()
        {
            // Declaring and initializing an array with notes of different denominations
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

            // Declaring an array to store the count of notes
            int[] count = new int[notes.Length];

            // Taking amount as an input from the user
            Console.Write("Enter the amount in Rs: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int temp = amount;
            int sumOfNotes = 0;
            int i = 0, j = 0;

            // Checking for condition
            while (amount != 0)
            {
                if (amount >= notes[i])
                {
                    count[j] = amount / notes[i];
                    sumOfNotes = sumOfNotes + count[j];
                    Console.WriteLine("{0} note/s of Rs {1}", count[j], notes[i]);
                    amount = amount - notes[i] * count[j];
                    j++;
                }
                i++;
            }
            Console.Write("Minimum number of note/s required to give the change of Rs {0} = {1}", temp, sumOfNotes);
            Console.ReadLine();
        }
    }
}

