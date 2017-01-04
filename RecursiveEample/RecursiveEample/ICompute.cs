using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveEample
{
    interface ICompute
    {
        /// <summary>
        /// 1 + ... + N = ?
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Answer</returns>
        Int64 Iterative(Int64 n);

        /// <summary>
        /// 1 - 2 + 3 ... + N = ?
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Answer</returns>
        Int64 AdvancedIterative(Int64 n);

        /// <summary>
        /// 1 x 2 x ... x N = ?
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Answer</returns>
        Int64 Factorial(Int64 n);

        /// <summary>
        /// Fn = Fn-1 + Fn-2
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Answer</returns>
        Int64 Fibonacci(Int64 n);
    }
}
