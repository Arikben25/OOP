using System;

public abstract class Tool
{
    protected string name;
    protected int kg;

    public Tool(string name, int kg)
    {
        this.name = name;
        this.kg = kg;
    }

    public abstract void describe();
    public abstract void use();

}
