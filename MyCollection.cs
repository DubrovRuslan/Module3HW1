using System.Collections;

namespace Module3HW1
{
    public class MyCollection<T> : IEnumerable<T>
    {
        private const int BeginSize = 4;
        private const int Multiplier = 2;
        private T[] _array;
        private int _lastElemetIndex;
        public MyCollection()
        {
            _array = new T[BeginSize];
            _lastElemetIndex = -1;
        }

        public int Count
        {
            get
            {
                if (_lastElemetIndex == 0)
                {
                    return 0;
                }

                return _lastElemetIndex + 1;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyCollectionEnumerator<T>(_array, _lastElemetIndex);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var i = 0; i <= _lastElemetIndex; i++)
            {
                if (_array[i] == null)
                {
                    yield return _array[i];
                }
            }
        }

        public void Add(T item)
        {
            _lastElemetIndex++;
            if (_lastElemetIndex >= _array.Length)
            {
                Array.Resize<T>(ref _array, _array.Length * Multiplier);
            }

            _array[_lastElemetIndex] = item;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            var flag = false;
            var position = -1;
            for (var i = 0; i < _lastElemetIndex; i++)
            {
                var comparer = Comparer<T>.Default;
                if (comparer.Compare(item, _array[i]) == 0)
                {
                    position = i;
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                for (var i = position; i < _lastElemetIndex; i++)
                {
                    _array[i] = _array[i + 1];
                }

                _lastElemetIndex--;
            }

            return flag;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= _lastElemetIndex)
            {
                return false;
            }

            for (var i = index; i < _lastElemetIndex; i++)
            {
                _array[i] = _array[i + 1];
            }

            _lastElemetIndex--;
            return true;
        }

        public void Sort(IComparer<T> comparer)
        {
            Array.Sort(_array, 0, _lastElemetIndex + 1, comparer);
        }
    }
}
