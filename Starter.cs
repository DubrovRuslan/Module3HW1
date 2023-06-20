using Module3HW1.Helpers;

namespace Module3HW1
{
    public class Starter
    {
        private readonly MyCollection<int> _myCollection1 = new MyCollection<int>();
        public void Run()
        {
            _myCollection1.Add(4);
            _myCollection1.Add(5);
            _myCollection1.Add(6);
            var myCollection2 = new MyCollection<int> { 1, 2, 3 };
            _myCollection1.AddRange(myCollection2);
            _myCollection1.Sort(new MyCollectionIntComparer());
            foreach (var item in _myCollection1)
            {
                Console.WriteLine(item);
            }

            _myCollection1.Remove(4);
            _myCollection1.RemoveAt(0);
            Console.WriteLine();
            foreach (var item in _myCollection1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
