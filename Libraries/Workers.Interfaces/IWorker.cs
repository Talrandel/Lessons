namespace Workers.Interfaces
{
    public interface IWorker : IPrinter
    {
        string Name { get; }

        int Age { get; }

        int ITN { get; }

        int GetSalary();

        double GetTaxes();
    }
}