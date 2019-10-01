using Microsoft.VisualStudio.TestTools.UnitTesting;
using CenturyFromYear;

namespace CenturyFromYearConversor_
{
    [TestClass]
    public class CenturyFromYearConversor_
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, CenturyFromYearConversor.centuryFromYear(1));
        }
    }
}
