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
            _processTable = new List<Process>();
            _nextPid =1;
        }

        public Process CreateProcess(String name, int priority, int burstTime)
        {
            int pid = _nextPid++;
            Process process = new Process(pid,name,priority,burstTime);

            process.SetState(Process.ProcessState.Ready);
            _processTable.Add(process);

            return process;
        }

        public void KillProcess(int pid)
        {
            foreach (var process  in _processTable)
            {
                if(process.Pid == pid)
                {
                    process.SetState(Process.ProcessState.Terminated);
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
            List<Process> ReadyProcess = new List<Process>();

            foreach (var process in _processTable)
            {
                if(process.State == Process.ProcessState.Ready)
                {
                    ReadyProcess.Add(process);
                }
            }

            return ReadyProcess;
        }
        
        public void displaycurrentprocess()
        {
            Console.WriteLine("the process after the sceduling  ");

            foreach (var process in _processTable)
            {
                Console.WriteLine(process);
            }
        }
    }
}
