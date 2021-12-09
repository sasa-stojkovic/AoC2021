using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_Test
{
    [TestClass]
    public class Day9Test
    {
        [TestMethod]
        public void SumOfRiskLevelsOfLowPoints()
        {
            var res1 = Day9.SumOfRiskLevelsOfLowPoints(Day9Inputs.Input1);
            Assert.IsTrue(res1 == 15);

            var res2 = Day9.SumOfRiskLevelsOfLowPoints(Day9Inputs.Input2);
        }

        [TestMethod]
        public void MultiplyTogetherSizesOfThreeLargestBasins()
        {
            var res1 = Day9.MultiplyTogetherSizesOfThreeLargestBasins(Day9Inputs.Input1);
            Assert.IsTrue(res1 == 1134);

            var res2 = Day9.MultiplyTogetherSizesOfThreeLargestBasins(Day9Inputs.Input2);
        }
    }
}
