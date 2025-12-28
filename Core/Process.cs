using System;


class Process
{
    public enum ProcessState
    {
        New, Ready, Running, Waiting, Terminated
        
    }
    
    public  int pid {get; }
    public String Name {get; }
    public int Priority {get; }
    public int BrustTime {get; }
    private int _remainingTime;
    public int RemainingTime => _remainingTime;

    public ProcessState State {get; private set; }
    public Process(int pid, string name, int priority, int burstTime)
    {
        Pid = pid;
        Name= name;
        Priority=priority;
        BrustTime=BrustTime;
        _remainingTime= burstTime;
        State=ProcessState.New;
    }
    public void SetState(ProcessState newState)
    {
        State=newState;
    }

}