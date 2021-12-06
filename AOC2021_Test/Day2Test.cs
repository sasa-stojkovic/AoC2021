using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_Test
{
    [TestClass]
    public class Day2Test
    {
        [TestMethod]
        public void MultiplyYourFinalHorizontalPositionByYourFinalDepth()
        {
            var res1 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepth(Day2Inputs.Input1);
            Assert.IsTrue(res1 == 150);

            var res2 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepth(Day2Inputs.Input2);
        }

        
        [TestMethod]
        public void MultiplyYourFinalHorizontalPositionByYourFinalDepthWithAim()
        {
            var res1 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepthWithAim(Day2Inputs.Input1);
            Assert.IsTrue(res1 == 900);

            var res2 = Day2.MultiplyYourFinalHorizontalPositionByYourFinalDepthWithAim(Day2Inputs.Input2);
        }
    }
}
