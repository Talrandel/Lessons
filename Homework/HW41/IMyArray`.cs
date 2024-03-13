
namespace HW41
{
    internal interface IMyArray<T> : IEnumerable<T>
    {
        int Count { get; }

        bool IsReadOnly { get; }

        T this[int index]
        {
            get;
            set;
        }

        int IndexOf(T item);

        void Insert(int index, T item);

        void RemoveAt(int index);

        void Add(T item);

        void Clear();

        bool Contains(T item);

        void CopyTo(T[] array, int arrayIndex);

        bool Remove(T item);
    }
}