using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTestsInvestigation
{
    public class RaceCar
    {
        private int raceCarNumber;

        public RaceCar(int raceCarNumber)
        {
            this.raceCarNumber = raceCarNumber;
        }

        public bool CanRace(Pilot assignedPilot)
        {
            if (assignedPilot.GetLicense() == true)
                return true;
            else return false;
        }
    }
}
