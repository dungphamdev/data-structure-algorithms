namespace Datastruct.Lib.LinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T> head { get; private set; }

        public void AddFirst(T item)
        {
            var temp = head;

            var newNode = new Node<T>(item);
            head = newNode;

            head.Next = temp;
        }

        public void AddLast(T item)
        {
            var newNode = new Node<T>(item);

            var current = head;

            if (head == null)
            {
                head = new Node<T>(item);
                return;
            }

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void RemoveFirst()
        {
            head = head.Next;
        }

        public void RemoveLast()
        {
            var current = head;
            var nextOfCurrent = current.Next;

            if (nextOfCurrent == null)
            {
                head = null;
            }

            while (nextOfCurrent.Next != null)
            {
                current = current.Next;
                nextOfCurrent = current.Next;
            }

            // current is the n - 1 item
            current.Next = null;
        }

        public int Count()
        {
            var count = 0;

            while (head != null)
            {
                count++;
                head = head.Next;
            }

            return count;
        }

        // TODO: remove by index

        public void PrintList()
        {
            var current = head;
            while (current != null)
            {
                Console.Write($"{current.Value} \t");
                current = current.Next;
            }
        }

    }
}
