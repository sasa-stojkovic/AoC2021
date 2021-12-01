using System;
using System.Collections.Generic;

namespace AOC2021_1
{
    public class Day1
    {
        public static int HowManyMeasurementsAreLargerThanThePreviousMeasurement(List<int> input)
        {
            int prev = input[0];
            int count = 0;
            for (int i = 1; i < input.Count; i++)
            {
                int next = input[i];
                if (prev < next) count++;

                prev = next;
            }
            return count;
        }

        public static int HowManyMeasurementsAreLargerThanThePreviousMeasurement3SlotWindow(List<int> input)
        {
            if (input.Count < 3) return 0;

            int count = 0;

            int prev_sum = input[0] + input[1] + input[2];

            for (int i = 1; i < input.Count - 2; i++)
            {
                int next1 = input[i];
                int next2 = input[i+1];
                int next3 = input[i+2];

                var next_sum = next1 + next2 + next3;

                if (prev_sum < next_sum) count++;

                prev_sum = next_sum;
            }

            return count;
        }
    }
}
