using System;
using System.Collections.Generic;
using System.Text;

namespace CenturyFromYear
{
    public class CenturyFromYearConversor
    {
        public static int ConvertYear(int number)
        {
            return number > 100 ? 2 : 1;
        }
    }
}
