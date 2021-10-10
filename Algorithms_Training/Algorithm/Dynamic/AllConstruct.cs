using System;
using System.Collections.Generic;

namespace Algorithms_Training.Algorithm.Dynamic
{
    public class AllConstruct : Algorithm
    {
        int Output { get; set; }
        private static Dictionary<string, List<List<string>>> _memo = new() { };

        /// <summary>
        /// Optimized approach of solving the AllConstruct problem
        /// Time Completixity is O(n*m^2),Space Complexity is O(m^2)
        /// </summary>
        /// <param name="targetWord"></param>
        /// <param name="wordbank"></param>
        /// <returns></returns>
        public List<List<string>> SolveOptimized(string targetWord, string[] wordbank)
        {
            List<List<string>> Result = new List<List<string>>();
            // memo
            if (_memo.ContainsKey(targetWord))
            {
                return _memo[targetWord];
            }

            //base case #1
            if (targetWord == "")
            {
                return new List<List<string>>();
            }
            for (int i = 0; i < wordbank.Length; i++)
            {
                //Checks for prefix
                if (targetWord.IndexOf(wordbank[i]) == 0)
                {
                    string suffix = targetWord.Substring(wordbank[i].Length);
                    List<List<string>> suffixWays = SolveOptimized(suffix, wordbank);
                    if (suffixWays != null)
                    {
                        List<string> targetWays = new List<string>();
                        targetWays.Add(wordbank[i]);
                        if (suffixWays.Count > 0)
                        {
                            targetWays.AddRange(suffixWays[0]);
                        }
                        Result.AddRange(new List<List<string>>() { targetWays });
                    }
                }

            }
            if (Result.Count == 0)
            {
                _memo[targetWord] = null;
                return null;
            }
            _memo[targetWord] = Result;
            return Result;
        }


        /// <summary>
        /// Unoptimized, Based on problem where you need to list all possibile combination of words from the wordbank to form the target word
        /// m=target.length, n=wordBank.length, Time Completixity is O(n^m),Space Complexity is O(m)
        /// </summary>
        /// <param name="targetWord"></param>
        /// <param name="wordbank"></param>
        /// <returns></returns>
        public List<List<string>> Solve(string targetWord, string[] wordbank)
        {
            List<List<string>> Result = new List<List<string>>();
            //base case #1
            if (targetWord == "")
            {
                return new List<List<string>>();
            }
            for (int i = 0; i < wordbank.Length; i++)
            {
                //Checks for prefix
                if (targetWord.IndexOf(wordbank[i]) == 0)
                {
                    string suffix = targetWord.Substring(wordbank[i].Length);
                    List<List<string>> suffixWays = Solve(suffix, wordbank);
                    if (suffixWays != null)
                    {
                        List<string> targetWays = new List<string>();
                        targetWays.Add(wordbank[i]);
                        if (suffixWays.Count > 0)
                        {
                            targetWays.AddRange(suffixWays[0]);
                        }
                        Result.AddRange(new List<List<string>>() { targetWays });
                    }
                }

            }
            if (Result.Count == 0)
            {
                return null;
            }
            return Result;
        }

        public void RunWithInput(string targetWord, string[] wordbank)
        {
            StartTime = DateTime.Now;
            List<List<string>> Output = SolveOptimized(targetWord, wordbank);
            EndTime = DateTime.Now;
            string OutputContents = "";
            if (Output != null)
            {
                foreach (List<string> list in Output)
                {
                    OutputContents += $"[{string.Join(",", list)}],";
                }
                OutputContents = OutputContents.Substring(0, OutputContents.Length - 1);
            }


            Console.WriteLine($"Input: ({targetWord},{string.Join(",", wordbank)}, Output: [{OutputContents}]");
            ShowTimeTaken();
            Clear();
        }

        public void Clear()
        {
            _memo = new() { };
        }
    }
}