using System;
using Workers;

namespace Classes.Inheritance
{
    class Program
    {
        static Random random;

        static readonly string[] Names = { "Вася", "Петя", "Елисей" };
        static readonly int[] Age = { 18, 25, 40 };
        static readonly int[] ITN = { 1111, 2222, 3333 };
        static readonly string[] MachineNames = { "Жигули", "Порше", "Ниссан" };


        static void Main(string[] args)
        {
            random = new Random();

            Worker[] workers = new Worker[10];

            for (int i = 0; i < workers.Length; i++)
            {
                int workerType = random.Next(1, 4);
                if (workerType == 1)
                {
                    workers[i] = new Manager(GetName(), GetAge(), GetITN(), GetProjectsCount());
                }
                if (workerType == 2)
                {
                    workers[i] = new Driver(GetName(), GetAge(), GetITN(), GetMachineName(), GetHoursCount());
                }
                if (workerType == 3)
                {
                    workers[i] = new Programmer(GetName(), GetAge(), GetITN(), GetLanguage());
                }
            }

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].ShowInfo();
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        static string GetName()
        {
            return Names[random.Next(0, Names.Length - 1)];
        }

        static int GetAge()
        {
            return Age[random.Next(0, Age.Length - 1)];
        }


        static int GetITN()
        {
            return ITN[random.Next(0, ITN.Length - 1)];
        }

        static string GetMachineName()
        {
            return MachineNames[random.Next(0, MachineNames.Length - 1)];
        }

        static int GetProjectsCount()
        {
            return random.Next(1, 5);
        }

        static int GetHoursCount()
        {
            return random.Next(100, 501);
        }

        static Language GetLanguage()
        {
            return (Language)random.Next(1, 5);
        }
    }
}