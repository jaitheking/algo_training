using System;


namespace Algorithms_Training.Algorithm
{
    public abstract class Algorithm
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public abstract void Run();
        public abstract void ShowTimeTaken();
    }
}
