namespace HW3_1._3_2._3_3
{
    class Program
    {
        public static void Main()
        {
            // DoWorkOneDimensionalArray();

            // DoWorkTwoDimensionalArray();

            // DoWorkJaggedArray();

            ArrayBase[] arrays = new ArrayBase[3];
            arrays[0] = new OneDimensionalArray();
            arrays[1] = new TwoDimensionalArray();
            arrays[2] = new JaggedArray();

            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i].Print();

                Console.WriteLine("Recreating array...");
                arrays[i].ReCreate();
                arrays[i].Print();
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        private static void DoWorkOneDimensionalArray()
        {
            // Console.WriteLine("One dimensional array. Please, input array length > 0:");
            // int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, input array fill type: (U) User or (R) Random. Empty string also for random:");
            bool isFillUser = false;
            string fillString = Console.ReadLine();
            if (fillString == "u" || fillString == "U")
            {
                isFillUser = true;
            }

            OneDimensionalArray odArray = new OneDimensionalArray(isFillUser);
            odArray.Print();

            Console.WriteLine("Recreating one dimensional array...");
            odArray.ReCreate(!isFillUser);
            odArray.Print();
        }

        private static void DoWorkTwoDimensionalArray()
        {
        }

        private static void DoWorkJaggedArray()
        {
        }
    }
}