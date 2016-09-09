using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /*
    The prime factors of 13195 are 5, 7, 13 and 29.

    What is the largest prime factor of the number 600851475143 ?
    */
    class Problem3Solver : ISolver
    {
        public long solve()
        {
            long result = recursiveSolve(600851475143, 1);
            return result;
        }

        public long recursiveSolve(long number, long lastPrimeFactor)
        {
            PrimeTester tester = new PrimeTester();

            for(long i = lastPrimeFactor; i <= Math.Floor(Math.Sqrt(number)) ; i++ )
            {
                if (number % i == 0 && tester.isPrime(i))
                {
                    return recursiveSolve(number / i, i);
                }
            }
            //if no prime factors 
            return number;
        }
    }
}
