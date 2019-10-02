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
        public void given_number_gt_100_and_lt_201_should_return_2()
        {
            Assert.AreEqual(2, CenturyFromYearConversor.ConvertYear(101));
            Assert.AreEqual(2, CenturyFromYearConversor.ConvertYear(110));
            Assert.AreEqual(2, CenturyFromYearConversor.ConvertYear(200));
        }

    }
}
