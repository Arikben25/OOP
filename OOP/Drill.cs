using System;

public class Drill : Tool
{
    public Drill(string name, int kg) : base(name, kg)
    {
    }

    public override void describe()
    {
        Console.WriteLine($"is: {name} is: {kg} kg "); ;
    }

    public override void use()
    {
        Console.WriteLine($"is {name}");
    }
}