using System;

class OneDimensionalArray
{
    private int[] _array;

    public OneDimensionalArray(int length)
    {
        _array = new int[length];
        Initialize();
    }

    public void Create(int length)
    {
        _array = new int[length];
        Initialize();
    }

    private void Initialize()
    {
        Random random = new Random();
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = random.Next(0, 10);
        }        
    }

    public int Length 
    {
        get
        {
            return _array.Length;
        }        
    }

    public void Print()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine(_array[i] + "\t");
        }
        Console.WriteLine();
    }
}