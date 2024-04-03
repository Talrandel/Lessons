
using System;

namespace HW4_1Example;

class Program
{
    static void Main()
    {
        OneDimensionalArray<int> intArray = new OneDimensionalArray<int>(10);
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);
        intArray.Add(157);
        intArray.Add(-777);
        intArray.Add(98);

        // int[] numbers = intArray.Where( (x) => Math.Abs(x) < 100 );
        // Console.WriteLine(string.Join(',', numbers));

        // numbers = intArray.Where( (x) => x % 2 != 0 );
        // Console.WriteLine(string.Join(',', numbers));

        intArray.ForEachAction( (x) => Console.WriteLine(x) );
        intArray.ForEachAction( (x) => 
        {
            double pow = Math.Pow(x, 2);
            Console.WriteLine($"Value = {x}, square = {pow}");
        });


    }    
}

class OneDimensionalArray<T>
{
    private T[] _array;
    private int _capacity;
    private int _size;

    public OneDimensionalArray(int capacity)
    {
        _capacity = capacity;
        _array = new T[capacity];
        _size = 0;
    }

    public OneDimensionalArray() : this(7)
    {
    }

    public void Add(T item)
    {
        if (_size >= _capacity)
        {
            _capacity = _capacity * 2 + 1;
            //T[] newArray = new T[_capacity];
            //Array.CopyTo(newArray, 0, _array, _size);
            //_array = newArray;
            Array.Resize(ref _array, _capacity);
        }
        _array[_size] = item;
        _size++;
    }

    public void AddRange(T[] items)
    {

    }

    public T[] Where(Func<T, bool> condition)
    {
        T[] newArray = new T[_array.Length];
        int count = 0;
        for (int i = 0; i < newArray.Length; i++)
        {
            if (condition(_array[i]))
            {
                newArray[count] = _array[i];
                count++;
            }
        }
        Array.Resize(ref newArray, count);
        return newArray;
    }
    
    // public OneDimensionalArray<T> Where(Func<T, bool> condition)
    // {
    //     OneDimensionalArray newArray = new OneDimensionalArray(_size);
    //     int count = 0;
    //     for (int i = 0; i < newArray.Length; i++)
    //     {
    //         if (condition(_array[i]))
    //         {
    //             newArray[count] = _array[i];
    //             count++;
    //         }
    //     }
    //     Array.Resize(newArray, count);
    //     return newArray;
    // }

    public void ForEachAction(Action<T> action)
    {
        for (int i = 0; i < _array.Length; i++)
        {
            action(_array[i]);
        }
    }

    void DoSomething<T>(T item)
    {

    }
    void AnotherMethod<T>(T item)
    {
        
    }
}