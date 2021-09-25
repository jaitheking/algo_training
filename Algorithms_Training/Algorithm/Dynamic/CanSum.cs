using System;
using System.Collections.Generic;

namespace Algorithms_Training.Algorithm.Dynamic
{
    public class CanSum : Algorithm
    {
        bool Output { get; set; }
        private static Dictionary<int, bool> _memo = new() { };

        /// <summary>
        /// Optimized approach of solving the CanSum problem
        /// Time Completixity is O(m*n),Space Complexity is O(m)
        /// </summary>
        /// <param name="targetSum"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool SolveOptimized(int targetSum, int[] numbers)
        {
            // memoization
            //base case #1 + #2
            if (_memo.ContainsKey(targetSum))
            {
                return _memo[targetSum];
            }

            // traversal method
            //base case #1
            if (targetSum == 0)
            {
                return true;
            }
            //base case #2
            if (targetSum < 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                if (SolveOptimized(remainder, numbers) == true)
                {
                    _memo[targetSum] = true; //memoize true
                    return true;
                }
            }
            _memo[targetSum] = false; //memoize false
            return false;
        }


        /// <summary>
        /// Unoptimized, Based on problem where you need to confirm the target sum can be derived from the numbers in array
        /// Time Completixity is O(n^m * m),Space Complexity is O(m)
        /// </summary>
        /// <param name="targetSum"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool Solve(int targetSum, int[] numbers)
        {
            //base case #1
            if (targetSum == 0)
            {
                return true;
            }
            //base case #2
            if (targetSum < 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                if (Solve(remainder, numbers) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public void RunWithInput(int targetSum, int[] numbers)
        {
            StartTime = DateTime.Now;
            Output = SolveOptimized(targetSum, numbers);
            EndTime = DateTime.Now;
            Console.WriteLine($"Input: ({targetSum},[{string.Join(",", numbers)}]), Output: {Output}");
            ShowTimeTaken();
            Clear();
        }

        public void Clear()
        {
            _memo = new() { };
        }
    }
}