using System;

public class Scooter : IMove, IOccupancy, IAccelerate
{
    public void Powered(double Battery){
        System.Console.WriteLine($"Scooters take {Battery} volts to be fully charged");
    }
    public void Move()
    {
        Console.WriteLine("Scooters to use Electrically charged battery to move");
    }
  public void MaxOccupancy(int capacity)
    {
        System.Console.WriteLine($" Maximum occupancy capacity {capacity} people");
    }
   public void Accelerate(){
       System.Console.WriteLine("Accelarate in any direction");
   }
}