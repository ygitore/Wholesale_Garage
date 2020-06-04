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
        Console.WriteLine("zoom!");
    }
}