using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindingMaximum
    {
        public int MaxValue(int value1, int value2, int value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
                return value1;
            else if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
                return value2;
            else if (value3.CompareTo(value2) > 0 && value3.CompareTo(value1) > 0)
                return value3;
            else
                return 0;
        }
    }
}
