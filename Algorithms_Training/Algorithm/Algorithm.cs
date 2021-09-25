using System;


namespace Algorithms_Training.Algorithm
{
    public class Algorithm
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public void ShowTimeTaken()
        {
            Console.WriteLine($"Time taken for this run :{(EndTime - StartTime).TotalMilliseconds} milliseconds");
        }
    }
}
