namespace HW3_1._3_2._3_3
{
    class Program
    {
        public static void Main()
        {
            DoWorkOneDimensionalArray();

            DoWorkTwoDimensionalArray();

            DoWorkJaggedArray();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        private static void DoWorkOneDimensionalArray()
        {
            Console.WriteLine("One dimensional array. Please, input array length > 0:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, input array fill type: (U) User or (R) Random. Empty string also for random:");
            bool isFillUser = false;
            string fillString = Console.ReadLine();
            if (fillString == "u" || fillString == "U")
            {
                isFillUser = true;
            }

            OneDimensionalArray odArray = new OneDimensionalArray(length, isFillUser);
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