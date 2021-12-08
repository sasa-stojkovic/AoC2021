using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Possition
    {
        public int Value { get; set; }
        public int Count { get; set; }
    }

    public class Day7
    {
        public static long HowMuchFuelMustSpendToAlign(string Input) 
        {
            long Price = Int32.MaxValue;
            long Allign = -1;

            var Positions = Input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => Convert.ToInt32(i)).GroupBy(i => i).Select(i => new Possition() { Value = i.Key, Count = i.Count() }).ToList();

            for (long j = 0; j < Positions.Max(i => i.Value); j++)
            {
                var TmpPrice = Positions.Select(i => Math.Abs(i.Value - j) * i.Count).Sum();
                if (TmpPrice < Price) 
                {
                    Price = TmpPrice;
                    Allign = j;
                }
            }

            return Price;
        }

        public static long HowMuchFuelMustSpendToAlignExp(string Input)
        {
            long Price = Int32.MaxValue;
            long Allign = -1;

            var Positions = Input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => Convert.ToInt32(i)).GroupBy(i => i).Select(i => new Possition() { Value = i.Key, Count = i.Count() }).ToList();

            for (long j = 0; j < Positions.Max(i => i.Value); j++)
            {
                var TmpPrice = Positions.Select(i => MovePrice(j > i.Value ? i.Value : j, j > i.Value ? j : i.Value) * i.Count).Sum();
                if (TmpPrice < Price)
                {
                    Price = TmpPrice;
                    Allign = j;
                }
            }

            return Price;
        }

        private static long MovePrice(long Pos, long Target)
        {
            long Sum = 0;
            int Step = 1;
            for (long i = Pos; i < Target; i++)
            {
                Sum += Step++;
            }
            return Sum;
        }
    }
}
