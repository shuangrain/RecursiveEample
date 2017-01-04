using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveEample
{
    public class Recursive : ICompute
    {
        public Int64 Iterative(Int64 n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + Iterative(n - 1);
            }
        }

        public Int64 AdvancedIterative(Int64 n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n % 2 == 0 ? -n + AdvancedIterative(n - 1) : n + AdvancedIterative(n - 1);
            }
        }

        public Int64 Factorial(Int64 n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public Int64 Fibonacci(Int64 n)
        {
            if (n < 3)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
