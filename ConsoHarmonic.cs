using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class ConsoHarmonic
    {
        public static void ProgramHarmonic()
        {
            int K;
            float harmonic = 1;

            Console.WriteLine("Enter a nth of harmonic number");
            K = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < K; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine(harmonic);
           
        }
    }
}
