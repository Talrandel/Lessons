namespace Patterns.GeneratingPatterns;

class Computer
{
    public OS OS { get; set; }
    public void Launch(string osName)
    {
        OS = OS.getInstance(osName);
    }
}
sealed class OS
{
    private static OS instance;
 
    public string Name { get; private set; }
 
    private OS(string name)
    {
        Name = name;
    }
 
    public static OS GetInstance(string name)
    {
        if (instance == null)
            instance = new OS(name);
        return instance;
    }
}