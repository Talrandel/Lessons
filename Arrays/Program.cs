using System;
using System.Linq;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static Random _random = new Random();

        static void Main(string[] args)
        {
            // Вводить размер массива с клавиатуры
            int[] array = GetArray(20);
            PrintArray(array);


            GetAverage(array);

            GetArrayAbs100(array);

            GetArrayWithoutDuplicates(array);

            GetAndPrintTwoDimensionalArray();

            GetAndPrintTwoDimensionalArray_Line();

            GetAndPrintTwoDimensionalArray_EvenLines();

            GetAndPrintJaggedArray_Console();

            GetAndPrintJaggedArray_ReplaceEvenValues();
        }

        /// <summary>
        /// Задание один.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static void GetAverage(int[] array)
        {
            Console.WriteLine("\nЗадание один");
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Среднее значение элементов массива: {sum / array.Length}");
        }

        /// <summary>
        /// Задание два.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static void GetArrayAbs100(int[] array)
        {
            Console.WriteLine("\nЗадание два");

            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 100)
                {
                    counter++;
                }
            }

            int[] newArray = new int[counter];
            counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 100)
                {
                    newArray[counter++] = array[i];
                }
            }

            PrintArray(newArray);
        }

        private static int[] GetArrayAbs100_2(int[] array)
        {
            return array
                .Where(x => Math.Abs(x) < 100)
                .ToArray();
        }

        /// <summary>
        /// Задание три.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static void GetArrayWithoutDuplicates(int[] array)
        {
            Console.WriteLine("\nЗадание три");
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
            PrintArray(newArray);
        }

        /// <summary>
        /// Задание четыре и пять.
        /// </summary>
        private static void GetAndPrintTwoDimensionalArray()
        {
            Console.WriteLine("\nЗадание четыре и пять");
            int[,] array = GetTwoDimensionalArray();
            PrintArray(array);
        }

        /// <summary>
        /// Задание шесть.
        /// </summary>
        private static void GetAndPrintTwoDimensionalArray_Line()
        {
            Console.WriteLine("\nЗадание шесть");
            int[,] array = GetTwoDimensionalArray_Line();
            PrintArray(array);
        }

        /// <summary>
        /// Задание семь.
        /// </summary>
        private static void GetAndPrintTwoDimensionalArray_EvenLines()
        {
            Console.WriteLine("\nЗадание семь");
            int[,] array = GetTwoDimensionalArray();
            PrintTwoDimensionalArray_EvenLines(array);
        }

        /// <summary>
        /// Задание восемь.
        /// </summary>
        private static void GetAndPrintJaggedArray_Console()
        {
            Console.WriteLine("\nЗадание восемь");
            int[][] array = GetJaggedArray();
            PrintArray(array);
        }

        /// <summary>
        /// Задание девять.
        /// </summary>
        private static void GetAndPrintJaggedArray_ReplaceEvenValues()
        {
            Console.WriteLine("\nЗадание девять");
            int[][] array = GetJaggedArray();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            PrintArray(array);
        }



        #region Helper methods

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
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void PrintArray(int[][] array)
        {
            foreach (var innerArray in array)
            {
                foreach (var element in innerArray)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void PrintTwoDimensionalArray_EvenLines(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    var element = i % 2 == 0
                        ? array[i, array.GetLength(1) - 1 - j]
                        : array[i, j];
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static int[] GetArray(int arrayLength)
        {
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                int value = _random.Next(0, 10);
                array[i] = value;
            }
            return array;
        }

        private static int[,] GetTwoDimensionalArray()
        {
            Console.WriteLine("Введите количество строк:");
            string rows_str = Console.ReadLine();
            int rows = int.Parse(rows_str);

            Console.WriteLine("Введите количество столбцов:");
            string columns_str = Console.ReadLine();
            int columns = int.Parse(columns_str);

            int[,] array = new int[rows, columns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = _random.Next(-100, 101);
                }
                Console.WriteLine();
            }
            return array;
        }

        private static int[,] GetTwoDimensionalArray_Line()
        {
            Console.WriteLine("Введите количество строк:");
            string rows_str = Console.ReadLine();
            int rows = int.Parse(rows_str);

            Console.WriteLine("Введите количество столбцов:");
            string columns_str = Console.ReadLine();
            int columns = int.Parse(columns_str);

            int[,] array = new int[rows, columns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Введите элементы строки массива через пробел:");
                string[] valuesInLine = Console.ReadLine().Split();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(valuesInLine[j]);
                }
                Console.WriteLine();
            }
            return array;
        }

        private static int[][] GetJaggedArray()
        {
            Console.WriteLine("Введите количество строк:");
            string rows_str = Console.ReadLine();
            int rows = int.Parse(rows_str);

            int[][] array = new int[rows][];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите количество столбцов:");
                string columns_str = Console.ReadLine();
                int columns = int.Parse(columns_str);
                array[i] = new int[columns];

                Console.WriteLine($"Введите построчно элементы массива {i + 1}:");
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return array;
        }

        #endregion
    }
}
