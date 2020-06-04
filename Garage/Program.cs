using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla tesla = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ram = new Ram();

            System.Console.WriteLine("..........");
            fxs.Drive();
            fxs.Direction("squeals around right turn");
            fxs.Stop();

            System.Console.WriteLine("..........");
            tesla.Drive();
            tesla.Direction("carefully");
            tesla.Stop();

            System.Console.WriteLine("..........");
            mx410.Drive();
            mx410.Direction("not smoothly");
            mx410.Stop();

            System.Console.WriteLine("..........");
            ram.Drive();
            ram.Direction("widely");
            ram.Stop();

        }
    }
}