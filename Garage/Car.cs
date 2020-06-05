using System;

public class Car : IEngine, IAccelerate, IMove, IOccupancy 
{
    public void Engine(string engine)
    {
        System.Console.WriteLine($"Car uses {engine} engine");
    }
    public void Move()
    {
        Console.WriteLine("Cars uses wheels to move");
    }
    public void MaxOccupancy(int capacity)
    {
        System.Console.WriteLine($" Maximum occupancy capacity {capacity} people");
    }
    public void Accelerate()
    {
        System.Console.WriteLine("Accelarate in any direction");
    }
    public void Doors(int doors){
        System.Console.WriteLine($"Cars have {doors} doors");
    }
}

