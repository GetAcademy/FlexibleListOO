﻿namespace FlexibleListOO
{
    internal class List<T>
    {
        private T[] _values;
        private int _count;
        public List(int startCapacity = 4)
        {
            _values = new T[startCapacity];
        }

        public void Add(T value)
        {
            var index = _count;
            if (index >= _values.Length)
            {
                Resize();
            }
            _values[index] = value;
            _count++;
        }

        private void Resize()
        {
            var newNumbers = new T[_values.Length * 2];
            Array.Copy(_values, newNumbers, _values.Length);
            _values = newNumbers;
        }

        public void Show()
        {
            Console.WriteLine($"Count={_count}");
            foreach (var n in _values)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
