using System;
using System.Collections.Generic;

namespace Algorithms_Training.Algorithm.Dynamic
{
    public class CanConstruct : Algorithm
    {
        bool Output { get; set; }
        private static Dictionary<string, bool> _memo = new() { };

        /// <summary>
        /// Optimized approach of solving the CanConstruct problem
        /// Time Completixity is O(n*m^2),Space Complexity is O(m^2)
        /// </summary>
        /// <param name="targetWord"></param>
        /// <param name="wordbank"></param>
        /// <returns></returns>
        public bool SolveOptimized(string targetWord, string[] wordbank)
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
                return true;
            }

            for (int i = 0; i < wordbank.Length; i++)
            {
                //Checks for prefix
                if (targetWord.IndexOf(wordbank[i]) == 0)
                {
                    string suffix = targetWord.Substring(wordbank[i].Length);
                    if (SolveOptimized(suffix, wordbank))
                    {
                        _memo[targetWord] = true;
                        return true;
                    }
                }
            }
            _memo[targetWord] = false; //memoize false
            return false;
        }


        /// <summary>
        /// Unoptimized, Based on problem where you need to confirm the target word can be derived from the wordbank in array
        /// m=target.length, n=wordBank.length, Time Completixity is O(n^m * m (copy)),Space Complexity is O(m)
        /// </summary>
        /// <param name="targetWord"></param>
        /// <param name="wordbank"></param>
        /// <returns></returns>
        public bool Solve(string targetWord, string[] wordbank)
        {
            //base case #1
            if (targetWord == "")
            {
                return true;
            }

            for (int i = 0; i < wordbank.Length; i++)
            {
                //Checks for prefix
                if (targetWord.IndexOf(wordbank[i]) == 0)
                {
                    string suffix = targetWord.Substring(wordbank[i].Length);
                    if (Solve(suffix, wordbank))
                    {
                        return true;
                    }
                }

            }
            return false;
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