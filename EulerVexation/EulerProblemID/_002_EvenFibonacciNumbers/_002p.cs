using System;
using System.Collections.Generic;
using System.Text;

namespace EulerVexation.EulerProblemID._002_EvenFibonacciNumbers
{
    class _002p
    {
        public static string FibonacciChain(int n)
        {
            if (n < 2) return "1";

            int[] nums = new int[n]; // first 2 num are const
            nums[0] = 0;
            nums[1] = 1;
            for (int i = 2; i < n; i++) //for loop -> adding through recursion the numbers
            {
                nums[i] = nums[i - 1] + nums[i - 2]; 

            }
            return string.Join(" ", nums); // convet to string and spaceing between
        }

        internal void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciChain(n));

         }
        }
    }

