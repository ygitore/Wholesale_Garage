using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Vehicle v1 = new Vehicle();
            fxs.Drive();
            modelS.Drive();
            v1.Drive();
            mx410.Drive();
        }
    }
}