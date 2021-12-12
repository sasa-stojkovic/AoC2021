using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Node
    {
        public string Name { get; set; }
        public bool IsBig { get; set; }
        public List<Node> Connections { get; set; } = new List<Node>();

        public override string ToString()
        {
            return Name;
        }
    }

    public class Day12
    {
        public static int HowManyPaths(string Input)
        {
            int Result = 0;
            Dictionary<string, Node> EasyFind = new Dictionary<string, Node>();

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var LineS in LinesS)
            {
                var SegmentsS = LineS.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                AddNodeToGraph(EasyFind, SegmentsS[0]);
                AddNodeToGraph(EasyFind, SegmentsS[1]);
                AddRelationToGraph(EasyFind, SegmentsS[0], SegmentsS[1]);
            }

            List<List<string>> Paths = new List<List<string>>();

            Node Start = EasyFind["start"];

            TravGraph(Start, new List<string>(), Paths);

            var allPaths = "";
            foreach (var path in Paths)
            {
                path.ForEach(i => allPaths += i + ",");
                allPaths += "\r\n";
            }

            Result = Paths.Count;

            return Result;
        }

        private static void TravGraph(Node N, List<string> PathSoFar, List<List<string>> AllPaths)
        {
            if (N.Name == "end")
            {
                if (!PathSoFar.Contains("end"))
                {
                    PathSoFar.Add(N.Name);
                    AllPaths.Add(PathSoFar);
                }
            }
            else
            {
                PathSoFar.Add(N.Name);
                foreach (Node C in N.Connections)
                {
                    if ((!C.IsBig && PathSoFar.Contains(C.Name)) || C.Name == "start")
                        continue;

                    TravGraph(C, new List<string>().Concat(PathSoFar).ToList(), AllPaths);
                }
            }
        }

        public static int HowManyPaths2(string Input)
        {
            int Result = 0;
            Dictionary<string, Node> EasyFind = new Dictionary<string, Node>();

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var LineS in LinesS)
            {
                var SegmentsS = LineS.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                AddNodeToGraph(EasyFind, SegmentsS[0]);
                AddNodeToGraph(EasyFind, SegmentsS[1]);
                AddRelationToGraph(EasyFind, SegmentsS[0], SegmentsS[1]);
            }

            List<List<string>> Paths = new List<List<string>>();

            Node Start = EasyFind["start"];

            TravGraph2(EasyFind, Start, new List<string>(), Paths);

            Result = Paths.Count;

            return Result;
        }

        private static void TravGraph2(Dictionary<string, Node> EasyFind, Node N, List<string> PathSoFar, List<List<string>> AllPaths)
        {
            if (N.Name == "end")
            {
                if (!PathSoFar.Contains("end"))
                {
                    PathSoFar.Add(N.Name);
                    AllPaths.Add(PathSoFar);
                }
            }
            else
            {
                PathSoFar.Add(N.Name);
                foreach (Node C in N.Connections)
                {
                    int HowManyTimesThisCharAppears = PathSoFar.Where(c => c == C.Name).Count();

                    var Used = EasyFind.Where(i => PathSoFar.Contains(i.Key) && !i.Value.IsBig).ToDictionary(i => i.Key, i => i.Value);

                    var Grouped = PathSoFar.GroupBy(c => c);

                    bool OtherAppearsTwice = Used.Any(i => Grouped.Any(c => c.Key == i.Key && c.Count() > 1 && c.Key != C.Name));

                    bool Reject = HowManyTimesThisCharAppears == 2 || 
                                  (HowManyTimesThisCharAppears == 1 && OtherAppearsTwice);

                    if ((!C.IsBig && Reject) || C.Name == "start")
                        continue;

                    TravGraph2(EasyFind, C, new List<string>().Concat(PathSoFar).ToList(), AllPaths);
                }
            }
        }

        private static void AddRelationToGraph(Dictionary<string, Node> EasyFind, string A, string B)
        {
            Node NA = EasyFind[A];
            Node NB = EasyFind[B];

            NA.Connections.Add(NB);
            NB.Connections.Add(NA);
        }

        private static void AddNodeToGraph(Dictionary<string, Node> EasyFind, string Name)
        {
            if (!EasyFind.ContainsKey(Name))
            {
                EasyFind.Add(Name, new Node()
                {
                    Name = Name,
                    IsBig = IsAllUpper(Name)
                });
            }
        }

        private static bool IsAllUpper(string Input)
        {
            if (Input == "start" || Input == "end") return true;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Char.IsLetter(Input[i]) && !Char.IsUpper(Input[i]))
                    return false;
            }
            return true;
        }
    }
}