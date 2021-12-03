using AOC2021_4;
using AOC2021_4_Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC1021_4_Test
{
    [TestClass]
    public class Day4Test
    {
        [TestMethod]
        public void Method1()
        {
            var res1 = Day4.Method1(Day4Inputs.Input1);
            Assert.IsTrue(res1 == 1);

            var res2 = Day4.Method1(Day4Inputs.Input2);
        }

        [TestMethod]
        public void Method2()
        {
            var res1 = Day4.Method2(Day4Inputs.Input1);
            Assert.IsTrue(res1 == 1);

            var res2 = Day4.Method2(Day4Inputs.Input2);
        }
    }
}
