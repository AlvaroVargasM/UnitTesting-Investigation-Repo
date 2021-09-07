using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTestsInvestigation
{
    class RaceCar
    {
        private Pilot currentPilot;
        private int raceCarNumber;

        public RaceCar(Pilot assignedPilot, int raceCarNumber)
        {
            this.currentPilot = assignedPilot;
            this.raceCarNumber = raceCarNumber;
        }

        public bool CanRace()
        {
            if (this.currentPilot.GetLicenseState() == true)
            {
                return true;
            }
            else return false;
        }

        public void SetCurrentPilot(Pilot newPilot)
        {
            this.currentPilot = newPilot;
        }

        public Pilot GetCurrentPilot()
        {
            return this.currentPilot;
        }
    }
}
