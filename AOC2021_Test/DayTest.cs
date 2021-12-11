using AOC2021;
using AOC2021_Test.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AOC2021_Test
{
    [TestClass]
    public class Day1Test
    {
        [TestMethod]
        public void HowManyMeasurementsAreLargerThanThePreviousMeasurement()
        {
            var count1 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement(Day1Inputs.Input1);
            Assert.IsTrue(count1 == 7);

            var count2 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement(Day1Inputs.Input2);
        }

        [TestMethod]
        public void HowManyMeasurementsAreLargerThanThePreviousMeasurement3SlotWindow()
        {
            var count1 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement3SlotWindow(Day1Inputs.Input1);
            Assert.IsTrue(count1 == 5);

            var count2 = Day1.HowManyMeasurementsAreLargerThanThePreviousMeasurement3SlotWindow(Day1Inputs.Input2);
        }
    }

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

    [TestClass]
    public class Day3Test
    {
        [TestMethod]
        public void PowerConsumptionOfTheSubmarine()
        {
            var ret1 = Day3.PowerConsumptionOfTheSubmarine(Day3Inputs.Input1);
            Assert.IsTrue(ret1 == 198);

            var ret2 = Day3.PowerConsumptionOfTheSubmarine(Day3Inputs.Input2);
        }

        [TestMethod]
        public void LifeSupportRating()
        {
            var ret1 = Day3.LifeSupportRating(Day3Inputs.Input1);
            Assert.IsTrue(ret1 == 230);

            var ret2 = Day3.LifeSupportRating(Day3Inputs.Input2);
        }
    }

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

    [TestClass]
    public class Day5Test
    {
        [TestMethod]
        public void HowManyPointsOverlapHV()
        {
            var res1 = Day5.HowManyPointsOverlap(Day5Inputs.Input1, false);
            Assert.IsTrue(res1 == 5);

            var res2 = Day5.HowManyPointsOverlap(Day5Inputs.Input2, false);
        }

        [TestMethod]
        public void HowManyPointsOverlapD()
        {
            var res1 = Day5.HowManyPointsOverlap(Day5Inputs.Input1, true);
            Assert.IsTrue(res1 == 12);

            var res2 = Day5.HowManyPointsOverlap(Day5Inputs.Input2, true);
        }
    }

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

    [TestClass]
    public class Day9Test
    {
        [TestMethod]
        public void SumOfRiskLevelsOfLowPoints()
        {
            var res1 = Day9.SumOfRiskLevelsOfLowPoints(Day9Inputs.Input1);
            Assert.IsTrue(res1 == 15);

            var res2 = Day9.SumOfRiskLevelsOfLowPoints(Day9Inputs.Input2);
        }

        [TestMethod]
        public void MultiplyTogetherSizesOfThreeLargestBasins()
        {
            var res1 = Day9.MultiplyTogetherSizesOfThreeLargestBasins(Day9Inputs.Input1);
            Assert.IsTrue(res1 == 1134);

            var res2 = Day9.MultiplyTogetherSizesOfThreeLargestBasins(Day9Inputs.Input2);
        }
    }

    [TestClass]
    public class Day10Test
    {
        [TestMethod]
        public void TotalSyntaxErrorScore()
        {
            var res1 = Day10.TotalSyntaxErrorScore(Day10Inputs.Input1);
            Assert.IsTrue(res1 == 26397);

            var res2 = Day10.TotalSyntaxErrorScore(Day10Inputs.Input2);
        }

        [TestMethod]
        public void MiddleScore()
        {
            var res1 = Day10.MiddleScore(Day10Inputs.Input1);
            Assert.IsTrue(res1 == 288957);

            var res2 = Day10.MiddleScore(Day10Inputs.Input2);
        }
    }

    [TestClass]
    public class Day11Test
    {
        [TestMethod]
        public void Method1()
        {
            var res1 = Day11.TotalFlashes(Day11Inputs.Input0, 2);
            Assert.IsTrue(res1 == 9);

            res1 = Day11.TotalFlashes(Day11Inputs.Input1, 10);
            Assert.IsTrue(res1 == 204);

            res1 = Day11.TotalFlashes(Day11Inputs.Input1, 100);
            Assert.IsTrue(res1 == 1656);

            var res2 = Day11.TotalFlashes(Day11Inputs.Input2, 100);
        }
    }
}
