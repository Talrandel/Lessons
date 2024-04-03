using System.Collections;

namespace HW41
{
    public sealed class MyArray<T> : IEnumerable<T>, IMyArray<T>
        where T: IComparable<T>, IEquatable<T>
    {
        private const int DEFAULT_CAPACITY = 7;
        public const int MAX_ARRAY_LENGTH = int.MaxValue / 4;
        private T[] _items;
        private int _size;

        static readonly T[] _emptyArray = [];

        public MyArray() : this(DEFAULT_CAPACITY) { }

        public MyArray(int capacity)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(capacity);
            _items = capacity == 0 ? _emptyArray : new T[capacity];
        }

        public MyArray(T[] collection)
        {
            ArgumentNullException.ThrowIfNull(collection);
            _items = collection;
            _size = collection.Length;
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

        // TODO: ban modifing array if IsReadOnly == true
        public bool IsReadOnly { get; set; } = false;

        public T this[int index] { get => _items[index]; set => _items[index] = value; }

        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                EnsureCapacity(_size + 1);
            }
            _items[_size++] = item;
        }

        public void AddRange(MyArray<T> collection)
        {
            ArgumentNullException.ThrowIfNull(collection);
            int count = collection.Count;
            if (count > 0)
            {
                EnsureCapacity(_size + count);
                if (_size > 0)
                {
                    Array.Copy(collection._items, 0, _items, _size, count);
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

        public bool All(Func<T, bool> conditionFunc)
        {
            for (int i = 0; i < _size; i++)
            {
                if (!conditionFunc(_items[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Any(Func<T, bool> conditionFunc)
        {
            for (int i = 0; i < _size; i++)
            {
                if (conditionFunc(_items[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public T Average(Func<T[], T> averageFunc)
        {
            ArgumentNullException.ThrowIfNull(averageFunc);
            return averageFunc(_items);            
        }
        
        public void Clear()
        {
            if (_size > 0)
            {
                //Array.Clear(_items, 0, _size);
                _size = 0;
            }
        }

        public int CountByWhere(Func<T, bool> conditionFunc)
        {
            ArgumentNullException.ThrowIfNull(conditionFunc);
            int counter = 0;
            for (int i = 0; i < _size; i++)
            {
                if (conditionFunc(_items[i]))
                {
                    counter++;
                }
            }
            return counter;
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

        public T First(Func<T, bool> conditionFunc = null)
        {
            if (conditionFunc is null && _items[0] is not null)
            {
                return _items[0];
            }

            for (int i = 0; i < _size; i++)
            {
                if (conditionFunc(_items[i]))
                {
                    return _items[i];
                }
            }
            throw new Exception("No elements found by provided condition");
        }

        public T FirstOrDefault(Func<T, bool> conditionFunc = null)
        {
            if (conditionFunc is null && _items[0] is not null)
            {
                return _items[0];
            }

            for (int i = 0; i < _size; i++)
            {
                if (conditionFunc(_items[i]))
                {
                    return _items[i];
                }
            }
            return default;
        }

        public void ForEach(Action<T> action)
        {
            ArgumentNullException.ThrowIfNull(action);

            for (int i = 0; i < _size; i++)
            {
                action(_items[i]);
            }
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(_items, item, 0, _size);
        }

        public void Insert(int index, T item)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(_size, index);
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

        public T Max()
        {
            T max = _items[0];
            for (int i = 1; i < _size; i++)
            {
                if (max.CompareTo(_items[i]) < 0)
                {
                    max = _items[i];
                }
            }
            return max;
        }

        public TResult Max<TResult>(Func<T, TResult> projector) where TResult : IComparable<TResult>
        {
            Comparer<TResult> comparer = Comparer<TResult>.Default;
            TResult max = projector(_items[0]);
            for (int i = 1; i < _size; i++)
            {
                var current = projector(_items[i]);
                if (comparer.Compare(max, current) < 0)
                {
                    max = current;
                }
            }
            return max;
        }

        public TResult Min<TResult>(Func<T, TResult> projector)
        {
            Comparer<TResult> comparer = Comparer<TResult>.Default;
            TResult min = projector(_items[0]);
            for (int i = 1; i < _size; i++)
            {
                var current = projector(_items[i]);
                if (comparer.Compare(min, current) > 0)
                {
                    min = current;
                }
            }
            return min;
        }

        public T Min()
        {
            T min = _items[0];
            for (int i = 1; i < _size; i++)
            {
                if (min.CompareTo(_items[i]) > 0)
                {
                    min = _items[i];
                }
            }
            return min;
        }

        public TResult[] OfType<TResult>()
        {
            TResult[] newArray = new TResult[_size];
            int index = 0;
            for (int i = 0; i < _size; i++)
            {
                if (_items[i] is TResult res)
                {
                    newArray[index++] = res;
                }
            }
            Array.Resize(ref newArray, index);
            return newArray;
        }

        public void Print()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.Write($"{_items[i]} ");
            }
            Console.WriteLine("\n\n");
        }

        public TResult[] Project<TResult>(Func<T, TResult> projector)
        {
            ArgumentNullException.ThrowIfNull(projector);

            TResult[] results = new TResult[_size];
            for (int i = 0; i < _size; i++)
            {
                results[i] = projector(_items[i]);
            }
            return results;            
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
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfNegative(count);
            ArgumentOutOfRangeException.ThrowIfNegative(_size - index - count);

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

        public T[] Take(int startIndex, int count)
        {
            var lastIndex = startIndex + count;
            if (lastIndex > _size)
            {
                lastIndex = _size;
            }
            T[] newArray = new T[count];
            int index = 0;
            for (int i = startIndex; i < lastIndex; i++)
            {
                newArray[index++] = _items[i];
            }
            Array.Resize(ref newArray, index);
            return newArray;
        }

        public T[] Where(Func<T, bool> conditionFunc)
        {
            ArgumentNullException.ThrowIfNull(conditionFunc);
            T[] newArray = new T[_size];
            int index = 0;
            for (int i = 0; i < _size; i++)
            {
                if (conditionFunc(_items[i]))
                {
                    newArray[index++] = _items[i];
                }
            }
            Array.Resize(ref newArray, index);
            return newArray;
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

        #region IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        public struct MyEnumerator : IEnumerator<T>
        {
            private MyArray<T> _array;
            private int _currentIndex;
            private T _current;
 
            internal MyEnumerator(MyArray<T> array)
            {
                _array = array;
                _currentIndex = 0;
                _current = default;
            }
 
            public void Dispose() { }
 
            public bool MoveNext()
            {
                MyArray<T> localArray = _array;
 
                if ((uint)_currentIndex < (uint)localArray._size) 
                {                                                     
                    _current = localArray._items[_currentIndex++];
                    return true;
                }
                // _currentIndex = _array._size + 1;
                // _current = default;
                Reset();
                return false;   
            }
 
            public T Current => _current;

            object IEnumerator.Current 
            {
                get 
                {
                    if(_currentIndex == 0 || _currentIndex == _array._size + 1) 
                    {
                        throw new NullReferenceException(nameof(Current));
                    }
                    return Current;
                }
            }
    
            public void Reset()
            {
                _currentIndex = 0;
                _current = default;
            } 
    
            void IEnumerator.Reset()
            {
                _currentIndex = 0;
                _current = default;
            } 
        }

        #endregion
    }
}