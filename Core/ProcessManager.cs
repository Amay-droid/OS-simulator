using System;
using System.Linq.Expressions;


namespace MiniOS.Core
{
    public class ProcessManager
    {
        private readonly List<Process> _processTable;
        private int _nextPid;

        public ProcessManager()
        {
            _processTable = new List<process>();
            _nextPid =1;
        }

        Public Process CreateProcess(String name, int priority, int burstTime)
        {
            int pid = _nextPid;
            Process process = new Process(pid,name,priority,burstTime);

            Process.SetState(ProcessState.Ready);
            _processTable.Add(process);

            Return process;


        }

        public void KillProcess(int pid)
        {
            foreach (var process  in _processTable)
            {
                if(Process.Pid = pid)
                {
                    process.SetState(processState.Terminated);
                    return;
                }
            }
        }

        public List<Process> GetAllProcesses()
        {
            return _processTable;
        }

        public List<Process> GetReadyProcess()
        {
            list<process> ReadyProcess = new List<Process>
        }
    }
}