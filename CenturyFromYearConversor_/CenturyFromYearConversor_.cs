using Microsoft.VisualStudio.TestTools.UnitTesting;
using CenturyFromYear;

namespace CenturyFromYearConversor_
{
    [TestClass]
    public class CenturyFromYearConversor_
    {
        [TestMethod]
        public void given_number_less_than_100_should_return_1()
        {
            Assert.AreEqual(1, CenturyFromYearConversor.ConvertYear(1));
            Assert.AreEqual(1, CenturyFromYearConversor.ConvertYear(10));
            Assert.AreEqual(1, CenturyFromYearConversor.ConvertYear(100));
        }

        [TestMethod]
        public void given_101_should_return_2()
        {
            Assert.AreEqual(2, CenturyFromYearConversor.ConvertYear(101));
        }
    }
}
