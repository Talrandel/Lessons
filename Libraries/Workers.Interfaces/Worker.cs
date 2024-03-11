using System;

using Workers.Interfaces;

namespace Workers.Interfaces
{
    /// <summary>
    /// Сотрудник фирмы ООО "Рога и копыта".
    /// </summary>
    public abstract class Worker : IWorker
    {
        private const double DEFAULT_TAXES = 0.13;

        protected Worker(string name, int age, int itn)
        {
            Name = name;
            Age = age;
            ITN = itn;
        }

        protected Worker()
            : this("Без имени", 25, 0)
        {

        }

        public string Name { get; set; }

        public int Age { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public int ITN { get; set; }

        public abstract int GetSalary();

        public virtual double GetTaxes()
        {
            return DEFAULT_TAXES;
        }

        public virtual void ShowInfo()
        {
            var salary = GetSalary();
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Age = " + Age);
            Console.WriteLine("ITN = " + ITN);
            Console.WriteLine("Salary = " + salary);
            Console.WriteLine("Taxes = " + salary * GetTaxes());
        }
    }
}