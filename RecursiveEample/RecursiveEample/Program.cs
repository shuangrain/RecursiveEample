using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveEample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("請輸入N = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("請輸入數字 !!");
                Console.Write("請輸入N = ");
            }

            //遞迴
            Run(n, new Recursive());
            Console.ReadKey();

            //迴圈
            Run(n, new ForLoop());
            Console.ReadKey();
        }

        static void Run(int n, ICompute compute)
        {
            Console.WriteLine("1 + ... + N = {1}", n, compute.Iterative(n));
            Console.WriteLine("1 - 2 + 3 ... + N = {1}", n, compute.AdvancedIterative(n));
            Console.WriteLine("N! = {1}", n, compute.Factorial(n));
            Console.WriteLine("Fn = Fn-1 + Fn-2, n = {0}, Ans = {1}", n, compute.Fibonacci(n));
        }
    }
}
