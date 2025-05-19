using System;

public class Wrench : Tool
{
    public Wrench(string name, int kg) : base(name, kg)
    {
    }

    public override void describe()
    {
        Console.WriteLine($"is: {name} is: {kg} kg "); ;
    }

    public override void use()
    {
        Console.WriteLine("is wrench") ;
    }
}