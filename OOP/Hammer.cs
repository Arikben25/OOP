using System;

public class Hammer : Tool
{
    public Hammer(string name, int kg) : base(name, kg) { }

    public override void describe()
    {
        Console.WriteLine("hmmer use to drive nails");

    }

    public override void use()
    {
        Console.WriteLine("hmmer is hevi");
    }
}