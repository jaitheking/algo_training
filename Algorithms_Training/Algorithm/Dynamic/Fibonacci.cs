using System;
using System.Collections.Generic;
namespace Algorithms_Training.Algorithm.Dynamic
{
    public class Fibonacci : Algorithm

    {
        private static Dictionary<int, long> _memo = new() { { 0, 0 }, { 1, 1 } };
        long Output { get; set; }

        /// <summary>
        /// Fibonacci Calculation by using Memoization principle,
        /// Time Completixity is O(n),Space Complexity is O(n),
        /// Credits to :https://www.davidhayden.me/blog/recursive-fibonacci-and-memoization-in-csharp
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public long SolveOptimized(int index)
        {
            // memoization
            //base case #1 + #2
            if (_memo.ContainsKey(index))
            {
                return _memo[index];
            }

            // traversal method
            long value = SolveOptimized(index - 1) + SolveOptimized(index - 2);

            _memo[index] = value;

            return value;
        }

        /// <summary>
        /// Unoptimized, based on standard Fibonacci principle,
        /// Time Completixity is O(2^n),Space Complexity is O(n)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public long Solve(int index)
        {
            //base case #1
            if (index <= 2)
            {
                return 1;
            }
            return Solve(index - 1) + Solve(index - 2);
        }

        public void RunWithInput(int index)
        {
            StartTime = DateTime.Now;
            Output = SolveOptimized(index);
            EndTime = DateTime.Now;
            Console.WriteLine($"Input: {index}, Output: {Output}");
            ShowTimeTaken();
        }

    }
}
