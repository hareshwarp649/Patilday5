using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class SwapPro
    {
        public static void ProSwap()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter First  Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second  Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n After Swapping:  ");
            Console.WriteLine("\n First  Number: " +num1);
            Console.WriteLine("Second  Number : " + num2);
            Console.Read();
        }
        
    }
}
