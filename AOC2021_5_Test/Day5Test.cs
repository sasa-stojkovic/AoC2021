using AOC2021_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_5_Test
{
    [TestClass]
    public class Day5Test
    {
        [TestMethod]
        public void Method1()
        {
            var res1 = Day5.Method1(Day5Inputs.Input1);
            Assert.IsTrue(res1 == 0);

            var res2 = Day5.Method1(Day5Inputs.Input2);
        }

        [TestMethod]
        public void Method2()
        {
            var res1 = Day5.Method2(Day5Inputs.Input1);
            Assert.IsTrue(res1 == 0);

            var res2 = Day5.Method2(Day5Inputs.Input2);
        }
    }
}
