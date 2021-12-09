using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employer emp = new Employer("HappiestSoft");
            Assert.AreEqual(emp.Value, "HappiestSoft");
        }

        [TestMethod]
        public void TestSecondLocationConstructor()
        {
            Location thisLoc = new Location("myFavePlace");
            Assert.AreEqual(thisLoc.Value, "myFavePlace");
            Location extraLoc = new Location();
            Assert.AreEqual(thisLoc.Id + 1, extraLoc.Id, .001);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Equals(job2));
            Assert.IsTrue(job2.Id == (job1.Id + 1));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            /*Job constructor: public Job(string name, Employer employerName, Location employerLocation, 
            PositionType jobType, CoreCompetency jobCoreCompetency)*/
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(testJob.Name.Equals("Product tester"));
            Assert.IsTrue(testJob.EmployerName.Value.Equals("ACME"));
            Assert.IsTrue(testJob.EmployerLocation.Value.Equals("Desert"));
            Assert.IsTrue(testJob.JobType.Value.Equals("Quality control"));
            Assert.IsTrue(testJob.JobCoreCompetency.Value.Equals("Persistence"));
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job firstJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job similarJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(firstJob.Equals(similarJob));
        }

        [TestMethod]
        public void TestEscapeStrings()
        {
            string str = "\n";
            int len = str.Length;
            Assert.AreEqual(len, 1, .001);
            Assert.IsTrue(str.Substring(len - 1).Equals("\n"));
            Assert.IsTrue(str.Substring(0, 1).Equals("\n"));
        }

        [TestMethod]
        public void TestJobToString()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string str = testJob.ToString();
            int len = str.Length;
            Assert.IsTrue(str.Substring(len - 1).Equals("\n"));
            Assert.IsTrue(str.Substring(0, 1).Equals("\n"));
            string[] words = str.Split('\n');
            Assert.IsTrue(words[1].Equals($"ID: {testJob.Id}"));
            Assert.IsTrue(words[2].Equals($"Name: {testJob.Name}"));
            /*Job constructor: public Job(string name, Employer employerName, Location employerLocation, 
            PositionType jobType, CoreCompetency jobCoreCompetency)*/
            Assert.IsTrue(words[3].Equals($"Employer: {testJob.EmployerName.Value}"));
            Assert.IsTrue(words[4].Equals($"Location: {testJob.EmployerLocation.Value}"));
            Assert.IsTrue(words[5].Equals($"Position Type: {testJob.JobType.Value}"));
            Assert.IsTrue(words[6].Equals($"Core Competency: {testJob.JobCoreCompetency.Value}"));
        }
    }
}
