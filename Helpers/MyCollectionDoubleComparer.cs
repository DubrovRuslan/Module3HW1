using System.Collections.Generic;

namespace Module3HW1.Helpers
{
    public class MyCollectionDoubleComparer : IComparer<double>
    {
        public int Compare(double x, double y)
        {
            if (x < y)
            {
                return -1;
            }
            else if (x > y)
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
