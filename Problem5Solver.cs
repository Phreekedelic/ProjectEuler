using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /*
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    */
    class Problem5Solver
    {

        public int solution;

        public Problem5Solver()
        {
            solution = solve();
        }

        public int getSolution()
        {
            return solution;
        }

        /*
        I don't like that this just brute-forces it, but at the same time it's
        easier than finding the prime factors. Might re-do later.
        */
        public int solve()
        {
            int candidate = 19 * 17;
            bool found = false;
            while ( ! found )
            {
                if ( isDivisible(candidate))
                {
                    return candidate;
                }
                candidate++;
            }

            throw new Exception("Failed to find a multiple.");
        }


        public bool isDivisible(int candidate)
        {
            for (int i =1; i <= 20; i++)
            {
                if (candidate % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
