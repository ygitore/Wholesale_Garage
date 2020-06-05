using System;

public class MotorCycle: IEngine, IMove, IOccupancy, IAccelerate
{
    public void Engine(string engine)
    {
        System.Console.WriteLine($"MotorCycle uses {engine} engine");
    }
    public void Move()
    {
        Console.WriteLine("MotorCycle uses wheels to move");
    }
    public void MaxOccupancy(int capacity)
    {
        System.Console.WriteLine($" Maximum occupancy capacity for motorcycle is {capacity} people");
    }
    public void Accelerate()
    {
        System.Console.WriteLine("MotorCycle accelarates in any direction");
    }
}