using System;
using System.Security.Cryptography.X509Certificates;

namespace TechJobsOONS
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        //String x = "Data Not Available.";

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }    
       
    // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {

            string s = "\n" + "Id: " + Id + "\nName: " + Name.ToString() + "\nEmployer: " + EmployerName.ToString() + "\nLocation: " + EmployerLocation.ToString() + "\nPosition Type: " + JobType.ToString() + "\nCore Competency: " + JobCoreCompetency.ToString() + "\n";
            s = s.Replace(": \n", ": Data Not Available.\n");
            
            return s;

        }
        
    }
}