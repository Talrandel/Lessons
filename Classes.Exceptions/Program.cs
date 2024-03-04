using System;

namespace Classes.Exceptions;

class Program
{
    static void Main()
    {
        //ExeptionExamples();
        DivideByZeroExeptionExample();


    }

    static void DivideByZeroExeptionExample()
    {
        try
        {
            int a = 5;
            int b = 0;
            int c = a / b; // DivideByZeroException
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Catch ArgumentNullException");
            Console.WriteLine(ex.ToString());
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Catch DivideByZeroException");
            Console.WriteLine(ex.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catch Exception");
            Console.WriteLine(ex.ToString());
        }
    }

    static void ExeptionExamplesWithTryCatch()
    {
        int[] someArray = null;

        for (int i = 0; i < 10; i++)
        {
            someArray[i] = i; // NullReferenceException
            Console.WriteLine(someArray[i]);
        }
    }


    static void ExeptionExamples()
    {
        int[] someArray = null;

        for (int i = 0; i < 10; i++)
        {
            someArray[i] = i; // NullReferenceException
            Console.WriteLine(someArray[i]);
        }

        int a = 5;
        int b = 0;
        int c = a / b; // DividedByZeroException
    }
}