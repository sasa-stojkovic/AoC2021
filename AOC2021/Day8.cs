using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Day8
    {
        public static int HowManyTimesDigits1478Appear(string Input)
        {
            int Result = 0;

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> Map = new Dictionary<string, int>();

            foreach (var Line in LinesS)
            {
                var SegmentsS = Line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var Digits = SegmentsS[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var Output = SegmentsS[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (var Out in Output)
                {
                    if (Out.Length == 2 || Out.Length == 4 || Out.Length == 3 || Out.Length == 7)
                    {
                        if (Map.ContainsKey(Out)) Map[Out]++;
                        else Map.Add(Out, 1);
                    }
                }
            }

            Result = Map.Sum(i => i.Value);

            return Result;
        }

        public static int AddUpAllOutputValues(string Input)
        {
            int Result = 0;

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var Line in LinesS)
            {
                var SegmentsS = Line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var Digits = SegmentsS[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var Output = SegmentsS[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                Result += DecodeDigits(Digits, Output);
            }

            return Result;
        }

        private static int DecodeDigits(List<string> Digits, List<string> Output)
        {
            string ResultS = "";

            string D = "";
            string S4S = "";

            string A0 = "";
            string A9 = "";
            string A8 = "";
            string A7 = "";
            string A6 = "";
            string A5 = "";
            string A4 = "";
            string A3 = "";
            string A2 = "";
            string A1 = "";

            foreach (var Digit in Digits.OrderBy(i => i.Length))
            {
                if (Digit.Length == 2)//1
                {
                    A1 = Digit;
                }
                else if (Digit.Length == 3)//7
                {
                    A7 = Digit;
                    if (!String.IsNullOrEmpty(A1)) D = A7.Where(c => !A1.Contains(c)).Aggregate("", (c, n) => c + n);
                }
                else if (Digit.Length == 4)//4
                {
                    A4 = Digit;
                    if (!String.IsNullOrEmpty(A1)) S4S = A4.Where(c => !A1.Contains(c)).Aggregate("", (c, n) => c + n);
                }
                else if (Digit.Length == 7)//8
                {
                    A8 = Digit;
                }
                else if (Digit.Length == 5)//2 3 5
                {
                    if (A7.All(c => Digit.Contains(c)))
                    {
                        A3 = Digit;
                    }
                    else if (S4S.All(c => Digit.Contains(c)))
                    {
                        A5 = Digit;
                    }
                    else A2 = Digit;
                }
                else if (Digit.Length == 6)//0 9 6
                {
                    if (A7.All(c => Digit.Contains(c)) && S4S.All(c => Digit.Contains(c)))
                    {
                        A9 = Digit;
                    }
                    else if (S4S.All(c => Digit.Contains(c)))
                    {
                        A6 = Digit;
                    }
                    else A0 = Digit;
                }
            }

            foreach (var Out in Output)
            {
                if (Out.Length == 2) ResultS += "1";
                if (Out.Length == 3) ResultS += "7";
                if (Out.Length == 4) ResultS += "4";
                if (Out.Length == 7) ResultS += "8";
                if (Out.Length == 5)
                {
                    if (A2.All(c => Out.Contains(c))) ResultS += "2";
                    if (A5.All(c => Out.Contains(c))) ResultS += "5";
                    if (A3.All(c => Out.Contains(c))) ResultS += "3";
                }
                if (Out.Length == 6)
                {
                    if (A0.All(c => Out.Contains(c))) ResultS += "0";
                    if (A6.All(c => Out.Contains(c))) ResultS += "6";
                    if (A9.All(c => Out.Contains(c))) ResultS += "9";
                }
            }

            return Convert.ToInt32(ResultS);
        }
    }
}