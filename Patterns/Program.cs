using Patterns.GeneratingPatterns;

namespace Patterns;

FactoryMethod();


void FactoryMethod()
{
    Developer dev = new PanelDeveloper("ООО КирпичСтрой");
    House house2 = dev.Create();
         
    dev = new WoodDeveloper("Частный застройщик");
    House house = dev.Create();
 
    Console.ReadLine();
}

void AbstractFactory()
{
    Hero archer = new Hero(new ArcherFactory());
    archer.Hit();
    archer.Run();

    Hero warrior = new Hero(new WarriorFactory());
    warrior.Hit();
    warrior.Run();
}

void Singleton()
{
    Computer comp = new Computer();
    comp.Launch("Windows 8.1");
    Console.WriteLine(comp.OS.Name);

    comp.OS = OS.getInstance("Windows 10");
    Console.WriteLine(comp.OS.Name);
}

void Builder()
{
    // https://metanit.com/sharp/patterns/2.5.php
}