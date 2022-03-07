using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class PowerProgram
    {
        public static void ProgramPower()
        {
            int num, pow, result=1 ;
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power");
            pow = Convert.ToInt32(Console.ReadLine());


            while(pow>0)
            {

                result = result * num;
                pow--;
            }
            Console.WriteLine("Result=" + result);
            Console.ReadLine();
        }

    }
}
