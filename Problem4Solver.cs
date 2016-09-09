using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /*
    A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    Find the largest palindrome made from the product of two 3-digit numbers.
    */
    class Problem4Solver : ISolver
    {
        public long solve()
        {

            int highestCandidate = 0;
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j >= i; j--)
                {
                    int newCandidate = i * j;
                    if (newCandidate > highestCandidate && isPalindrome(newCandidate))
                    {
                        highestCandidate = newCandidate;
                    }
                }

            }

            return highestCandidate;
        }

        public bool isPalindrome(int candidate)
        {
            String forwards = candidate.ToString();
            String backwards = new String ( forwards.Reverse().ToArray<char>() );

            if (forwards.Equals(backwards))
            {
                return true;
            }
            return false;
        }
    }
}
