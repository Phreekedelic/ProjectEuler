using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            Problem1Solver solver1 = new Problem1Solver();

            Console.WriteLine("Solution 1: " + solver1.getSolution());

            Problem2Solver solver2 = new Problem2Solver();

            Console.WriteLine("Solution 2: " + solver2.getSolution());

            Problem3Solver solver3 = new Problem3Solver();

            Console.WriteLine("Solution 3: " + solver3.getSolution());

            Problem4Solver solver4 = new Problem4Solver();

            Console.WriteLine("Solution 4: " + solver4.getSolution());

            Problem5Solver solver5 = new Problem5Solver();

            Console.WriteLine("Solution 5: " + solver5.getSolution());

            Problem6Solver solver6 = new Problem6Solver();

            Console.WriteLine("Solution 6: " + solver6.getSolution());

            //wait for key press before quitting
            Console.ReadLine();

        }
    }
}
