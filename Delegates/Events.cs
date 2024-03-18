namespace Delegates
{
    class MyMagazine
    {
        public event Action<string> PublishMagazineEvent;

        public string Name { get; set; }

        public MyMagazine(string name)
        {
            Name = name;
        }

        public void Publish()
        {
            PublishMagazineEvent?.Invoke(Name);
        }
    }

    public class Consumer1
    {
        public void ReactToNewMagazine(string name)
        {
            Console.WriteLine($"Consumer1, Ура, вышел новый журнал {name}!");
        } 
    }

    public class Consumer2
    {
        public void ReactToNewMagazine(string name)
        {
            Console.WriteLine($"Consumer2, Ура, вышел новый журнал {name}! Я тоже на него подписался!");
        } 
    }
}