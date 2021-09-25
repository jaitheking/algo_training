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
    }
}
