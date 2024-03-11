using System;

namespace Workers.Interfaces
{
    public sealed class Manager : Worker
    {
        public int ProjectCount { get; set; }

        public Manager(string name, int age, int itn, int projectCount)
            : base(name, age, itn)
        {
            ProjectCount = projectCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("I'm a manager!");
            base.ShowInfo();
            Console.WriteLine("ProjectCount = " + ProjectCount);
            Console.WriteLine();
        }

        public override int GetSalary()
        {
            return ProjectCount * 2500;
        }

        public override double GetTaxes()
        {
            return 0.2;
        }
    }
}