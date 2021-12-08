using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_Test
{
    [TestClass]
    public class Day8Test
    {
        [TestMethod]
        public void HowManyTimesDigits1478Appear()
        {
            var res1 = Day8.HowManyTimesDigits1478Appear(Day8Inputs.Input1);
            Assert.IsTrue(res1 == 26);

            var res2 = Day8.HowManyTimesDigits1478Appear(Day8Inputs.Input2);
        }

        [TestMethod]
        public void AddUpAllOutputValues()
        {
            var res1 = Day8.AddUpAllOutputValues(Day8Inputs.Input1);
            Assert.IsTrue(res1 == 61229);

            var res2 = Day8.AddUpAllOutputValues(Day8Inputs.Input2);
        }
    }
}
