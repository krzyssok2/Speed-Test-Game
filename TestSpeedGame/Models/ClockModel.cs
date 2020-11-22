using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestSpeedGame.Models
{
    class ClockModel
    {
        private Stopwatch StopWatch = new Stopwatch();
        public void StartClock()
        {
            StopWatch.Start();
        }
        public void StopClock()
        {
            StopWatch.Stop();
        }
        public double GetTimeInSeconds()
        {
            return StopWatch.Elapsed.TotalSeconds;
        }
        public double GetTimeInMinutes()
        {
            return StopWatch.Elapsed.TotalMinutes;
        }
    }
}
