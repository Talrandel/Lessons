namespace Classes.Exceptions;

class Program
{
    static void Main()
    {
        int[] someArray = null;

        for (int i = 0; i < 10; i++) 
        {
            someArray[i] = i;
            Console.WriteLine(someArray[i]);
        }

    }
}