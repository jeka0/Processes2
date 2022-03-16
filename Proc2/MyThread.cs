using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Proc2
{
    public class MyThread
    {
        private Thread thread;
        public void Create(ThreadStart action) { if(thread == null) thread = new Thread(action); }
        public void Run() { thread.Start(); }
        public void Close() 
        {
            if (thread != null)
            {
                thread.Abort();
                thread.Join();
                thread = null;
            }
        }
    }
}
