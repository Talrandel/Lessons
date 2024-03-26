using Collections;

EnumeratorStuff();

ListStuff();

static void ListStuff()
{
    List<string> list = new List<string>() { "Tom" };
    ListAdd(list);
    ListRemove(list);
    ListSearch(list);
    ListRange(list);
    ListReverse(list);
}

static void ListAdd(List<string> list)
{
    list.Add("Bob");
    Console.WriteLine(string.Join(',', list));

    list.AddRange(new[] { "Sam", "Alice" });
    Console.WriteLine(string.Join(',', list));

    list.Insert(0, "Eugene");
    Console.WriteLine(string.Join(',', list));

    list.InsertRange(1, new string[] { "Mike", "Kate" });
    Console.WriteLine(string.Join(',', list));

    list.InsertRange(1, new List<string>() { "Mike", "Kate" });
    Console.WriteLine(string.Join(',', list));
}

static void ListRemove(List<string> list)
{
    list.RemoveAt(1);
    Console.WriteLine(string.Join(',', list));

    list.Remove("Tom");
    Console.WriteLine(string.Join(',', list));

    list.RemoveAll(person => person.Length == 3);
    Console.WriteLine(string.Join(',', list));

    list.RemoveRange(1, 2);
    Console.WriteLine(string.Join(',', list));

    list.Clear();
    Console.WriteLine(string.Join(',', list));
}

static void ListSearch(List<string> list)
{
    Console.WriteLine(list.Contains("Bob"));
    Console.WriteLine(list.Contains("Bill"));

    Console.WriteLine(list.Exists(p => p.Length == 3));

    Console.WriteLine(list.Exists(p => p.Length == 7));

    Console.WriteLine(list.Find(p => p.Length == 3));

    Console.WriteLine(list.FindLast(p => p.Length == 3));

    List<string> itemsWithLength3 = list.FindAll(p => p.Length == 3);
    Console.WriteLine(string.Join(',', itemsWithLength3));
}

static void ListReverse(List<string> list)
{
    list.Reverse();
    Console.WriteLine(string.Join(',', list));
    List<string> list2 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
    list2.Reverse(1, 3);
    Console.WriteLine(string.Join(',', list2));
}

static void ListRange(List<string> list)
{
    List<string> range = list.GetRange(1, 3);
    Console.WriteLine(string.Join(',', range));

    string[] partOfList = new string[3];
    list.CopyTo(0, partOfList, 0, 3);
    Console.WriteLine(string.Join(',', partOfList));
}

static void EnumeratorStuff()
{
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
}