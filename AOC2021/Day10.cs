using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Day10
    {
        public static int TotalSyntaxErrorScore(string Input)
        {
            int Result = 0;

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> Points = new Dictionary<string, int>() {
                        { ")", 3 },
                        { "]", 57 },
                        { "}", 1197 },
                        { ">", 25137}
                    };

            foreach (var LineS in LinesS)
            {
                Stack<string> Stack = new Stack<string>();
                foreach (var C in LineS)
                {
                    var IsValid = true;
                    var Character = C.ToString();
                    switch (Character)
                    {
                        case "(":
                        case "[":
                        case "{":
                        case "<":
                            Stack.Push(Character);
                            break;
                        case ")":
                            var OpeneChar1 = Stack.Pop();
                            if (OpeneChar1 != "(")
                            {
                                IsValid = false;
                                Result += Points[")"];
                            }
                            break;
                        case "]":
                            var OpeneChar2 = Stack.Pop();
                            if (OpeneChar2 != "[")
                            {
                                IsValid = false;
                                Result += Points["]"];
                            }
                            break;
                        case "}":
                            var OpeneChar3 = Stack.Pop();
                            if (OpeneChar3 != "{")
                            {
                                IsValid = false;
                                Result += Points["}"];
                            }
                            break;
                        case ">":
                            var OpeneChar4 = Stack.Pop();
                            if (OpeneChar4 != "<")
                            {
                                IsValid = false;
                                Result += Points[">"];
                            }
                            break;
                        default:
                            break;
                    }
                    if (!IsValid)// && Stack.Count == 0)
                    {
                        break;
                    }
                }
            }

            return Result;
        }

        public static long MiddleScore(string Input)
        {
            long Result = 0;

            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<long> LineScores = new List<long>();

            Dictionary<string, int> Points = new Dictionary<string, int>() {
                        { ")", 1 },
                        { "]", 2 },
                        { "}", 3 },
                        { ">", 4}
                    };

            foreach (var LineS in LinesS)
            {
                Stack<string> Stack = new Stack<string>();
                long LineScore = 0;
                var IsValid = true;

                foreach (var C in LineS)
                {
                    var Character = C.ToString();
                    switch (Character)
                    {
                        case "(":
                        case "[":
                        case "{":
                        case "<":
                            Stack.Push(Character);
                            break;
                        case ")":
                            var OpeneChar1 = Stack.Pop();
                            if (OpeneChar1 != "(") IsValid = false;
                            break;
                        case "]":
                            var OpeneChar2 = Stack.Pop();
                            if (OpeneChar2 != "[") IsValid = false;
                            break;
                        case "}":
                            var OpeneChar3 = Stack.Pop();
                            if (OpeneChar3 != "{") IsValid = false;
                            break;
                        case ">":
                            var OpeneChar4 = Stack.Pop();
                            if (OpeneChar4 != "<") IsValid = false;
                            break;
                        default:
                            break;
                    }
                }

                if (IsValid && Stack.Count > 0)
                {
                    while (Stack.Count > 0)
                    {
                        var OpeneChar = Stack.Pop();
                        switch (OpeneChar)
                        {
                            case "(":
                                LineScore = (LineScore * 5) + Points[")"];
                                break;
                            case "[":
                                LineScore = (LineScore * 5) + Points["]"];
                                break;
                            case "{":
                                LineScore = (LineScore * 5) + Points["}"];
                                break;
                            case "<":
                                LineScore = (LineScore * 5) + Points[">"];
                                break;
                            default:
                                break;
                        }
                    }
                    LineScores.Add(LineScore);
                }
            }

            int Index = LineScores.Count / 2;
            var Ordered = LineScores.OrderBy(i => i).ToList();
            Result = Ordered[Index];

            return Result;
        }
    }
}