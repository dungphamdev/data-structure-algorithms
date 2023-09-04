namespace Datastruct.Lib.Stack
{
    public class ArrayStack<T>
    {
        private int _capacity { get; set; }
        private T[] _array { get; set; }
        private int _current { get; set; }

        public ArrayStack(int capacity)
        {
            _capacity = capacity;
            _array = new T[capacity];

            _current = -1;
        }

        public void Push(T item)
        {
            if ((_current + 1) < _capacity)
            {
                // in of capacity
                _array[_current + 1] = item;
                _current++;
            }
            else
            {
                // out of capacity
                var newArr = new T[_capacity + 1];

                for (int i = 0; i < _capacity; i++)
                {
                    newArr[i] = _array[i];
                }
                newArr[_capacity] = item;

                //assign to new array
                _capacity = _capacity + 1;
                _array = newArr;
                _current = _capacity - 1;
            }
        }

        public T Pop()
        {
            return _array[_current--];
        }

        public T Peek()
        {
            return _array[_current];
        }

        public bool IsEmpty()
        {
            return _current == -1;
        }

        public void PrintStack()
        {
            Console.WriteLine("Stack:");

            int i = _current;

            while (i >= 0)
            {
                Console.WriteLine($"item number {i}: {_array[i]}");
                i--;
            }

            Console.WriteLine("=====");
            Console.WriteLine($"current: {_current}");
            Console.WriteLine($"capacity: {_capacity}");
        }

    }
}
