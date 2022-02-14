using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PrimeNumber
    {
        /// <summary>
        /// Prime() Prints the Prime numbers from 0 to 1000
        /// </summary>
        public static void Prime()
        {
            for (int num = 0; num <= 1000; num++)
            {
                int ctr = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)//checking for evens
                    {
                        ctr++;
                        break;
                    }
                }
                //Printing for Prime
                if (ctr == 0 && num != 0)
                    Console.Write("  " + num)
    }
}
