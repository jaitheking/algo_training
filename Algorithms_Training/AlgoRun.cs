using Algorithms_Training.Algorithm.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Training
{
    public static class AlgoRun
    {
        public static void DoFibonacci()
        {
            Fibonacci newFibonacci = new();
            newFibonacci.RunWithInput(6); //8
            newFibonacci.RunWithInput(7); //13
            newFibonacci.RunWithInput(8); //21
            newFibonacci.RunWithInput(50); //12586269025

        }
        public static void DoGridTraveller()
        {
            GridTraveller newGridTraveller = new();
            newGridTraveller.RunWithInput(1, 1);  //1
            newGridTraveller.RunWithInput(2, 3); //3
            newGridTraveller.RunWithInput(3, 2); //3
            newGridTraveller.RunWithInput(3, 3); //6
            newGridTraveller.RunWithInput(18, 18); //2333606220
        }

        public static void DoCanSum()
        {
            CanSum newCanSum = new();
            newCanSum.RunWithInput(7, new int[] { 2, 3 }); // true
            newCanSum.RunWithInput(7, new int[] { 5, 3, 4, 7 });// true
            newCanSum.RunWithInput(7, new int[] { 2, 4 }); // false
            newCanSum.RunWithInput(8, new int[] { 2, 3, 5 }); // true
            newCanSum.RunWithInput(300, new int[] { 7, 14 }); // false
        }

        public static void DoHowSum()
        {
            HowSum newHowSum = new();
            newHowSum.RunWithInput(7, new int[] { 2, 3 }); // true [3,2,2]
            newHowSum.RunWithInput(7, new int[] { 5, 3, 4, 7 });// true [4,3]
            newHowSum.RunWithInput(7, new int[] { 2, 4 }); // NULL
            newHowSum.RunWithInput(8, new int[] { 2, 3, 5 }); // [2,2,2,2]
            newHowSum.RunWithInput(300, new int[] { 7, 14 }); // NULL
        }

        public static void DoBestSum()
        {
            BestSum newBestSum = new();
            newBestSum.RunWithInput(7, new int[] { 5, 3, 4, 7 }); // true [7]
            newBestSum.RunWithInput(8, new int[] { 2, 3, 5 }); // [3,5]
            newBestSum.RunWithInput(8, new int[] { 1, 4, 5 }); // [4,4]
            newBestSum.RunWithInput(100, new int[] { 1, 2, 5, 25 }); // [25,25,25,25]
        }

        public static void DoCanConstruct()
        {
            CanConstruct newCanConstruct = new();
            newCanConstruct.RunWithInput("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }); // true 
            newCanConstruct.RunWithInput("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }); // false
            newCanConstruct.RunWithInput("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }); // true
            newCanConstruct.RunWithInput("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }); // false
        }

        public static void DoCountConstruct()
        {
            CountConstruct newCountConstruct = new();
            newCountConstruct.RunWithInput("purple", new string[] { "purp", "p", "ur", "le", "purpl" }); // 2
            newCountConstruct.RunWithInput("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }); // 1
            newCountConstruct.RunWithInput("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }); // 0
            newCountConstruct.RunWithInput("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }); // 4
            newCountConstruct.RunWithInput("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }); // 0
        }
        public static void DoAllConstruct()
        {
            AllConstruct newAllConstruct = new();
            newAllConstruct.RunWithInput("purple", new string[] { "purp", "p", "ur", "le", "purpl" }); // [ ['purp','le'],['p','ur','p','le']]
            newAllConstruct.RunWithInput("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd","ef","c" }); // [['ab','cd','ef'],['ab','c','def'],['abc','def'],['abcd','ef']]
            newAllConstruct.RunWithInput("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }); // []
            newAllConstruct.RunWithInput("aaaaaaaaaaaaaaaaaaaaaaaaaaz", new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" }); // []
            
        }
    }
}
