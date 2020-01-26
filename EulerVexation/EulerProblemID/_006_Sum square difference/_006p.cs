using System;
using System.Collections.Generic;
using System.Text;

namespace EulerVexation.EulerProblemID._006_Sum_square_difference
{
    class _006p
    {
        internal void Solve()
        {
            int N = 100;
                int sum = 0, squared = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
                squared += i * i;
            }
            Console.WriteLine("Sum {0}, Squared {1}", sum, squared);
            int x = squared - sum;
            Console.WriteLine("The Difference is {0}", x);
        }
        }
    }

