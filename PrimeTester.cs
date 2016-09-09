using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    class PrimeTester
    {
        public bool isPrime(long candidatePrime)
        {
            if (candidatePrime <= 1)
            {
                return false;
            }
            else if (candidatePrime <= 3)
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
