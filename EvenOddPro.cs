using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class EvenOddPro
    {
        public static void ProEvenOdd()
        {
            int num;
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("Number Is Even");

            }else
            {
                Console.WriteLine("Number Is Odd");
            }
            Console.ReadKey();
        }
    }
}
