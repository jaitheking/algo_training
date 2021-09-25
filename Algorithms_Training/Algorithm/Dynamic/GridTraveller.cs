using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_Training.Algorithm.Dynamic
{
    public class GridTraveller : Algorithm
    {
        long Output { get; set; }
        private static Dictionary<string, long> _memo = new() { { "0,0", 0 }, { "1,1", 1 } };


        /// <summary>
        /// Optimized approach to solve Grid Traveller problem
        /// Time Completixity is O(m*n),Space Complexity is O(n+m)
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public long SolveOptimized(int m, int n)
        {
            string key = $"{m},{n}";
            // memoization
            if (_memo.ContainsKey(key))
            {
                return _memo[key];
            }
            // base case #1
            if (m == 1 && n == 1)
            {
                return 1;
            }
            // base case #2
            if (m == 0 || n == 0)
            {
                return 0;
            }
            long value = SolveOptimized(m - 1, n) + SolveOptimized(m, n - 1);
            _memo[key] = value;
            return value;
        }
        /// <summary>
        /// Unoptimized, based on number of possible grid movement count problem where you can only move down/right from the start to end points,
        /// Time Completixity is O(2^n+m),Space Complexity is O(n+m),
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Solve(int m, int n)
        {
            // base case #1
            if (m == 1 && n == 1)
            {
                return 1;
            }
            // base case #2
            if (m == 0 || n == 0)
            {
                return 0;
            }
            return (Solve(m - 1, n) + Solve(m, n - 1));
        }


        public void RunWithInput(int row, int col)
        {
            StartTime = DateTime.Now;
            //Output = Solve(row, col);
            Output = SolveOptimized(row, col);
            EndTime = DateTime.Now;
            Console.WriteLine($"Input: ({row},{col}), Output: {Output}");
            ShowTimeTaken();
        }

    }
}
