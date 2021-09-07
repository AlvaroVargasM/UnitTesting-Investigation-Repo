using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTestsInvestigation
{
    public class Pilot
    {
        private string firstName;
        private string lastName;
        private bool licenseState;

        public Pilot(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.licenseState = true;
        }

        public void SetLicenseState(bool newLicenseState)
        {
            this.licenseState = newLicenseState;
        }

        public bool GetLicenseState()
        {
            return this.licenseState;
        }

        public void SetFirstName(string newFirstName)
        {
            this.firstName = newFirstName;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetLastName(string newLastName)
        {
            this.lastName = newLastName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }
    }
}
