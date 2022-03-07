using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class FlipCoin
    {

        public static void Flipcoinpercen()
        {
            Console.WriteLine("Please enter the value for number of flips");

            int head = 0;
            int tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int Flip = Convert.ToInt32(Console.ReadLine());

            if (Flip > 0)
            {
                for (int i = 1; i <= Flip; i++)
                {
                    Random random = new Random();
                    int num = random.Next(2);
                 //   number = Convert.ToInt32(Console.ReadLine());
                   
                
                if(num==1 )
                {
                    head = 1;
                    HeadCount += head;

                }
              else if(num==0)
                {
                    tail = 1;
                    TailCount += tail;


                }
                Console.WriteLine(num);

             }



                Console.WriteLine("--------------");
                HeadPercentage = (HeadCount * 100) / Flip;
                TailPercentage = (TailCount * 100) / Flip;

                Console.WriteLine("Head Percentage : " + HeadPercentage);
                Console.WriteLine("Tail Percentage : " + TailPercentage);

            }

            else
            {
                Console.WriteLine("Enter Positive Integer");

            }
        }
    }

}
