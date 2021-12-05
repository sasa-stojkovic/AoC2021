using AOC2021_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_6_Test
{
    [TestClass]
    public class Day6Test
    {
        [TestMethod]
        public void Method1()
        {
            var res1 = Day6.Method1(Day6Inputs.Input1);
            Assert.IsTrue(res1 == 1);

            var res2 = Day6.Method1(Day6Inputs.Input2);
        }

        [TestMethod]
        public void Method2()
        {
            var res1 = Day6.Method2(Day6Inputs.Input1);
            Assert.IsTrue(res1 == 1);

            var res2 = Day6.Method2(Day6Inputs.Input2);
        }
    }
}
