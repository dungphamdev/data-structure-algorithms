namespace Datastruct.Lib.HashTable
{
    public class HashTable<TKey, TValue>
    {
        //items TODO: convert it to build in Linked List
        private LinkedList<Tuple<TKey, TValue>>[] _items; //array of linkedlist

        int _size;

        public HashTable(int size) 
        {
            // TODO: this is fixed length version, extend to dyamic length later
            _size = size;
            _items = new LinkedList<Tuple<TKey, TValue>>[_size];
        }

        /// <summary>
        /// Handle collision by Chaining method
        /// </summary>
        public void Add(TKey key, TValue value)
        {
            var pos = GetPosition(key);
           
            // nomal case
            if (_items[pos] == null)
            {
                // init new list and add 1st item 
                _items[pos] = new LinkedList<Tuple<TKey, TValue>>();
                _items[pos].AddFirst(new Tuple<TKey, TValue>(key, value));
            } else
            {
                // != null
                // check duplicate
                if (_items[pos].Any(x => x.Item1.Equals(key)))
                {
                    throw new Exception("Duplicate key, cannot insert!");
                } else
                {
                    _items[pos].AddFirst(new Tuple<TKey, TValue>(key, value));
                }
            }
        }

        public void Remove(TKey key)
        {
            var pos = GetPosition(key);
            if (_items[pos] == null || !_items[pos].Any(x => x.Item1.Equals(key)))
            {
                throw new Exception("Key does not exsit on Hash Table");
            }

            var objectToRemove = _items[pos].FirstOrDefault(x => x.Item1.Equals(key));
            if (objectToRemove == null) return;
            _items[pos].Remove(objectToRemove);
        }

        public TValue Get(TKey key)
        {
            var pos = GetPosition(key);

            // O(1) or O(n)
            foreach (var item in _items[pos])
            {
                if (item.Item1.Equals(key))
                {
                    return item.Item2;
                }
            }

            throw new Exception("Key does not exsit on Hash Table");
        }

        private int GetPosition(TKey key)
        {
            var hash = key.GetHashCode();
            return Math.Abs(hash % _items.Length);
        }

        public void PrintHashTable()
        {
            Console.WriteLine(" Hash table:");
            
            foreach (var item in _items) 
            {
                if (item == null) break;

                foreach (var pair in item) Console.WriteLine($"{pair.Item1}: {pair.Item2}");
            }

            Console.WriteLine("-------------------");
        }

    }
}
