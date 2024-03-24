// See https://aka.ms/new-console-template for more information


using Collections;

EnumeratorExample example = new EnumeratorExample();

foreach (int item in example)
{
    Console.WriteLine(item + " ");
}

Console.WriteLine("\nSecond foreach\n");

foreach (int item in example)
{
    Console.WriteLine(item + " ");
}

Console.WriteLine();
