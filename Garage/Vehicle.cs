using System;

public class Vehicle
{
    public string Engine { get; set; }
    public string MaximumOccupancy { get; set; }
    public virtual void Move(string direction)
    {
        Console.WriteLine($"Vehicle turns {direction}");
    }
    public virtual void Accelerate()
    {
        Console.WriteLine($"Vehicle very quickly");
    }
}