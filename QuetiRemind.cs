using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class QuetiRemind
    {

        public static void ProgramRemiQue()
        {
            int num1, num2;
            Console.WriteLine("Enter the first Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first Number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            int quotient = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
            Console.Read();

        }
    }
}
