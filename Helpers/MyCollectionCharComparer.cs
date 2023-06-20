using System;
using System.Collections.Generic;

namespace Module3HW1.Helpers
{
    public class MyCollectionCharComparer : IComparer<char>
    {
        public int Compare(char x, char y)
        {
            if (x > y)
            {
                return -1;
            }
            else if (x < y)
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
