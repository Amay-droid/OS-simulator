using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MiniOS.Core;

namespace MiniOS.Scheduling
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