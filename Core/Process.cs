using System;

namespace MiniOS.Core
{
    public class Process
    {
        public enum ProcessState
        {
            New, Ready, Running, Waiting, Terminated
            
        }
        
        public int Pid {get; }
        public String Name {get; }
        public int Priority {get; }
        public int BurstTime {get; }
        private int _remainingTime;
        public int RemainingTime => _remainingTime;

        public ProcessState State {get; private set; }

        public Process(int pid, string name, int priority, int burstTime)
        {
            Pid = pid;
            Name= name;
            Priority=priority;
            BurstTime= burstTime;
            _remainingTime= burstTime;
            State=ProcessState.New;
        }

        public void SetState(ProcessState newState)
        {
            State=newState;
        }

        public void ExecuteOneUnit()
        {
            if(State != ProcessState.Running)
                return;

            if(_remainingTime > 0)
                _remainingTime--;

            if(_remainingTime == 0)
                State = ProcessState.Terminated;
        }

        public override string ToString()
        {
            return $"PID {Pid} , Name: {Name}, State: {State}, Remaining Time: {RemainingTime}";
        }
    }
}
