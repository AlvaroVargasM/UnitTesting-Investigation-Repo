using System;

namespace UTestsInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilot p1 = new Pilot("Alvaro","Vargas",true);
            //p1.SetLicense(false);
            
            RaceCar rc1 = new RaceCar(88); 

            if (rc1.CanRace(p1) == true)
            {
                Console.WriteLine("The Pilot " + p1.GetFirstName() + " can compete!");
            }
            else Console.WriteLine("The Pilot " + p1.GetFirstName() + " can't compete");
        }
    }
}
