using System;

public class Zero:Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        System.Console.WriteLine($"Battery Charge {BatteryKWh}");
    }
    public override void Drive()
    {
        Console.WriteLine("Zero zips by you when driving");
    }
    public override void Direction(string direction)
    {
        Console.WriteLine($"Zero turns {direction}");
    }
    public override void Stop()
    {
        Console.WriteLine($"Zero silently rolls to stop.");
    }
}