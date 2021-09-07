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
        private bool license;

        public Pilot(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.license = true;
        }

        public void SetLicense(bool newLicenseState)
        {
            this.license = newLicenseState;
        }

        public bool GetLicense()
        {
            return this.license;
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