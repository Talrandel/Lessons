using System;

namespace Classes.Exceptions;

class Program
{
    static void Main()
    {
        //ExeptionExamples();
        //DivideByZeroExeptionExample();

        Ex13();
    }

    static void Ex1()
    {
        try
        {
        }
        catch
        {
        }
    }

    static void Ex2()
    {
        try
        {
        }
        catch (Exception)
        {
        }
    }

    static void Ex3()
    {
        try
        {
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    static void Ex4()
    {
        try
        {
            throw new Exception("Третий сезон ведьмака");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    static void Ex5()
    {
        try
        {
            throw new ArgumentNullException("Нет интернета на уроке");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    static void Ex6()
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

    static void Ex7()
    {
        try
        {
            throw new Exception("Some exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Throw");
            throw;
        }
    }

    static void Ex8()
    {
        try
        {
            throw new Exception("Some exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Throw ex");
            throw ex;
        }
    }

    static void Ex9()
    {
        try
        {
            throw new Exception("Some exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Throw Another exception");
            throw new Exception("Another exception"); ;
        }
    }

    static void Ex10()
    {
        try
        {
            try
            {
                throw new Exception("Some exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Throw Another exception");
                throw new Exception("Another exception"); ;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catch inner exception");
        }
    }

    static void Ex11()
    {
        try
        {
            throw new Exception("Some exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catch exception");
            return;
        }
        finally 
        {
            Console.WriteLine("Finally выполняется всегда");
        }
    }

    static void Ex12()
    {
        try
        {
            throw new Exception("Some exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catch exception and throw");
            throw;
        }
        finally
        {
            Console.WriteLine("... или не всегда?");
        }
    }

    static void Ex13()
    {
        try
        {
            throw new MyException("Some exception", "Ура. собственное исключение!");
        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

class MyException : Exception
{
    private string _value;
    public MyException(string message, string value) : base(message)
    {
        _value = value;
    }

    public override string Message => base.Message + $", additional info: {_value}";
}