using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{

    /*
    The sum of the squares of the first ten natural numbers is,
    
    12 + 22 + ... + 102 = 385
    
    The square of the sum of the first ten natural numbers is,
    
    (1 + 2 + ... + 10)2 = 552 = 3025
    
    Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    
    Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

    */
    class Problem6Solver : ISolver
    {
        public long solve()
        {
            return solve(100);
        }

        public int solve(int n)
        {
            int sumSquares = sumOfSquares(n);
            int squareSum = squareOfSum(n);

            int result = Math.Abs( sumSquares - squareSum);

            return result;
        }

        public int sumOfSquares(int n)
        {
            int sum = 0;

            for (int i =1; i <= n; i++)
            {
                sum = sum + (i * i);
            }
            return sum;
        }

        public int squareOfSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            return (sum * sum);
        }
    }
}
