using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Fish
    {
        public int Key { get; set; }
        public long Count { get; set; }
    }

    public class Day6
    {
        public static long HowManyLanternfishWouldThereBe(string Input, int Days) 
        {
            var Fish = Input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => Convert.ToInt32(i)).GroupBy(i => i).Select(i => new Fish() { Key = i.Key, Count = i.Count() }).ToList();

            for(int i = 0; i < Days; i++)
            {
                var NewFish = Tick(Fish);
                if (NewFish != null && NewFish.Count > 0)
                {
                    Fish = Fish.Concat(NewFish).ToList();
                    Fish = Fish.GroupBy(i => i.Key).Select(i => new Fish() { Key = i.Key, Count = i.Sum(i => i.Count) }).ToList();
                }
            }

            return Fish.Sum(i => i.Count); 
        }

        private static List<Fish> Tick(List<Fish> Fish)
        {
            List<Fish> NewFish = new List<Fish>();

            for(int i = 0; i < Fish.Count; i++) 
            {
                Fish[i].Key --;

                if (Fish[i].Key == -1) 
                {
                    NewFish.Add(new Fish() { Key = 8, Count = Fish[i].Count });
                    Fish[i].Key = 6;
                }
            }

            return NewFish;
        }
    }
}
