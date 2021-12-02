using AOC2021_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_2_Test
{
    [TestClass]
    public class Day2Test
    {
        [TestMethod]
        public void MultiplyYourFinalHorizontalPositionByYourFinalDepth()
        {
            var res1 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepth(AOC2021_1_Test.Day1Inputs.Input1);
            Assert.IsTrue(res1 == 150);

            var res2 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepth(AOC2021_1_Test.Day1Inputs.Input2);
        }

        
        [TestMethod]
        public void MultiplyYourFinalHorizontalPositionByYourFinalDepthWithAim()
        {
            var res1 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepthWithAim(AOC2021_1_Test.Day1Inputs.Input1);
            Assert.IsTrue(res1 == 900);

            var res2 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepthWithAim(AOC2021_1_Test.Day1Inputs.Input2);
        }
    }
}
