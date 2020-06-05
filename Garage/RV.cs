using System;

public class RV : IEngine, IMove, IOccupancy, IAccelerate
{
    public void Engine(string engine)
    {
        System.Console.WriteLine($"RV uses {engine} engine");
    }
    public void Move()
    {
        Console.WriteLine("RV uses wheels to move");
    }
    public void MaxOccupancy(int capacity)
    {
        System.Console.WriteLine($" Maximum occupancy capacity of RV is {capacity} people");
    }
    public void Accelerate()
    {
        System.Console.WriteLine("RV accelarates in any direction");
    }
    public void Doors(int doors){
        System.Console.WriteLine($"RV have {doors} doors");
    }
}