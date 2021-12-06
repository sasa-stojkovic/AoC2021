using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC2021_Test
{
    [TestClass]
    public class Day4Test
    {
        [TestMethod]
        public void FinalScore()
        {
            var res1 = Day4.FinalScore(Day4Inputs.Input1A, Day4Inputs.Input1B);
            Assert.IsTrue(res1 == 4512);

            var res2 = Day4.FinalScore(Day4Inputs.Input2A, Day4Inputs.Input2B);
        }

        [TestMethod]
        public void FinalScoreLastToWin()
        {
            var res1 = Day4.FinalScoreLastToWin(Day4Inputs.Input1A, Day4Inputs.Input1B);
            Assert.IsTrue(res1 == 1924);

            var res2 = Day4.FinalScoreLastToWin(Day4Inputs.Input2A, Day4Inputs.Input2B);
        }
    }
}
