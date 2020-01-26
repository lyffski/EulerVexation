using System;
using System.Collections.Generic;
using System.Text;

namespace EulerVexation.EulerProblemID._005_SmallesFactor
{
    class _005p
    {
        private int[] generatePrimes(int Limit)
        {
            List<int> prim = new List<int>();
            bool isPrim;
            int j;

            prim.Add(2);

            for (int i = 3; i <= Limit; i += 2)
            {
                j = 0;
                isPrim = true;
                while (prim[j] * prim[j] <= i)
                {
                    if (i % prim[j] == 0)
                    {
                        isPrim = false;
                        break;
                    }
                    j++;
                }
                if (isPrim)
                {
                    prim.Add(i);
                }
            }

            return null;
        }
        internal void Solve()
        {

            int divisorMax = 20;
            int[] p = generatePrimes(divisorMax);
            int end = 1;

            for (int i = 0; i < p.Length; i++)
            {
                int a = (int)Math.Floor(Math.Log(divisorMax) / Math.Log(p[i]));
                end = end * ((int)Math.Pow(p[i], a));
            }

        }
    }
}
