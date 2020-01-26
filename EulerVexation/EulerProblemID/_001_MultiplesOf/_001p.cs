using System;
using System.Collections.Generic;
using System.Text;

namespace EulerVexation.EulerProblemID._001_MultiplesOf
{
    class _001p
    {
        internal void Solve()
        {
            Console.WriteLine("Solvig the 1st Euler Problem: Multiples of\t Find the sum of all the multiples from the numbers you input\n");
            Console.WriteLine("Input 3 and 5 to solve Euler problem or entry any Natural number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            //mod the entry numbers
            int result = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    result += i;
                }
            }

            Console.WriteLine("The sum of all number which are dividable by {0} or {1} is {2}", a, b, result);
        }
    }
}
