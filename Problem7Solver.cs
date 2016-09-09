﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /*
    By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    What is the 10 001st prime number?

    */
    class Problem7Solver : ISolver
    {
        public long solve()
        {
            PrimeTester tester = new PrimeTester();
            long candidate = 0;
            int primesFound = 0;
            while (primesFound < 10001)
            {
                candidate++;

                if (tester.isPrime(candidate))
                {
                    primesFound++;
                }
            }
            return candidate;
        }

    }
}
