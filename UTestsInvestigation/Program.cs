using System;

namespace UTestsInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pilot p1 = new Pilot("Alvaro","Vargas");
            // p1.SetLicenseState(false);
            RaceCar rc1 = new RaceCar(p1, 88); 

            if (rc1.CanRace() == true)
            {
                Console.WriteLine("The Pilot " + rc1.GetCurrentPilot().GetFirstName() + " can compete!");
            }
            else Console.WriteLine("The Pilot " + rc1.GetCurrentPilot().GetFirstName() + " can't compete");
        }
    }
}
