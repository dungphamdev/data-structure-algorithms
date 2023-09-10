namespace Datastruct.Lib.Queue
{
    public class ArrayQueue<T>
    {
        private T[] _array;
        private int _capacity;

        private int _head;
        private int _tail;

        public ArrayQueue(int capacity)
        {
            _capacity = capacity;
            _array = new T[_capacity];
            _head = _tail = 0;
        }

        public void Enqueue(T item)
        {
            if (!IsFull())
            {
                _array[_tail] = item;
                _tail++;
                return;
            }
            else
            {
                T[] newArr = new T[_capacity + 1];
                for (int i = 0; i < _capacity; i++)
                {
                    newArr[i] = _array[i];
                }
                newArr[_capacity] = item;
                _capacity++;
                _tail++;
                _array = newArr;
            }
        }

        public void Dequeue()
        {
            _head++;
        }

        public T Peek()
        {
            return _array[_head];
        }

        public bool IsFull()
        {
            return _tail == _capacity;
        }

        public void PrintQueue()
        {
            int current = _head;
            while (current < _tail)
            {
                Console.Write($"{_array[current++]} \t");
            }
            Console.WriteLine();
        }
    }
}
