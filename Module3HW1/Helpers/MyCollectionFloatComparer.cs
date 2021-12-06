using System.Collections.Generic;

namespace Module3HW1.Helpers
{
    public class MyCollectionFloatComparer : IComparer<float>
    {
        public int Compare(float x, float y)
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
