using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employer emp = new Employer("HappiestSoft");
            Assert.AreEqual(emp.Value, "HappiestSoft");
        }

        [TestMethod]
        public void testSecondLocationConstructor()
        {
            Location thisLoc = new Location("myFavePlace");
            Assert.AreEqual(thisLoc.Value, "myFavePlace");
            Assert.AreEqual(thisLoc.Id, 1, .001);
        }
    }
}
