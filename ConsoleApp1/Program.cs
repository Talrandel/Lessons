using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводить размер массива с клавиатуры
            int[] array = GetArray(20);

            // Печать исходного массива
            PrintArray(array);

            int[] newArray = GetArrayWithoutDuplicates(array);

            // Печать результирующего массива
            PrintArray(newArray);
        }

        private static int[] GetArrayWithoutDuplicates(int[] array)
        {
            int newArrayLength = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        newArrayLength--;
                        break;
                    }
                }
            }

            int[] newArray = new int[newArrayLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.MinValue;
            }
            int counter = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (!Exists(array[i], newArray))
                {
                    newArray[counter] = array[i];
                    counter++;
                }
            }
            return newArray;
        }

        private static bool Exists(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] GetArray(int arrayLength)
        {
            Random random = new Random();
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                int value = random.Next(0, 10);
                array[i] = value;
            }
            return array;
        }
    }
}
