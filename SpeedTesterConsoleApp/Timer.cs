using System.Diagnostics;

namespace SpeedTesterConsoleApp
{
    public interface ITimer
    {
        void Start();
        long Result();
    }

    public class Timer : ITimer
    {
        private readonly Stopwatch stopwatch;

        public Timer()
        {
            stopwatch = new Stopwatch();
        }

        public void Start()
        {
            stopwatch.Start();
        }

        public long Result()
        {
            var result = stopwatch.ElapsedTicks;
            stopwatch.Reset();
            return result;
        }
    }
}
