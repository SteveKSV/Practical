using System;
using System.Collections.Generic;
using System.Text;
using Work_Force.Employees;
using Work_Force.Interfaces;
namespace Work_Force
{
    public class ExecuteCommands
    {
        public void Execute(string[] input, List<Employee> employees, List<Job> jobs)
        {
            switch (input[0])
            {
                case "Job":

                    for (int i = 0; i < employees.Count; i++)
                    {
                        if(employees[i].Name == input[3])
                        {
                            Job job = new Job(input[1], int.Parse(input[2]), employees[i]);
                            job.JobDone += Program.OnJobDone;
                            jobs.Add(job);
                        } 
                    }
                    break;
                case "StandardEmployee":
                    StandardEmployee sEmployee = new StandardEmployee(input[1]);
                    employees.Add(sEmployee);
                    break;
                case "PartTimeEmployee":
                    PartTimeEmployee ptEmployee = new PartTimeEmployee(input[1]);
                    employees.Add(ptEmployee);
                    break;
                case "Pass":
                    foreach (var job in jobs)
                    {
                        job.Update();
                    }                   
                        break;
                case "Status":
                    foreach (var job in jobs)
                    {
                        if (job.RequiredHoursOfWork != 0 || job.RequiredHoursOfWork < 0)
                        Console.WriteLine(job);
                    }
                    break;
                default: break;
            }
        }
    }
}
