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
            String object = "1";
            Boolean result = Job.Equals(object);
            Assert.AreEqual(result, false);
 //         Assert.IsTrue();
 //         Assert.IsFalse();
        }
    }
}
