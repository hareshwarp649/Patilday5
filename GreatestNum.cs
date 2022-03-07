using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class GreatestNum
    {
        public static void NumGreatest()
        {
            int num1, num2, num3;
            Console.WriteLine("Find The Largest of Three Number:");
            Console.WriteLine("Input the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(" The 1st Number is the Greatest among other");
                }
                else
                {
                    Console.WriteLine(" The 3rd Number is the Greatest among other");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine(" The 2rd Number is the Greatest among other");
            }
            Console.ReadLine();
        }
    }
}
