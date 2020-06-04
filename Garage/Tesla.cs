using System;

public class Tesla:Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        System.Console.WriteLine($"Your tesla is charged to {BatteryKWh}");
    }
    public override void Drive()
    {
        Console.WriteLine("Tesla blazes by you when driving");
    }
    public override void Direction(string direction)
    {
        Console.WriteLine($"Tesla turns {direction}");
    }
     public override void Stop()
    {
        Console.WriteLine($"Tesla gently rolls to stop.");
    }
}