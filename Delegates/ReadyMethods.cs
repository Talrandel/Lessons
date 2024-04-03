using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal static class ReadyMethods
    {
        public static void PrintElementsWithCondition(int[] array, Func<int, bool> conditionFunc)
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

        public static void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\n");
        }

        public static void FillArray<T>(T[] array, Func<T> fillRandFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = fillRandFunc();
            }
        }

        public static void PrintArrayWithCondition<T>(T[] array, Func<T, bool> conditionFunc)
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

        public static void ForEachAction<T>(T[] array, Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                action(array[i]);
            }
        }

        public static T[] Where<T>(T[] array, Func<T, bool> conditionFunc)
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
    }
}
