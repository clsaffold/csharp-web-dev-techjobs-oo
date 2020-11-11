using System;
using System.Collections.Generic;

namespace TechJobsOONS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job("Product Tester", new Employer("Acme"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("Launchcode"), new Location("St. Louis"), new PositionType("Front-end Developer"), new CoreCompetency("Javascript"));
            Job job3 = new Job("Ice Cream Tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting Ability"));

            List <Job> jobs = new List<Job> ();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            jobs.ToString();

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            
        }
    }
}
