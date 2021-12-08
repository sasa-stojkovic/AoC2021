using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_Test
{
    [TestClass]
    public class Day7Test
    {
        [TestMethod]
        public void HowMuchFuelMustSpendToAlign()
        {
            var res1 = Day7.HowMuchFuelMustSpendToAlign(Day7Inputs.Input1);
            Assert.IsTrue(res1 == 37);

            var res2 = Day7.HowMuchFuelMustSpendToAlign(Day7Inputs.Input2);
        }

        [TestMethod]
        public void HowMuchFuelMustSpendToAlignExp()
        {
            var res1 = Day7.HowMuchFuelMustSpendToAlignExp(Day7Inputs.Input1);
            Assert.IsTrue(res1 == 168);

            var res2 = Day7.HowMuchFuelMustSpendToAlignExp(Day7Inputs.Input2);
        }
    }
}
