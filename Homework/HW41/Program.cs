namespace HW41;

class Program
{
    static void Main()
    {
        MyArray<int> arr = [];

        for (int i = 0; i < 5; i++)
        {
            arr.Add(Random.Shared.Next(0, 100));
        }

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        arr.AddRange(arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}