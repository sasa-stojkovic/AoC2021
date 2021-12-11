using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Day11
    {
        public static int TotalFlashes(string Input, int Steps)
        {
            int Result = 0;
            int FirstStepAllFlash = -1;

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<List<int>> Map = new List<List<int>>();
            List<List<bool>> Reset = new List<List<bool>>();

            foreach (var LineS in LinesS)
            {
                List<int> Row = new List<int>();
                List<bool> ResetRow = new List<bool>();

                for (int i = 0; i < LineS.Length; i++)
                {
                    var C = LineS[i];
                    Row.Add(Convert.ToInt32(C.ToString()));
                    ResetRow.Add(false);
                }
                Map.Add(Row);
                Reset.Add(ResetRow);
            }

            //ticks
            for (var T = 0; T < Steps; T++)
            {
                for (int i = 0; i < Map.Count; i++)
                {
                    for (int j = 0; j < Map[i].Count; j++)
                    {
                        Result += Tick(Map, Reset, i, j);
                    }
                }

                if (FirstStepAllFlash == -1 && Reset.All(r => r.All(c => c))) FirstStepAllFlash = T + 1;

                //reset flashes
                for (int i = 0; i < Reset.Count; i++)
                {
                    for (int j = 0; j < Reset[i].Count; j++)
                    {
                        Reset[i][j] = false;
                    }
                }
            }

            return Result;
        }

        private static int Flash(List<List<int>> Map, List<List<bool>> Reset, int i, int j)
        {
            if (Map[i][j] > 9)
            {
                Map[i][j] = 0;
                Reset[i][j] = true;

                int res = 1;
                if (j > 0) { res += Tick(Map, Reset, i, j - 1); }
                if (j < Map[i].Count - 1) { res += Tick(Map, Reset, i, j + 1); }

                if (i > 0) { res += Tick(Map, Reset, i - 1, j); }
                if (i < Map.Count - 1) { res += Tick(Map, Reset, i + 1, j); }

                if (j > 0 && i > 0) { res += Tick(Map, Reset, i - 1, j - 1); }
                if (j < Map[i].Count - 1 && i < Map.Count - 1) { res += Tick(Map, Reset, i + 1, j + 1); }
                
                if (j < Map[i].Count - 1 && i > 0) { res += Tick(Map, Reset, i - 1, j + 1); }
                if (j > 0 && i < Map.Count - 1) { res += Tick(Map, Reset, i + 1, j - 1); }

                return res;
            }
            return 0;
        }

        private static int Tick(List<List<int>> Map, List<List<bool>> Reset, int i, int j)
        {
            if (!Reset[i][j])
            {
                Map[i][j]++;
                return Flash(Map, Reset, i, j);
            }
            return 0;
        }
    }
}