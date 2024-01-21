using System;

namespace Workers
{
    /// <summary>
    /// Сотрудник фирмы ООО "Рога и копыта".
    /// </summary>
    public abstract class Worker
    {
        public string Name { get; set; }

        public int Age { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public int ITN { get; set; }

        public abstract int GetSalary();

        public virtual double GetTaxes()
        {
            return 0.13;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Age = " + Age);
            Console.WriteLine("ITN = " + ITN);
            Console.WriteLine("Salary = " + GetSalary());
            Console.WriteLine("Taxes = " + GetSalary() * GetTaxes());
        }


        public Worker(string name, int age, int itn)
        {
            Name = name;
            Age = age;
            ITN = itn;
        }

        public Worker()
            : this("Без имени", 25, 0)
        {

        }
    }
}