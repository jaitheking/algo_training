using Algorithms_Training.Algorithm.Dynamic;
using System;

namespace Algorithms_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoFibonacci();
            DoGridTraveller();
            //Console.ReadKey(); 
        }


        public static void DoFibonacci()
        {
            Fibonacci newFib = new Fibonacci();
            newFib.RunWithInput(6); //8
            newFib.RunWithInput(7); //13
            newFib.RunWithInput(8); //21
            newFib.RunWithInput(50); //12586269025

        }
        public static void DoGridTraveller()
        {
            GridTraveller gridTraveller = new GridTraveller();
            gridTraveller.RunWithInput(1, 1);  //1
            gridTraveller.RunWithInput(2, 3); //3
            gridTraveller.RunWithInput(3, 2); //3
            gridTraveller.RunWithInput(3, 3); //6
            gridTraveller.RunWithInput(18, 18); //2333606220
        }

    }
}
