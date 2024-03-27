
Human petya = new Human { Name = "Petya", Age = 30, Height = 181 };
Human vasya = new Human { Name = "Vasya", Age = 35, Height = 169 };

Console.WriteLine(petya.CompareTo(vasya));
Console.WriteLine(vasya.CompareTo(petya));

//Comparer<Human> comparerHuman = Comparer<Human>.Default;
//Console.WriteLine(comparerHuman.Compare(petya, vasya));

//Comparer<Human> comparerHumanAge = new HumanComparerAge();
//Console.WriteLine(comparerHumanAge.Compare(petya, vasya));

//Comparer<Human> comparerHumanHeight = new HumanComparerHeight();
//Console.WriteLine(comparerHumanHeight.Compare(petya, vasya));

//Comparer<int> comparerAge = Comparer<int>.Default;
//Console.WriteLine(comparerAge.Compare(petya.Age, vasya.Age));


Console.WriteLine(Compare(petya, vasya, (human) => human.Age));
Console.WriteLine(Compare(petya, vasya, (human) => human.Height));
Console.WriteLine(Compare(petya, vasya, (human) => human.Name));


static int Compare<T, TResult>(T item1, T item2, Func<T, TResult> projection)
{
    Comparer<TResult> comparer = Comparer<TResult>.Default;
    return comparer.Compare(projection(item1), projection(item2));
}

class Human : IComparable<Human>
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }

    public int CompareTo(Human other)
    {
        return CompareTo(this, other);
    }

    public static int CompareTo(Human a, Human b)
    {
        if (a == null) 
            return b == null ? 0 : -1;
        if (b == null) 
            return 1;
        if (a.Age == b.Age) 
            return 0;
        if (a.Age > b.Age) 
            return 1;
        return -1;
    }
}

class SomeClass<T> : IComparable<SomeClass<T>>
    where T : IComparable<T>
{
    public T Value { get; set; }

    public int CompareTo(SomeClass<T> other)
    {
        return Value.CompareTo(other.Value);
    }
}

class HumanComparerAge : Comparer<Human>
{
    public override int Compare(Human x, Human y)
    {
        return x.CompareTo(y);
    }
}

class HumanComparerHeight : Comparer<Human>
{
    public override int Compare(Human x, Human y)
    {
        return x.Height.CompareTo(y.Height);
    }
}