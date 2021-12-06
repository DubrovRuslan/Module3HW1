using System.Collections.Generic;

namespace Module3HW1.Helpers
{
    public class MyCollectionStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y);
        }
    }
}
