using AOC2021_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_5_Test
{
    [TestClass]
    public class Day5Test
    {
        [TestMethod]
        public void HowManyPointsOverlapHV()
        {
            var res1 = Day5.HowManyPointsOverlap(Day5Inputs.Input1, false);
            Assert.IsTrue(res1 == 5);

            var res2 = Day5.HowManyPointsOverlap(Day5Inputs.Input2, false);
        }

        [TestMethod]
        public void HowManyPointsOverlapD()
        {
            var res1 = Day5.HowManyPointsOverlap(Day5Inputs.Input1, true);
            Assert.IsTrue(res1 == 12);

            var res2 = Day5.HowManyPointsOverlap(Day5Inputs.Input2, true);
        }
    }
}
