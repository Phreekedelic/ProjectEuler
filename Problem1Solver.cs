using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

    Find the sum of all the multiples of 3 or 5 below 1000.
    */
    class Problem1Solver
    {
        public int solution;


        public Problem1Solver()
        {
            this.solution = solve(3, 5, 1000);
        }

        public int getSolution()
        {
            return solution;
        }


        public int solve(int firstMultiple, int secondMultiple, int maximumValue)
        {
            var firstMultiples = from number in Enumerable.Range(0, maximumValue)
                                 where ( number % firstMultiple == 0 )
                                 select number;

            var secondMultiples = from number in Enumerable.Range(0, maximumValue)
                                 where (number % secondMultiple == 0)
                                 select number;

            var allMultiples = firstMultiples.Union(secondMultiples);

            int sum = allMultiples.Sum();

            return sum;
        }



    }
}
