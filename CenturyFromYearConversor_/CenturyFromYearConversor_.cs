using Microsoft.VisualStudio.TestTools.UnitTesting;
using CenturyFromYear;

namespace CenturyFromYearConversor_
{
    [TestClass]
    public class CenturyFromYearConversor_
    {
        [TestMethod]
        public void given_1_should_return_1()
        {
            Assert.AreEqual(1, CenturyFromYearConversor.centuryFromYear(1));
        }

        [TestMethod]
        public void given_10_should_return_1()
        {
            Assert.AreEqual(1, CenturyFromYearConversor.centuryFromYear(10));
        }

        [TestMethod]
        public void given_100_should_return_1()
        {
            Assert.AreEqual(1, CenturyFromYearConversor.centuryFromYear(100));
        }
    }
}
