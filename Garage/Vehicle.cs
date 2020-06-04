using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Direction(string direction)
    {
        Console.WriteLine($"Vehicle turns {direction}");
    }
    public virtual void Stop()
    {
        Console.WriteLine($"Vehicle stops");
    }
}