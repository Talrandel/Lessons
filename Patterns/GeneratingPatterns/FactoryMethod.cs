namespace Patterns.GeneratingPatterns;

abstract class Developer
{
    public string Name { get; set; }
 
    public Developer (string n)
    { 
        Name = n; 
    }
    /// <summary>
    /// Фабричный метод
    /// </summary>
    /// <returns></returns>
    abstract public House Create();
}

class PanelDeveloper : Developer
{
    public PanelDeveloper(string n) : base(n)
    { }
 
    public override House Create()
    {
        return new PanelHouse();
    }
}

class WoodDeveloper : Developer
{ 
    public WoodDeveloper(string n) : base(n)
    { }
 
    public override House Create()
    {
        return new WoodHouse();
    }
}
 
abstract class House
{ }
 
class PanelHouse : House 
{ 
    public PanelHouse()
    {
        Console.WriteLine("Панельный дом построен");
    }
}
class WoodHouse : House
{ 
    public WoodHouse()
    {
        Console.WriteLine("Деревянный дом построен");
    }
}