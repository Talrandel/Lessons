namespace Delegates
{
    class Program
    {
        static void Main()
        {
            // Action someAction = DoSomething;
            // Func<int> someFunction = GetRandomValue;

            // someAction();

            // int someValue = someFunction();
            // Console.WriteLine(someValue);

            // Console.WriteLine("\n\n\n\n\n");

            // Func<int, int, int> sumDelegate = SumTwoValues;
            // int someSum = sumDelegate(18, 99);
            // Console.WriteLine(someSum);

            // someSum = sumDelegate(1, 2);
            // Console.WriteLine(someSum);

            // someSum = sumDelegate(-100, -5857);
            // Console.WriteLine(someSum);

            // Action someAction = () => Console.WriteLine("Лямбда выражение!");
            // Func<int> someFunction = () => 
            // {
            //     Random rand = new Random();
            //     return rand.Next();
            // };
            // someAction();

            // int someValue = someFunction();
            // Console.WriteLine(someValue);

            // int[] intArray = new int[100];
            // FillArray(intArray, () => Random.Shared.Next(0, 501));
            // Print(intArray);

            // FillArray2(intArray, () => Random.Shared.Next(int.MinValue, 0));
            // Print(intArray);

            // PrintArrayWithCondition<int>(intArray, (x) => x % 2 == 0);
            // PrintArrayWithCondition<int>(intArray, (x) => x > 50);
            // PrintArrayWithCondition<int>(intArray, (x) => x % 2 == 1);

            // ForEachAction<int>(intArray, (x) => 
            // {
            //     double pow = Math.Pow(x, 2);
            //     Console.WriteLine(x + ", pow 2 = " + pow);
            // });

            // int[] newArrayNo100 = Where(intArray, (x) => Math.Abs(x) < 100);
            // ForEachAction<int>(newArrayNo100, (x) => Console.Write(x + " "));

            bool[] boolArray = new bool[100];
            FillArray(boolArray, () => Random.Shared.Next(0, 2) > 0);
            PrintArray(boolArray);
            
            bool[] newBoolArray = Where(boolArray, (x) => x != false);
            ForEachAction(newBoolArray, (x) => Console.Write(x + " "));
        }

        static void FillArray<T>(T[] array, Func<T> fillRandFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = fillRandFunc();
            }
        }

        static void PrintElementsWithCondition(int[] array, Func<int, bool> conditionFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (conditionFunc(array[i]))
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine("\n\n");
        }

        static void PrintArrayWithCondition<T>(T[] array, Func<T, bool> conditionFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (conditionFunc(array[i]))
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void ForEachAction<T>(T[] array, Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                action(array[i]);
            }
        }

        static T[] Where<T>(T[] array, Func<T, bool> conditionFunc)
        {
            T[] newArray = new T[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (conditionFunc(array[i]))
                {
                    newArray[index++] = array[i];
                }
            }
            Array.Resize(ref newArray, index);
            return newArray;
        }


        static void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\n");
        }

        static void DoSomething()
        {
            Console.WriteLine("Blablabla");
        }

        static int GetRandomValue()
        {
            Random rand = new Random();
            return rand.Next();
        }

        static int SumTwoValues(int a, int b)
        {
            return a + b;
        }

    }
}