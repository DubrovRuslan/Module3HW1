using System;
using System.Collections.Generic;

namespace Module3HW1.Helpers
{
    public class MyCollectionBoolComparer : IComparer<bool>
    {
        public int Compare(bool x, bool y)
        {
            if (x && !y)
            {
                return -1;
            }
            else if (!x && y)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
