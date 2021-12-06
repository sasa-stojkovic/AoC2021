using System;
using System.Linq;
using System.Collections.Generic;

namespace AOC2021
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }

    class Line
    {
        public Point A { get; set; }
        public Point B { get; set; }

        public override string ToString()
        {
            return $"{A.X},{A.Y}->{B.X},{B.Y}";
        }
    }

    public class Day5
    {
        public static int HowManyPointsOverlap(string Input, bool DiagonalLines)
        {
            var LinesS = Input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<Line> AllLines = new List<Line>();

            Dictionary<int, Dictionary<int, int>> Map = new Dictionary<int, Dictionary<int, int>>();

            int ret = 0;

            foreach (var LineS in LinesS)
            {
                var PointS = LineS.Split(new string[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries);
                var Point1S = PointS[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var Point2S = PointS[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                Line Line = new Line();
                Line.A = new Point()
                {
                    X = Convert.ToInt32(Point1S[0]),
                    Y = Convert.ToInt32(Point1S[1])
                };
                Line.B = new Point()
                {
                    X = Convert.ToInt32(Point2S[0]),
                    Y = Convert.ToInt32(Point2S[1])
                };

                if (Line.A.X == Line.B.X || Line.A.Y == Line.B.Y || DiagonalLines) AllLines.Add(Line);
            }

            foreach (Line Line in AllLines)
            {
                var PointsToAdd = GetAllPointsBetween(Line.A, Line.B);
                foreach (Point P in PointsToAdd)
                {
                    if (Map.ContainsKey(P.X) && Map[P.X].ContainsKey(P.Y)) Map[P.X][P.Y]++;
                    else if (Map.ContainsKey(P.X) && !Map[P.X].ContainsKey(P.Y))
                    {
                        Map[P.X].Add(P.Y, 1);
                    }
                    else
                    {
                        var D = new Dictionary<int, int>();
                        D.Add(P.Y, 1);
                        Map.Add(P.X, D);
                    }
                }
            }

            ret = Map.Sum(X => X.Value.Where(Y => Y.Value > 1).Count());

            return ret;
        }

        private static List<Point> GetAllPointsBetween(Point Begin, Point End)
        {
            List<Point> List = new List<Point>();

            if (Begin.X == End.X)
            {
                for (int i = (Begin.Y > End.Y ? End.Y : Begin.Y); i < (Begin.Y > End.Y ? Begin.Y : End.Y) + 1; i++)
                {
                    Point p = new Point();
                    p.X = Begin.X;
                    p.Y = i;
                    List.Add(p);
                }
            }
            else if (Begin.Y == End.Y)
            {
                for (int i = (Begin.X > End.X ? End.X : Begin.X); i < (Begin.X > End.X ? Begin.X : End.X) + 1; i++)
                {
                    Point p = new Point();
                    p.X = i;
                    p.Y = Begin.Y;
                    List.Add(p);
                }
            }
            else //diagonals
            {
                int MinX = -1;
                int MaxX = -1;

                int YStep = -1;
                int YStart = -1;

                if (Begin.X > End.X)
                {
                    MinX = End.X;
                    MaxX = Begin.X + 1;

                    YStep = Begin.Y > End.Y ? 1 : -1;
                    YStart = End.Y;
                }
                else
                {
                    MinX = Begin.X;
                    MaxX = End.X + 1;

                    YStep = End.Y > Begin.Y ? 1 : -1;
                    YStart = Begin.Y;
                }
                

                for (int i = MinX; i < MaxX; i++)
                {
                    Point p = new Point();
                    p.X = i;
                    p.Y = YStart;
                    List.Add(p);

                    YStart += YStep;
                }

            }

            return List;
        }
    }
}
