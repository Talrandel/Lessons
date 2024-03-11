using System;

namespace Workers.Interfaces
{
    public sealed class Driver : Worker
    {
        public string MachineName { get; set; }

        public int Hours { get; set; }

        public Driver(string name, int age, int itn, string machineName, int hours)
            : base(name, age, itn)
        {
            MachineName = machineName;
            Hours = hours;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("I'm a driver!");
            base.ShowInfo();
            Console.WriteLine("MachineName = " + MachineName);
            Console.WriteLine("Hours = " + Hours);
            Console.WriteLine();
        }

        public override int GetSalary()
        {
            return Hours * 500;
        }
    }
}