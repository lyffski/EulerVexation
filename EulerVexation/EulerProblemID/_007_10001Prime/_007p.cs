using System;
using System.Collections.Generic;
using System.Text;

namespace EulerVexation.EulerProblemID._007_10001Prime
{
    class _007p
    {
        
            internal void Solve()
            {
                int count = 0;
                int num = 2;
                while (true)
                {
                    if (IsPrime(num)) count++;
                    if (count == 10001) break;
                    num++;
                }
                Console.WriteLine(num);
                
            }

            static bool IsPrime(int num)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }

        
    }
}
