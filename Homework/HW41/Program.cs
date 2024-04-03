namespace HW41;

class Program
{
    static void Main()
    {
        MyArray<int> arrInt = new MyArray<int>(1024);
        MyArray<int> arrIntNew = new MyArray<int>();

        for (int i = 0; i < 10; i++)
        {
            arrInt.Add(Random.Shared.Next(0, 501));
            arrIntNew.Add(Random.Shared.Next(0, 501));
        }

        Console.WriteLine("Printing array (method)");
        arrInt.Print(); 

        Console.WriteLine("Printing array (method) (new)");
        arrIntNew.Print();

        Console.WriteLine("Adding new array");
        arrInt.AddRange(arrIntNew);

        Console.WriteLine("Printing array (foreach)");
        foreach (var item in arrInt)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n\n");

        int[] evenValues = arrInt.Where(x => x % 2 == 0);
        Console.WriteLine("Printing array evenValues");
        foreach (var item in evenValues)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n\n");

        bool hasValuesMoreThan400 = arrInt.Any(x => x > 400);
        Console.WriteLine($"hasValuesMoreThan400 - {hasValuesMoreThan400}");
        Console.WriteLine("\n\n");

        int[] squaresLessThan101 = arrInt.Where(x => x * x < 101);
        Console.WriteLine("Printing array squaresLessThan101");
        foreach (var item in squaresLessThan101)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n\n");

        double[] squares = arrInt.Project((x) => Math.Pow(x, 2));
        Console.WriteLine("Printing array squares");
        foreach (var item in squares)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n\n");

        BankAccount[] bankAccounts = arrInt.Project((x) => new BankAccount(x));
        Console.WriteLine("Printing array bankAccounts");
        foreach (var item in bankAccounts)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n\n");

        MyArray<BankAccount> bankAccounts2 = new MyArray<BankAccount>(bankAccounts);
        Console.WriteLine("Printing bankAccounts2");
        bankAccounts2.Print();
        BankAccount[] bankAccountsMoreThan200 = bankAccounts2.Where(x => x.Money > 200);
        Console.WriteLine("Printing array bankAccountsMoreThan200");
        foreach (var item in bankAccountsMoreThan200)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n\n");

        int[] bancAccountsMoneyInts = bankAccounts2.Project(x => Convert.ToInt32(x.Money));
        Console.WriteLine("Printing array bancAccountsMoneyInts");
        foreach (var item in bancAccountsMoneyInts)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n\n");
    }
}