using System;

namespace Workers
{
    public enum Language
    {
        CSharp = 1,
        Java,
        Python,
        PHP
    }

    public sealed class Programmer : Worker
    {
        public Language Language { get; set; }

        public Programmer(string name, int age, int itn, Language language)
            : base(name, age, itn)
        {
            Language = language;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("I'm a programmer!");
            base.ShowInfo();
            Console.WriteLine("Language = " + Language);
            Console.WriteLine();
        }

        public override int GetSalary()
        {
            switch (Language)
            {
                case Language.CSharp:
                    return 50000;
                case Language.Java:
                    return 60000;
                case Language.Python:
                    return 45000;
                case Language.PHP:
                    return 20000;
                default:
                    return 0;
            }
        }
    }
}