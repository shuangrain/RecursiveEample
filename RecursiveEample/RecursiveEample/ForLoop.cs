using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveEample
{
    public class ForLoop : ICompute
    {

        public Int64 Iterative(Int64 n)
        {
            int ans = 0;

            for (int i = 1; i <= n; i++)
            {
                ans += i;
            }

            return ans;
        }

        public Int64 AdvancedIterative(Int64 n)
        {
            int ans = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    ans -= i;
                }
                else
                {
                    ans += i;
                }
            }

            return ans;
        }

        public Int64 Factorial(Int64 n)
        {
            int ans = 1;

            for (int i = 1; i <= n; i++)
            {
                ans *= i;
            }

            return ans;
        }

        public Int64 Fibonacci(Int64 n)
        {
            int ans = 0;
            int[] arr = new int[2] { 1, 1 };

            for (int i = 1; i <= n; i++)
            {
                if (i < 3)
                {
                    ans = 1;
                }
                else
                {
                    ans = arr[0] + arr[1];
                    arr[0] = arr[1];
                    arr[1] = ans;
                }
            }

            return ans;
        }
    }
}
