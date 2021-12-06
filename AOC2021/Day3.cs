using System;
using System.Linq;

namespace AOC2021
{
    public class Day3
    {
        public static long PowerConsumptionOfTheSubmarine(string Input)
        {
            long ret = 0;

            var Lines = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int Length = Lines[0].Length;

            string GammaRateS = "";
            long GammaRate = 0;

            string EpsilonRateS = "";
            long EpsilonRate = 0;

            for (int i = 0; i < Length; i++)
            {
                int Bits1 = 0;
                int Bits0 = 0;

                foreach (var Line in Lines)
                {
                    if (Line[i] == '0') Bits0++;
                    if (Line[i] == '1') Bits1++;
                }

                if (Bits1 > Bits0)
                {
                    GammaRateS += "1";
                    EpsilonRateS += "0";
                }
                else
                {
                    GammaRateS += "0";
                    EpsilonRateS += "1";
                }
            }

            GammaRate = Convert.ToInt64(GammaRateS, 2);
            EpsilonRate = Convert.ToInt64(EpsilonRateS, 2);

            ret = GammaRate * EpsilonRate;

            return ret;
        }

        public static long LifeSupportRating(string Input)
        {
            var Lines = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var Oxigen = GetOxygenGeneratorRating(Lines, 0);
            var CO2 = CO2ScrubberRating(Lines, 0); 

            return Oxigen * CO2;
        }

        private static long GetOxygenGeneratorRating(string[] Lines, int Position)
        {
            if (Lines.Length == 1) return Convert.ToInt64(Lines[0], 2);
            else
            {
                int Bits1 = 0;
                int Bits0 = 0;

                foreach (var Line in Lines)
                {
                    if (Line[Position] == '0') Bits0++;
                    if (Line[Position] == '1') Bits1++;
                }

                if (Bits1 >= Bits0) Lines = Lines.Where(l => l[Position] == '1').ToArray();
                else Lines = Lines.Where(l => l[Position] == '0').ToArray();

                return GetOxygenGeneratorRating(Lines, ++Position);
            }
        }

        private static long CO2ScrubberRating(string[] Lines, int Position)
        {
            if (Lines.Length == 1) return Convert.ToInt64(Lines[0], 2);
            else
            {
                int Bits1 = 0;
                int Bits0 = 0;

                foreach (var Line in Lines)
                {
                    if (Line[Position] == '0') Bits0++;
                    if (Line[Position] == '1') Bits1++;
                }

                if (Bits1 >= Bits0) Lines = Lines.Where(l => l[Position] == '0').ToArray();
                else Lines = Lines.Where(l => l[Position] == '1').ToArray();

                return CO2ScrubberRating(Lines, ++Position);
            }
        }
    }
}
