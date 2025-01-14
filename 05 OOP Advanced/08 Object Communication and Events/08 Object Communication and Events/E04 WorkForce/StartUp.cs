﻿namespace E04_WorkForce
{
    using E04_WorkForce.Employees;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public delegate void JobDoneEventHandler(object sender, JobEventArgs e);

        static void Main(string[] args)
        {
            JobsList jobs = new JobsList();
            List<BaseEmployee> emploees = new List<BaseEmployee>();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Job":
                        Job realJob = new Job(input[1], int.Parse(input[2]), emploees.FirstOrDefault(e => e.Name == input[3]));
                        realJob.JobDone += realJob.OnJobDone;
                        jobs.Add(realJob);
                        break;
                    case "StandartEmployee":
                        emploees.Add(new StandartEmployee(input[1]));
                        break;
                    case "PartTimeEmployee":
                        emploees.Add(new PartTimeEmployee(input[1]));
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
                            if (!job.IsDone)
                            {
                                Console.WriteLine(job.ToString());
                            }
                        }
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
