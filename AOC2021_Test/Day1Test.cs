using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AOC2021_Test
{
    [TestClass]
    public class Day1Test
    {
        [TestMethod]
        public void HowManyMeasurementsAreLargerThanThePreviousMeasurement()
        {
            var count1 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement(Day1Inputs.Input1);
            Assert.IsTrue(count1 == 7);

            var count2 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement(Day1Inputs.Input2);
        }

        [TestMethod]
        public void HowManyMeasurementsAreLargerThanThePreviousMeasurement3SlotWindow()
        {
            var count1 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement3SlotWindow(Day1Inputs.Input1);
            Assert.IsTrue(count1 == 5);

            var count2 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement3SlotWindow(Day1Inputs.Input2);
        }
    }
}
