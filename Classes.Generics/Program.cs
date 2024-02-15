using System.Reflection;

namespace Classes.Generics;

class Program
{
    static void Main()
    {
        Bag bag = new Bag(5);

        BagGeneric<int> bagGenericInt = new BagGeneric<int>(5);

        BagGeneric<string> bagGenericString = new BagGeneric<string>(5);

        Type type1 = bagGenericInt.GetType();
        Type type2 = bagGenericString.GetType();
        Type type3 = bag.GetType();

        Console.WriteLine(type1);
        Console.WriteLine(type1.GenericTypeArguments[0]);
        Console.WriteLine(type2);
        Console.WriteLine(type3);
    }
}