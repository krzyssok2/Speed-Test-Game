using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestSpeedGame.Models
{
    class ClockModel
    {
        private Stopwatch stopWatch = new Stopwatch();
        public void StartClock()
        {
            stopWatch.Start();
        }
        public void StopClock()
        {
            stopWatch.Stop();
        }
        public double GetTimeInSeconds()
        {
            return stopWatch.Elapsed.TotalSeconds;
        }
        public double GetTimeInMinutes()
        {
            return stopWatch.Elapsed.TotalMinutes;
        }
    }
}
