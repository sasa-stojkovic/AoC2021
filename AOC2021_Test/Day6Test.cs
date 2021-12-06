using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_Test
{
    [TestClass]
    public class Day6Test
    {
        [TestMethod]
        public void HowManyLanternfishWouldThereBe()
        {
            var res1 = Day6.HowManyLanternfishWouldThereBe("1", 5);
            Assert.IsTrue(res1 == 2);

            res1 = Day6.HowManyLanternfishWouldThereBe(Day6Inputs.Input1, 18);
            Assert.IsTrue(res1 == 26);

            res1 = Day6.HowManyLanternfishWouldThereBe(Day6Inputs.Input1, 80);
            Assert.IsTrue(res1 == 5934);

            res1 = Day6.HowManyLanternfishWouldThereBe(Day6Inputs.Input1, 256);
            Assert.IsTrue(res1 == 26984457539);

            var res2 = Day6.HowManyLanternfishWouldThereBe(Day6Inputs.Input2, 256);
        }
    }
}
