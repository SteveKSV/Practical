using System;
using System.Collections.Generic;
using System.Text;
using Work_Force.Interfaces;
namespace Work_Force
{
    public class JobDoneEventArgs : EventArgs
    {
        public JobDoneEventArgs(IJob job)
        {
            this.Job = job;
        }

        public IJob Job { get; }
    }
}
