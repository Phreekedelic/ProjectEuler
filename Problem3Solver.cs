﻿using System;
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
    class Problem3Solver
    {

        public long solution;

        public Problem3Solver()
        {
            solution = solve(600851475143);
        }

        public long getSolution()
        {
            return solution;
        }

        public long solve(long originalNumber)
        {
            long largestPrimeFactor = recursiveSolve(originalNumber, 1);
            return largestPrimeFactor;

        }

        public long recursiveSolve(long number, long lastPrimeFactor)
        {

            for(long i = lastPrimeFactor; i <= Math.Floor(Math.Sqrt(number)) ; i++ )
            {
                if (number % i == 0 && isPrime(i))
                {
                    return recursiveSolve(number / i, i);
                }
            }
            //if no prime factors 
            return number;
        }

        public bool isPrime(long candidatePrime)
        {
            if( candidatePrime <= 1)
            {
                return false;
            }
            else if( candidatePrime <= 3)
            {
                return true;
            }
            else if (candidatePrime % 2 == 0 || candidatePrime % 3 == 0)
            {
                return false;
            }
            var i = 5;
            while (i * i <= candidatePrime)
            {
                if (candidatePrime % i == 0 || candidatePrime % (i + 2) == 0)
                {
                    return false;
                }
                i = i + 6;
            }
            return true;
        }


    }
}