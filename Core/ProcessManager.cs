using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Diagnostics;


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

        public Process CreateProcess(String name, int priority, int burstTime)
        {
            int pid = _nextPid;
            Process process = new Process(pid,name,priority,burstTime);

            process.SetState(ProcessState.Ready);
            _processTable.Add(process);

            Return process;
        }

        public void KillProcess(int pid)
        {
            foreach (var process  in _processTable)
            {
                if(Process.Pid == pid)
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
            list<process> ReadyProcess = new List<Process>();

            foreach (Var Process in _processTable)
            {
                if(Process.State == Process.GetReadyProcess)
                {
                    Process.SetState(newState);
                }
                else
                {
                    return Console.WriteLine("the process is not sceduled.");
                }
            }
        }
        
        public void displaycurrentprocess()
        {
            Console.WriteLine("the process after the sceduling  ");
            
            
            return _processTable;

        }
    }
}