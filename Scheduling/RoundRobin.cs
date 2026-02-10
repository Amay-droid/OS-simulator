using System;
using System.Collections.Generic;
using MiniOS.Core;

namespace MiniOS.Scheduling
{
    public class RoundRobinScheduler : Scheduler
    {
        private readonly int _timeQuantum;

        public RoundRobinScheduler(ProcessManager processManager, int timeQuantum)
            : base(processManager)
        {
            _timeQuantum = timeQuantum;
        }

        public override void Run()
        {
            var readyQueue = new Queue<Process>(ProcessManager.GetReadyProcess());

            while (readyQueue.Count > 0)
            {
                var process = readyQueue.Dequeue();
                process.SetState(Process.ProcessState.Running);
                Console.WriteLine($"Running Process PID: {process.Pid}");

                int timeSlice = Math.Min(_timeQuantum, process.RemainingTime);
                for (int i = 0; i < timeSlice; i++)
                {
                    process.ExecuteOneUnit();
                }

                if (process.RemainingTime == 0)
                {
                    process.SetState(Process.ProcessState.Terminated);
                    Console.WriteLine($"Process PID {process.Pid} completed.");
                }
                else
                {
                    process.SetState(Process.ProcessState.Ready);
                    readyQueue.Enqueue(process);
                }
            }
        }
    }
}
