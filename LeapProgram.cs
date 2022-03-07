using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class LeapProgram
    {
        public static void ProgramLeap()
        {

            Console.Write("Enter the Year in Four Digits:\n ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(" is a Leap Year \n" + year);
            }
            else
            {
                Console.WriteLine(" is not a Leap Year\n" + year);
            }
            Console.ReadKey();
        }
    }
}
