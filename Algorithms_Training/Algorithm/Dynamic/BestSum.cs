using System;
using System.Collections.Generic;

namespace Algorithms_Training.Algorithm.Dynamic
{
    public class BestSum : Algorithm
    {
        List<int> Output { get; set; }
        private static Dictionary<int, List<int>> _memo = new() { };

        /// <summary>
        /// Optimized approach of solving the BestSum problem
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
                return new() { };
            }
            // base case #2
            if (targetSum < 0)
            {
                //_memo.Add(targetSum, null);
                return new() { };
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                List<int> remainderResult = SolveOptimized(remainder, numbers);
                if (remainderResult != null)
                {
                    List<int> newCombination = new List<int>();
                    newCombination.AddRange(remainderResult);
                    newCombination.Add(numbers[i]);
                    if (result.Count == 0 || newCombination.Count < result.Count)
                    {
                        result.Clear();
                        result.AddRange(newCombination);
                    }

                }
            }
            _memo.Add(targetSum, result);
            return result;
        }

        /// <summary>
        /// Unoptimized, the problem is finding the shortest combination of elements of an array that adds up to exactly the targetsum 
        /// and return null if no combination is found 
        /// m =target_sum ,n= numbers length
        /// Time Completixity is O(n^m * m),Space Complexity is O(m^2) ** For time complexity, multiply with m due to linear operation,space complexity due to storing the m 
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
                return new List<int>();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                List<int> remainderResult = Solve(remainder, numbers);
                if (remainderResult != null)
                {
                    List<int> newCombination = new List<int>();
                    newCombination.AddRange(remainderResult);
                    newCombination.Add(numbers[i]);
                    if (result.Count == 0 || newCombination.Count < result.Count)
                    {
                        result.Clear();
                        result.AddRange(newCombination);
                    }

                }
            }

            return result;
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
