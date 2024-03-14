namespace HW41.Helpers;

internal class EnumerableSorter<TElement, TKey> : EnumerableSorterBase<TElement>
{
    internal Func<TElement, TKey> keySelector;
    internal IComparer<TKey> comparer;
    internal bool descending;
    internal EnumerableSorterBase<TElement> next;
    internal TKey[] keys;

    internal EnumerableSorter(
        Func<TElement, TKey> keySelector,
        IComparer<TKey> comparer,
        bool descending,
        EnumerableSorterBase<TElement> next) 
    {
        this.keySelector = keySelector;
        this.comparer = comparer;
        this.descending = descending;
        this.next = next;
    }

    internal override void ComputeKeys(TElement[] elements, int count)
    {
        keys = new TKey[count];
        for (int i = 0; i < count; i++)
        {
            keys[i] = keySelector(elements[i]);
        }
        next?.ComputeKeys(elements, count);
    }

    internal override int CompareKeys(int index1, int index2)
    {
        int c = comparer.Compare(keys[index1], keys[index2]);
        if (c == 0) 
        {
            return next == null
                ? index1 - index2
                : next.CompareKeys(index1, index2);
        }
        return descending ? -c : c;
    }
}