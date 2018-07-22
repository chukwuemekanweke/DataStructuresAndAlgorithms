using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DataStructureAndAlgorithm
{
    public class Metrics : IDisposable
    {
        private readonly Stopwatch stopWatch = new Stopwatch();
        private readonly string benchMarkName;
        private TimeSpan startTime;
        public Metrics(string benchmarkName)
        {
            benchMarkName = benchmarkName;
            GC.Collect();

            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime; // i being your thread number, make it 0 for main

            stopWatch.Start();

        }

        public void Dispose()
        {

            TimeSpan duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);
            stopWatch.Stop();

            Console.WriteLine($"(With Processor Time) BenchMark: {benchMarkName} Duration: {stopWatch.Elapsed.TotalMilliseconds}");
            Console.WriteLine($"(With Timer) BenchMark: {benchMarkName} Duration: {stopWatch.Elapsed.TotalMilliseconds}");

        }
    }
}
