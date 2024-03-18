namespace Delegates
{
    class Program
    {
        delegate void MyDelegate();

        delegate void MyDelegate2(int parameter);

        delegate int MyDelegate3();

        delegate int MyDelegate4(int parameter);



        delegate void MyDelegate5<T>(T parameter);

        // delegate void Action<T>(T parameter);
        // delegate void Action<T1, T2>(T1 parameter1, T2 parameter2);

        // delegate TResult Func<T>(T parameter);
        // delegate void Action<T1, T2>(T1 parameter1, T2 parameter2);



        delegate T MyDelegate6<T>();

        delegate TResult MyDelegate7<T, TResult>(T parameter);




        static void DoSomething()
        {
            Console.WriteLine("Blablabla");
        }

        static void KirillAskedForAnotherMethod()
        {
            Console.WriteLine("Yes, delegate can contain more methods");
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

        static void Main()
        {
            //DoSomething();

            //MyDelegate methodPointer = DoSomething;
            // methodPointer += DoSomething;
            // methodPointer += DoSomething;
            // methodPointer += DoSomething;
            // methodPointer += DoSomething;
            // methodPointer();

            // Console.WriteLine();

            // methodPointer -= DoSomething;
            // methodPointer();

            // if (methodPointer != null)
            // {
            //     methodPointer();
            // }
            // methodPointer?.Invoke();

            // MyDelegate method = () => 
            // {
            //     Console.WriteLine("Лямбда!");
            // };
            // method += DoSomething();
            // method?.Invoke();

            // MyDelegate3 intDel = () => 1;
            // intDel += () => 10;
            // intDel += () => 100;
            // int result = intDel();
            // Console.WriteLine(result);

            // methodPointer += method;
            // methodPointer?.Invoke();
            // methodPointer -= method;
            // methodPointer?.Invoke();

            // Action action = () => Console.WriteLine("Action! Лямбда!");
            // action();

            // Action<int> action1 = (x) => Console.WriteLine($"Action<int>! {x}");
            // action1(157);

            // Func<int> func = () => new Random().Next();
            // int result = func();
            // Console.WriteLine(func());

            // Func<int, int> func2 = (x) => 
            // {
            //     int result = x * x;
            //     Console.WriteLine(result);
            //     return result;
            // };
            // func2 += (x) => 
            // {
            //     int result = x * x * x;
            //     Console.WriteLine(result);
            //     return result;
            // };
            //int result = func2(12);
            //Console.WriteLine(func2(12));

            // int[] arrayInt = new int[100];
            // FillArray3(arrayInt, () => Random.Shared.Next(0, int.MaxValue));       
            // Print(arrayInt);
            // Console.WriteLine();
            // FillArray3(arrayInt, () => Random.Shared.Next(int.MinValue, 0));       
            // Print(arrayInt);

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

            // ForEachAction(intArray, (x) => Console.Write(x + " "));
            // ForEachAction(intArray, (x) => 
            // {
            //     double pow = Math.Pow(x, 2);
            //     Console.WriteLine("Value = " + x + ", pow^2 = " + pow);
            // });

            // FillArray(intArray, () => Random.Shared.Next(int.MinValue, 0));
            // Print(intArray);

            // PrintArrayWithCondition(intArray, (x) => x % 2 == 0);
            // PrintArrayWithCondition(intArray, (x) => x > 50);
            // PrintArrayWithCondition(intArray, (x) => x % 2 == 1);

            // ForEachAction(intArray, (x) => 
            // {
            //     double pow = Math.Pow(x, 2);
            //     Console.WriteLine("Value = " + x + ", pow^2 = " + pow);
            // });

            // int[] newArrayNo100 = Where(intArray, (x) => Math.Abs(x) < 100);
            // ForEachAction(newArrayNo100, (x) => Console.Write(x + " "));

            // bool[] boolArray = new bool[100];
            // FillArray(boolArray, () => Random.Shared.Next(0, 2) > 0);
            // PrintArray(boolArray);
            
            // bool[] newBoolArray = Where(boolArray, (x) => x != false);
            // ForEachAction(newBoolArray, (x) => Console.Write(x + " "));

            Events();
        }

        static void Print<T>(T[] array)
        {
            for (int i = 0; i< array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\n");
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

        static void Events()
        {
            MyMagazine magazine = new MyMagazine("пLITка");

            Consumer1 c1 = new Consumer1();
            Consumer2 c2 = new Consumer2();

            magazine.PublishMagazineEvent += c1.ReactToNewMagazine;
            magazine.PublishMagazineEvent += c2.ReactToNewMagazine;

            magazine.Publish();

            Console.WriteLine();

            magazine.Publish();
        }
    }
}