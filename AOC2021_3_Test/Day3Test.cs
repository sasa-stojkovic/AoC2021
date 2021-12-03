using AOC2021_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_3_Test
{
    [TestClass]
    public class Day3Test
    {
        [TestMethod]
        public void PowerConsumptionOfTheSubmarine()
        {
            var ret1 = Day3.PowerConsumptionOfTheSubmarine(Day3Inputs.Input1);
            Assert.IsTrue(ret1 == 198);

            var ret2 = Day3.PowerConsumptionOfTheSubmarine(Day3Inputs.Input2);
        }

        [TestMethod]
        public void LifeSupportRating()
        {
            var ret1 = Day3.LifeSupportRating(Day3Inputs.Input1);
            Assert.IsTrue(ret1 == 230);

            var ret2 = Day3.LifeSupportRating(Day3Inputs.Input2);
        }
    }
}
