using System;
using System.Collections.Generic;
using System.Text;
using Work_Force.Interfaces;
namespace Work_Force
{
    public delegate void JobDoneEventHandler(object sender, JobDoneEventArgs args);
    public class Job : IJob
    {

        private int requiredHoursOfWork;
        private IEmployee employee;
        public event JobDoneEventHandler JobDone;
        public Job(string name, int requiredHoursOfWork, IEmployee employee)
        {
            this.Name = name;
            this.requiredHoursOfWork = requiredHoursOfWork;
            this.employee = employee;
        }
        public string Name { get; set; }
        public int RequiredHoursOfWork
        {
            get
            {
                return this.requiredHoursOfWork;
            }

            private set
            {
                this.requiredHoursOfWork = value;
                if (this.requiredHoursOfWork <= 0)
                {
                    this.requiredHoursOfWork = 0;
                    Console.WriteLine($"Job {this.Name} done!");
                    this.JobDone?.Invoke(this, new JobDoneEventArgs(this));
                }
            }
        }

        public void Update()
        {
            this.RequiredHoursOfWork -= this.employee.WorkHoursPerWeek;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.RequiredHoursOfWork}";
        }
    }
}
