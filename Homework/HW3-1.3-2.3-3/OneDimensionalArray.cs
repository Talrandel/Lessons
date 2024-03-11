namespace HW3_1._3_2._3_3
{
    sealed class OneDimensionalArray : ArrayBase
    {
        private int[] _array;
        private static Random _rand = new Random();

        public OneDimensionalArray(bool isFillUser = false)
        {
            ReCreate(isFillUser);
        }

        public override void Print()
        {
            Console.WriteLine("Printing one dimensional array:");
            Print(_array);
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

        protected override void FillUser()
        {
            Console.WriteLine("One dimensional array. Please, input array length > 0:");
            int length = int.Parse(Console.ReadLine());
            _array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Input {i}-th element of array:")
                _array[i] = int.Parse(Console.ReadLine());
            }
        }

        protected override void FillRandom()
        {
            _array = new int[_rand.Next(3, 21)];
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _rand.Next(0, 201);
            }
        }
    }
}