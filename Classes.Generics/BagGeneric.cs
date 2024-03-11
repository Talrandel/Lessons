using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Generics
{
    class BagGeneric<T>
    {
        private readonly T[] _items;
        public int Index { get; private set; }
        public int Capacity => _items.Length;

        public BagGeneric(int capacity)
        {
            _items = new T[capacity];
            Index = 0;
        }

        public void Put(T obj)
        {
            if (Index >= _items.Length)
            {
                Console.WriteLine("Bag is full!");
                return;
            }
            _items[Index++] = obj;
        }

        public T Take()
        {
            return _items[Index--];
        }
    }
}
