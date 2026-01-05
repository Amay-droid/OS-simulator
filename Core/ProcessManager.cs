using System;
using System.Linq.Expressions;
using System.Xml;
namespace MiniOS.Core
{
    public class ProcessManager
    {
        private readonly List<Process> _processTable;
        private int_nextPid;

        public ProcessManager()
        {
            _processTable = New List<process>();
            _nextPid =1;
        }
    }
}