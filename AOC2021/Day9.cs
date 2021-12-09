using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Day9
    {
        public static int SumOfRiskLevelsOfLowPoints(string Input)
        {
            int Result = 0;

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<List<int>> Map = new List<List<int>>();

            foreach (var LineS in LinesS)
            {
                List<int> Row = new List<int>();
                for(int i = 0; i < LineS.Length; i++)
                {
                    var C = LineS[i];
                    Row.Add(Convert.ToInt32(C.ToString()));
                }
                Map.Add(Row);
            }

            for (int i = 0; i < Map.Count; i++)
            {
                for (int j = 0; j < Map[i].Count; j++)
                {
                    int Element = Map[i][j];

                    bool IsLowPoint = true;
                    if (j > 0) { if (Element >= Map[i][j - 1]) IsLowPoint = false; }
                    if (j < Map[i].Count - 1) { if (Element >= Map[i][j + 1]) IsLowPoint = false; }
                    if (i > 0) { if (Element >= Map[i - 1][j]) IsLowPoint = false; }
                    if (i < Map.Count - 1) { if (Element >= Map[i + 1][j]) IsLowPoint = false; }

                    if (IsLowPoint) 
                        Result += 1 + Element;
                }
            }

            return Result;
        }

        public static int MultiplyTogetherSizesOfThreeLargestBasins(string Input)
        {
            int Result = 0;

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<List<int>> Map = new List<List<int>>();

            List<int> BasinSizes = new List<int>();

            foreach (var LineS in LinesS)
            {
                List<int> Row = new List<int>();
                for (int i = 0; i < LineS.Length; i++)
                {
                    var C = LineS[i];
                    Row.Add(Convert.ToInt32(C.ToString()));
                }
                Map.Add(Row);
            }

            for (int i = 0; i < Map.Count; i++)
            {
                for (int j = 0; j < Map[i].Count; j++)
                {
                    int Element = Map[i][j];

                    bool IsLowPoint = true;
                    if (j > 0) { if (Element >= Map[i][j - 1]) IsLowPoint = false; }
                    if (j < Map[i].Count - 1) { if (Element >= Map[i][j + 1]) IsLowPoint = false; }
                    if (i > 0) { if (Element >= Map[i - 1][j]) IsLowPoint = false; }
                    if (i < Map.Count - 1) { if (Element >= Map[i + 1][j]) IsLowPoint = false; }

                    if (IsLowPoint)
                    {
                        BasinSizes.Add(FindBasinSize(Map, i, j, new List<string>()));
                    }
                }
            }

            Result = BasinSizes.OrderByDescending(i => i).Take(3).Aggregate(1, (c,n) => { return c * n; });

            return Result;
        }

        private static int FindBasinSize(List<List<int>> Map, int i, int j, List<string> Previous)
        {
            if (Map[i][j] == 9) return 0;
            else
            {
                Previous.Add($"{i},{j}");

                int res = 1;
                if (j > 0 && !Previous.Contains($"{i},{j - 1}")) { res += FindBasinSize(Map, i, j - 1, Previous); }
                if (j < Map[i].Count - 1 && !Previous.Contains($"{i},{j + 1}")) { res += FindBasinSize(Map, i, j + 1, Previous); }
                if (i > 0 && !Previous.Contains($"{i - 1},{j}")) { res += FindBasinSize(Map, i - 1, j, Previous); }
                if (i < Map.Count - 1 && !Previous.Contains($"{i + 1},{j}")) { res += FindBasinSize(Map, i + 1, j, Previous); }
                return res;
            }
        }
    }
}