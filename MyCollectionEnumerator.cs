namespace Module3HW1
{
    public class MyCollectionEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int _position = -1;
        private int _lastElemetIndex;
        public MyCollectionEnumerator(T[] array, int lastElemetIndex)
        {
            _array = array;
            _lastElemetIndex = lastElemetIndex;
        }

        public object Current
        {
            get
            {
                if (_array == null)
                {
                    throw new NullReferenceException();
                }

                if (_position == -1 || _position >= _array.Length)
                {
                    throw new InvalidOperationException();
                }

                if (_array[_position] == null)
                {
                    throw new NullReferenceException();
                }

                return _array[_position];
            }
        }

        T IEnumerator<T>.Current => _array[_position];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_position < _array.Length - 1 && _position < _lastElemetIndex)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
