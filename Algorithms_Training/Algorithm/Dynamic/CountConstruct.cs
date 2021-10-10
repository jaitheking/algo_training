using System;
using System.Collections.Generic;

namespace Algorithms_Training.Algorithm.Dynamic
{
    public class CountConstruct : Algorithm
    {
        int Output { get; set; }
        private static Dictionary<string, int> _memo = new() { };

        /// <summary>
        /// Optimized approach of solving the CountConstruct problem
        /// Time Completixity is O(n*m^2),Space Complexity is O(m^2)
        /// </summary>
        /// <param name="targetWord"></param>
        /// <param name="wordbank"></param>
        /// <returns></returns>
        public int SolveOptimized(string targetWord, string[] wordbank)
        {
            // memoization
            //base case #1 + #2
            if (_memo.ContainsKey(targetWord))
            {
                return _memo[targetWord];
            }

            // traversal method
            //base case #1
            if (targetWord == "")
            {
                return 1;
            }
            int count = 0;
            for (int i = 0; i < wordbank.Length; i++)
            {
                int newCount = 0;
                //Checks for prefix
                if (targetWord.IndexOf(wordbank[i]) == 0)
                {
                    string suffix = targetWord.Substring(wordbank[i].Length);
                    newCount = SolveOptimized(suffix, wordbank);
                    count += newCount;
                }

            }

            _memo[targetWord] = count; //memoize

            //memoize false
            return count;
        }


        /// <summary>
        /// Unoptimized, Based on problem where you need to count of the number of ways the target word can be derived from the wordbank in array
        /// m=target.length, n=wordBank.length, Time Completixity is O(n^m * m (copy)),Space Complexity is O(m)
        /// </summary>
        /// <param name="targetWord"></param>
        /// <param name="wordbank"></param>
        /// <returns></returns>
        public int Solve(string targetWord, string[] wordbank)
        {
            //base case #1
            if (targetWord == "")
            {
                return 1;
            }
            int count = 0;
            for (int i = 0; i < wordbank.Length; i++)
            {
                //Checks for prefix
                if (targetWord.IndexOf(wordbank[i]) == 0)
                {
                    string suffix = targetWord.Substring(wordbank[i].Length);
                    count += Solve(suffix, wordbank);

                }

            }
            return count;
        }

        public void RunWithInput(string targetWord, string[] wordbank)
        {
            StartTime = DateTime.Now;
            Output = SolveOptimized(targetWord, wordbank);
            EndTime = DateTime.Now;
            Console.WriteLine($"Input: ({targetWord},[{string.Join(",", wordbank)}]), Output: {Output}");
            ShowTimeTaken();
            Clear();
        }

        public void Clear()
        {
            _memo = new() { };
        }
    }
}