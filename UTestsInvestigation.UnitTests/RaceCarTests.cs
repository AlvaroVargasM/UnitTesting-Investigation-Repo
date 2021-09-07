using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTestsInvestigation;
using System;

namespace UTestsInvestigation.UnitTests
{
    [TestClass]
    public class RaceCarTests
    {
        [TestMethod]
        // public void method_Scenario_ExpectedBehavior
        public void canRace_PilotHasALicense_ReturnsTrue()
        {
            // Arrange
            Pilot p1 = new Pilot("James","Smith",true);
            RaceCar rc1 = new RaceCar(88);

            // Act
            var result = rc1.CanRace(p1);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void canRace_PilotDoesntHaveLicense_ReturnsFalse()
        {
            // Arrange
            Pilot p2 = new Pilot("Irwin", "White", false);
            RaceCar rc1 = new RaceCar(88);

            // Act
            var result = rc1.CanRace(p2);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
