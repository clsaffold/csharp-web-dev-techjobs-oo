using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOONS;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
            Job job2 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
            Assert.AreNotEqual(job1.Id, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.ToString());
            Assert.AreEqual("Desert", job1.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job1.JobType.ToString());
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            
            Job job1 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
            Job job2 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
            Equals(job1, job2);

        }

        [TestMethod]
        public void TestToString()
        {
            Job job1 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString(), job1.ToString());
        }

        [TestMethod]
        public void TestAccurateFields()
        {
            {
                Job job1 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
                Assert.AreEqual(job1.ToString(), ("\n" + "Id: " + job1.Id + "\nName: " + job1.Name.ToString() + "\nEmployer: " + job1.EmployerName.ToString() + "\nLocation: " + job1.EmployerLocation.ToString() + "\nPosition Type: " + job1.JobType.ToString() + "\nCore Competency: " + job1.JobCoreCompetency.ToString() + "\n"));

            }
        }
    }
}
