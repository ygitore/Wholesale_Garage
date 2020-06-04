using System;

public class Cessna:Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        System.Console.WriteLine($"Fuel capacity {FuelCapacity}");
    }
    public override void Drive()
    {
        Console.WriteLine("zoom!");
    }
    public override void Direction(string direction)
    {
        Console.WriteLine($"Cessna turns {direction}");
    }
    public override void Stop()
    {
        Console.WriteLine($"The white Cessna rolls to a stop after rolling a mile down the runway.");
    }
}