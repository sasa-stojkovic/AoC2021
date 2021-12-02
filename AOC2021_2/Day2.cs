using System;

namespace AOC2021_2
{
    public class Day2
    {
        public static int MultiplyYourFinalHorizontalPositionByYourFinalDepth(string Input)
        {
            Input = Input?.ToLower();
            var ResultH = 0;
            var ResultV = 0;

            var AllLines = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var Line in AllLines)
            {
                var LineCommands = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var Value = Convert.ToInt32(LineCommands[1]);

                switch (LineCommands[0])
                {
                    case "up":
                        ResultV -= Value;
                        break;
                    case "down":
                        ResultV += Value;
                        break;
                    case "forward":
                        ResultH += Value;
                        break;
                }
            }
            var Result = ResultH * ResultV;
            return Result;
        }

        public static int MultiplyYourFinalHorizontalPositionByYourFinalDepthWithAim(string Input)
        {
            Input = Input?.ToLower();
            var ResultH = 0;
            var ResultV = 0;
            var Aim = 0;

            var AllLines = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var Line in AllLines)
            {
                var LineCommands = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var Value = Convert.ToInt32(LineCommands[1]);

                switch (LineCommands[0])
                {
                    case "up":
                        //ResultV -= Value;
                        Aim -= Value;
                        break;
                    case "down":
                        //ResultV += Value;
                        Aim += Value;
                        break;
                    case "forward":
                        ResultH += Value;
                        ResultV += Value * Aim;
                        break;
                }
            }
            var Result = ResultH * ResultV;
            return Result;
        }
    }
}
