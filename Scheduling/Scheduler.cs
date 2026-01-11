using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MiniOs.Core;

namespace MiniOs.Scheduling
{
    
    public abstract class Scheduler
    {
        protected ProcessManager ProcessManager;

        protected Scheduler(ProcessManager processManager)
        {
            ProcessManager = processManager;
        }

        public abstract void run();
    }
}