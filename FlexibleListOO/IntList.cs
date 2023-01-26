namespace FlexibleListOO
{
    internal class IntList
    {
        private int[] _numbers;
        private int _count;
        public IntList(int startCapacity = 4)
        {
            _numbers = new int[startCapacity];
        }

        public void Add(int number)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                Resize();
            }
            _numbers[index] = number;
            _count++;
        }

        private void Resize()
        {
            var newNumbers = new int[_numbers.Length * 2];
            Array.Copy(_numbers, newNumbers, _numbers.Length);
            _numbers = newNumbers;
        }

        public void Show()
        {
            Console.WriteLine($"Count={_count}");
            foreach (var n in _numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
