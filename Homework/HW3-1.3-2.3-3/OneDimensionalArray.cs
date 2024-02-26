namespace HW3_1._3_2._3_3
{
    class OneDimensionalArray
    {
        private int[] _array;

        public OneDimensionalArray(int length, bool isFillUser = false)
        {
            _array = new int[length];
            if (isFillUser)
            {
                FillUser();
            }
            else
            {
                FillRandom();
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing one dimensional array:");
            Print(newArray);
        }        

        public void ReCreate(bool isFillUser = false)
        {
            _array = new int[length];
            if (isFillUser)
            {
                FillUser();
            }
            else
            {
                FillRandom();
            }
        }

        public void RemoveElementsMore100()
        {
            int[] newArray = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                if (Math.Abs(_array[i]) < 100)
                {
                    newArray[i] = _array[i];
                }
                else
                {
                    newArray[i] = int.MinValue;
                }
                // newArray[i] = Math.Abs(_array[i]) < 100
                //     ? _array[i]
                //     : int.MinValue;
            }
            Console.WriteLine("Printing one dimensional array with elements less than 100:");
            Print(newArray);
        }

        private static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == int.MinValue)
                {
                    continue;
                }
                Console.Write($"{array[i]} ")
            }
            Console.WriteLine();            
        }

        private void FillUser()
        {
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = rand.Next(0, 201);
            }
        }

        private void FillRandom()
        {
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"Input {i}-th element of array:")
                _array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}