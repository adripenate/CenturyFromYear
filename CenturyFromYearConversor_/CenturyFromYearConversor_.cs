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
    }
}
