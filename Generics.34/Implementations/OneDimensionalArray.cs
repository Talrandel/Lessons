using Generics._34.Interfaces;

namespace Generics._34.Implementations
{
    internal class OneDimensionalArray<T> : IArray<T>, IPrinter
    {
        private T[] _items;
        private IArrayValueProvider<T> _valueProvider;

        public int Length { get; }

        public OneDimensionalArray(int length, IArrayValueProvider<T> valueProvider)
        {
            _items = new T[length];
            _valueProvider = valueProvider;
            FillArray();
        }

        private void FillArray()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                _items[i] = _valueProvider.GetRandomValue();
            }
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", _items));
            Console.WriteLine();
        }

        public void ReCreate(int length)
        {
            _items = new T[length];
            FillArray();
        }
    }
}
