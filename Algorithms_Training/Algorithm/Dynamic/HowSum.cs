using System;
using System.Collections.Generic;

namespace Algorithms_Training.Algorithm.Dynamic
{
    public class HowSum : Algorithm
    {
        List<int> Output { get; set; }
        private static Dictionary<int, List<int>> _memo = new(){};

        /// <summary>
        /// Optimized approach of solving the HowSum problem
        /// Time Completixity is O(n*m^2),Space Complexity is O(m^2)
        /// </summary>
        /// <param name="targetSum"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public List<int> SolveOptimized(int targetSum, int[] numbers)
        {
            List<int> result = new List<int>();

            //Check the memo
            // memoization
            if (_memo.ContainsKey(targetSum))
            {
                return _memo[targetSum];
            }

            // base case #1
            if (targetSum == 0)
            {
                return new(){};
            }
            // base case #2
            if (targetSum < 0)
            {
                //_memo.Add(targetSum, null);
                return null;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                List<int> remainderResult = SolveOptimized(remainder, numbers);
                if (remainderResult != null)
                {
                    result.AddRange(remainderResult);
                    result.Add(numbers[i]);
                    _memo.Add(targetSum, result);
                    return result;
                }
            }
            _memo.Add(targetSum, null);
            return null;
        }

        /// <summary>
        /// Unoptimized, the problem is finding the combination of elements of an array that adds up to exactly the targetsum 
        /// and return null if no combination is found 
        /// and if multiple combination are available, just return one combination,
        /// Time Completixity is O(n^m),Space Complexity is O(n)
        /// </summary>
        /// <param name="targetSum"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public List<int> Solve(int targetSum, int[] numbers)
        {
            List<int> result = new List<int>();
            // base case #1
            if (targetSum == 0)
            {
                return new List<int>();
            }
            // base case #2
            if (targetSum < 0)
            {
                return null;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                List<int> remainderResult = Solve(remainder, numbers);
                if (remainderResult != null)
                {
                    result.AddRange(remainderResult);
                    result.Add(numbers[i]);
                    return result;
                }
            }

            return null;
        }

        public void RunWithInput(int targetSum, int[] numbers)
        {
            Output = new List<int>();
            StartTime = DateTime.Now;
            Output = SolveOptimized(targetSum, numbers);
            EndTime = DateTime.Now;
            string outputStr = Output != null ? string.Join(",", Output) : "NULL";
            Console.WriteLine($"Input: ({targetSum},[{string.Join(",", numbers)}]), Output: [{outputStr}]");
            ShowTimeTaken();
            Clear();
        }
        public void Clear()
        {
            _memo = new() { };
        }
    }
}
