using System;
using System.Collections.Generic;
using System.Text;

namespace CenturyFromYear
{
    public class CenturyFromYearConversor
    {
        public static int ConvertYear(int number)
        {
            if (number == 100) return 1;
            return number / 100 + 1;
        }

    }
}
