using Datastruct.Lib.LinkedList;

namespace Datastruct.Lib.Stack
{
    public class LinkedListStack<T>
    {
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();
        public bool isEmpty => Count == 0;
        public int Count { get; private set; }

        // Peek
        public T Peek()
        {
            return _list.head.Value;
        }

        // Pop 
        public void Pop(T item)
        {
            _list.RemoveFirst();
        }

        // Push
        public void Push(T item)
        {
            _list.AddFirst(item);
        }

    }
}
