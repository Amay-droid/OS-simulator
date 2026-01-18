using System;
using MiniOS.Core;

namespace MiniOS.Scheduling
{
    public class FCFSScheduler : Scheduler
    {
        public FCFSScheduler(ProcessManager processManager) : base(processManager)
        {
        }

        public override void Run()
        {
            var readyProcesses = ProcessManager.GetReadyProcess();

            foreach (var process in readyProcesses)
            {
                process.SetState(Process.ProcessState.Running);
                Console.WriteLine($"Running Process PID: {process.Pid}");

                while (process.RemainingTime > 0)
                {
                    process.ExecuteOneUnit();
                }

                process.SetState(Process.ProcessState.Terminated);
                Console.WriteLine($"Process PID {process.Pid} completed.");
            }
        }
    }
}
