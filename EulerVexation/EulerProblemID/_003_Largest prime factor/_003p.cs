using System;
using System.Collections.Generic;
using System.Text;

namespace EulerVexation.EulerProblemID._003_Largest_prime_factor
{
    class _003p
    {
        public static void LargestPrimeFactor(){

        }
        internal void Solve()
        {
            const long numm = 600851475143;
            long newnumm = numm;
            long largestFact = 0;

            int counter = 2;
            while (counter * counter <= newnumm)
            {
                if (newnumm % counter == 0)
                {
                    newnumm = newnumm / counter;
                    largestFact = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (newnumm > largestFact)
            { // prim num is a reminder
                largestFact = newnumm;
            }
            Console.WriteLine(largestFact);
        }
            }
        }

