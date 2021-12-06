using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_Test
{
    [TestClass]
    public class Day7Test
    {
        [TestMethod]
        public void Method1()
        {
            var res1 = Day7.Method1(Day7Inputs.Input1);
            Assert.IsTrue(res1 == 1);

            var res2 = Day7.Method1(Day7Inputs.Input2);
        }
    }
}
