using System;
using System.Collections.Generic;
using Work_Force.Employees;
using Work_Force.Interfaces;
namespace Work_Force
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            List<Job> jobs = new  List<Job>();
            ExecuteCommands executeCommands = new ExecuteCommands();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "End")
            {
                string[] inputArgs = inputCommand.Split();
                executeCommands.Execute(inputArgs, employees, jobs);
                inputCommand = Console.ReadLine();
            }
            
        }

        public static void OnJobDone(object sender, JobDoneEventArgs args) => Console.WriteLine($"Job {args.Job.Name} done!");
    }
}
