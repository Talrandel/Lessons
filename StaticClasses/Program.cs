using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Static name = {Example.NameStatic}");
            Console.WriteLine();

            Example ex = new Example();
            //ex.NameInstance = "some instance name";

            //Console.WriteLine($"Instance name = {ex.NameInstance}");
            //Console.WriteLine();

            //ex.MethodInstance();
            //Example.MethodStatic();

            //ex = new Example();

            Console.WriteLine($"Static name = {Example.NameStatic}");
            Console.WriteLine();

            ex = new Example("Static name to change");
            Console.WriteLine($"Static name = {Example.NameStatic}");
            Console.WriteLine();

            ex = new Example("Another static name to change!");
            Console.WriteLine($"Static name = {Example.NameStatic}");
            Console.WriteLine();

            Console.WriteLine(Math.PI);

            //MainStaticMethod();
        }

        public void MainInstanceMethod()
        {

        }

        public static void MainStaticMethod()
        {

        }
    }

    class Example
    {
        public string NameInstance { get; set; }

        public static string NameStatic { get; set; }

        public Example()
        {
            Console.WriteLine("Instance constructor");
            Console.WriteLine();
        }

        public Example(string name)
        {
            Console.WriteLine("Instance constructor");
            Console.WriteLine();
            NameStatic = name; 
        }

        static Example()
        {
            NameStatic = "some value";
            Console.WriteLine("Static constructor");
            Console.WriteLine();
        }

        public void MethodInstance()
        {
            Console.WriteLine("Instance method");
            Console.WriteLine();           
        }

        public static void MethodStatic()
        {
            Console.WriteLine("Static method");
            Console.WriteLine();          
        }
    }

    static class OnlyStaticClass
    {
        // public void MethodInstance()
        // {
        //     Console.WriteLine("Instance method");
        //     Console.WriteLine();
        // }

        public static void MethodStatic()
        {
            Console.WriteLine("Static method");
            Console.WriteLine();
        }
    }
}
