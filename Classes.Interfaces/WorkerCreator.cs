
using Workers.Interfaces;

namespace Classes.Interfaces
{
    internal static class WorkerCreator
    {
        private static Random _random = new();

        private static readonly string[] Names = { "Вася", "Петя", "Елисей" };
        private static readonly int[] Age = { 18, 25, 40 };
        private static readonly int[] ITN = { 1111, 2222, 3333 };
        private static readonly string[] MachineNames = { "Жигули", "Порше", "Ниссан" };

        public static IWorker CreateWorker()
        {
            int workerType = _random.Next(1, 4);
            if (workerType == 1)
            {
                return new Manager(GetName(), GetAge(), GetITN(), GetProjectsCount());
            }
            else if (workerType == 2)
            {
                return new Driver(GetName(), GetAge(), GetITN(), GetMachineName(), GetHoursCount());
            }
            else if (workerType == 3)
            {
                return new Programmer(GetName(), GetAge(), GetITN(), GetLanguage());
            }

            return default;
        }

        public static IWorker[] CreateWorkerArray(int count)
        {
            IWorker[] workers = new IWorker[count];

            for (int i = 0; i < workers.Length; i++)
            {
                int workerType = _random.Next(1, 4);
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

            return workers;
        }

        private static string GetName()
        {
            return Names[_random.Next(0, Names.Length - 1)];
        }

        private static int GetAge()
        {
            return Age[_random.Next(0, Age.Length - 1)];
        }


        private static int GetITN()
        {
            return ITN[_random.Next(0, ITN.Length - 1)];
        }

        private static string GetMachineName()
        {
            return MachineNames[_random.Next(0, MachineNames.Length - 1)];
        }

        private static int GetProjectsCount()
        {
            return _random.Next(1, 5);
        }

        private static int GetHoursCount()
        {
            return _random.Next(100, 501);
        }

        private static Language GetLanguage()
        {
            return (Language)_random.Next(1, 5);
        }
    }
}