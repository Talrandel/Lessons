using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Generics
{
    class Bag
    {
        private readonly object[] _items;
        public int Index { get; private set; }
        public int Capacity => _items.Length;

        public Bag(int capacity)
        {
            _items = new object[capacity];
            Index = 0;
        }

        public void Put(object obj) 
        {
            if (Index >= _items.Length)
            {
                Console.WriteLine("Bag is full!");
                return;
            }
            _items[Index++] = obj;
        }

        public object Take()
        {
            return _items[Index--];
        }
    }
}
