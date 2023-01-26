namespace FlexibleListOO
{
    public class List<T>
    {
        private T[] _values;
        public int Count { get; private set; }

        public T[] Elements
        {
            get
            {
                var elements = new T[Count];
                Array.Copy(_values, elements, Count);
                return elements;
            }
        }

        public List(int startCapacity = 4)
        {
            _values = new T[startCapacity];
        }

        public void Add(T value)
        {
            var index = Count;
            if (index >= _values.Length)
            {
                Resize();
            }
            _values[index] = value;
            Count++;
        }

        private void Resize()
        {
            var newNumbers = new T[_values.Length * 2];
            Array.Copy(_values, newNumbers, _values.Length);
            _values = newNumbers;
        }

        public void Show()
        {
            Console.WriteLine($"Count={Count}");
            foreach (var n in _values)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        public string AsString()
        {
            var text = "";
            for (var index = 0; index < Count; index++)
            {
                var value = _values[index];
                if (index > 0)
                {
                    text += ",";
                }
                text += value;
            }

            return text;
        }
    }
}
