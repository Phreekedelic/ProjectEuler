﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{

    /*Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:

     1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

    By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    */
    class Problem2Solver
    {
        public int solution;

        public Problem2Solver()
        {
            solution = solve();
        }

        public int solve()
        {
            int sum = 2;
            int[] previous = new int[2];
            previous[0] = 1;
            previous[1] = 1;
            int index = 0;

            while (previous[index] < 4000000)
            {
                index = (index + 1) % 2;
                int current = previous[0] + previous[1];

                if (current % 2 == 0)
                {
                    sum = sum + current;
                }

                previous[index] = current;
            }
            return sum;
        }

        public int getSolution()
        {
            return solution;
        }
    }
}
