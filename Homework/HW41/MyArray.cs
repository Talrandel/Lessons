using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW41
{
    public sealed class MyArray<T> : IEnumerable<T>, IEnumerator<T>, IMyArray<T>
        where T: IComparable, IComparable<T>, IEquatable<T>
    {
        private const int DEFAULT_CAPACITY = 7;
        public const int MAX_ARRAY_LENGTH = int.MaxValue / 4;
        private T[] _items;
        private int _capacity;
        private int _size;

        static readonly T[] _emptyArray = [];

        public MyArray() : this(DEFAULT_CAPACITY)
        {
        }

        public MyArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }
            _capacity = capacity;
            _items = capacity == 0 ? _emptyArray : new T[_capacity];
        }

        public MyArray(T[] collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            _capacity = collection.Length;
            _items = collection;
        }

        public int Count => _size;

        public int Capacity
        {
            get
            {
                return _items.Length;
            }
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, _size);

                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, 0, newItems, 0, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = _emptyArray;
                    }
                }
            }
        }

        public bool IsReadOnly { get; set; } = false;

        public T this[int index]
        {
            get => _items[index];

            set => _items[index] = value;
        }

        public void Clear()
        {
            if (_size > 0)
            {
                Array.Clear(_items, 0, _size);
                _size = 0;
            }
        }
        public bool Contains(T item)
        {
            if (item == null)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_items[i] == null)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                EqualityComparer<T> c = EqualityComparer<T>.Default;
                for (int i = 0; i < _size; i++)
                {
                    if (c.Equals(_items[i], item))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_items, 0, array, arrayIndex, _size);
        }

        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                EnsureCapacity(_size + 1);
            }
            _items[_size++] = item;
        }

        public void AddRange(T[] collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            int count = collection.Length;
            if (count > 0)
            {
                EnsureCapacity(_size + count);
                if (0 < _size)
                {
                    Array.Copy(_items, 0, _items, 0 + count, _size);
                }

                if (_items == collection)
                {
                    Array.Copy(_items, 0, _items, 0, 0);
                    Array.Copy(_items, 0 + count, _items, 0 * 2, _size);
                }
                else
                {
                    T[] itemsToInsert = new T[count];
                    collection.CopyTo(itemsToInsert, 0);
                    itemsToInsert.CopyTo(_items, 0);
                }
                _size += count;
            }
        }

        public void Insert(int index, T item)
        {
            if ((uint)index > (uint)_size)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(index, _size);
            }
            if (_size == _items.Length)
            {
                EnsureCapacity(_size + 1);
            }

            if (index < _size)
            {
                Array.Copy(_items, index, _items, index + 1, _size - index);
            }
            _items[index] = item;
            _size++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            _size--;
            if (index < _size)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }
            _items[_size] = default;
        }

        public void RemoveRange(int index, int count)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (_size - index < count)
            {
                throw new ArgumentException("Invalid length");
            }

            if (count > 0)
            {
                _size -= count;
                if (index < _size)
                {
                    Array.Copy(_items, index + count, _items, index, _size - index);
                }
                Array.Clear(_items, _size, count);
            }
        }

        public void Reverse()
        {
            Array.Reverse(_items, 0, Count);
        }

        public void Sort(IComparer<T> comparer = null)
        {
            Array.Sort(_items, 0, Count, comparer);
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(_items, item, 0, _size);
        }

        private void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity = _items.Length == 0 ? DEFAULT_CAPACITY : _items.Length * 2 + 1;
                if ((uint)newCapacity > MAX_ARRAY_LENGTH)
                {
                    newCapacity = MAX_ARRAY_LENGTH;
                }

                if (newCapacity < min)
                {
                    newCapacity = min;
                }

                Capacity = newCapacity;
            }
        }

        #region Methods linq

        public void ForEach(Action<T> action)
        {
            ArgumentNullException.ThrowIfNull(action);

            for (int i = 0; i < _size; i++)
            {
                action(_items[i]);
            }
        }

        // order by
        // skip
        // take
        // where
        // project
        // any
        // all
        // distinct
        // except
        // oftype
        // first
        // firstOrDefault
        // Range
        // Count
        // Contains
        // sum
        // min / max
        // average


        #endregion

        #region IEnumerator

        public T Current { get; }
        object IEnumerator.Current { get; }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
