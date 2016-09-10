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

            List<ISolver> solvers = new List<ISolver>();

            solvers.Add(new Problem1Solver());
            solvers.Add(new Problem2Solver());
            solvers.Add(new Problem3Solver());
            solvers.Add(new Problem4Solver());
            solvers.Add(new Problem5Solver());
            solvers.Add(new Problem6Solver());
            solvers.Add(new Problem7Solver());
            solvers.Add(new Problem8Solver());

            int problemNumber = 1;
            foreach( ISolver solver in solvers)
            {
                Console.WriteLine("Solution " + problemNumber +" : "  + solver.solve());
                problemNumber++;
            }

            //wait for key press before quitting
            Console.ReadLine();

        }
    }
}
