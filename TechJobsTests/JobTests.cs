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
        public void TestJobsForEquality()
        {
            
           Job job1 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
           Job job2 = new Job("CEO", new Employer("ABC Corp"), new Location("Fajardo, PR"), new PositionType("Executive"), new CoreCompetency("Leadership"));
            
            Boolean Equals(object toBeCompared)
            {
                if (toBeCompared == this)
                {
                    return true;
                }

                if (toBeCompared == null)
                {
                    return false;
                }
                
                if (toBeCompared.GetType()  != this.GetType())
                {
                    return false;
                }

                Job job1 = toBeCompared;
                return job1 == job2
            }

        }
    }
}
