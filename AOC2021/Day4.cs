using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    class BingoTable
    {
        public List<Dictionary<int, bool>> Rows { get; set; } = new List<Dictionary<int, bool>>();
        public List<Dictionary<int, bool>> Cols { get; set; } = new List<Dictionary<int, bool>>();

        public void PrepCols()
        {
            int ColCount = Rows[0].Count();
            for (int j = 0; j < ColCount; j++)
            {
                Dictionary<int, bool> Col = new Dictionary<int, bool>();
                for (int i = 0; i < Rows.Count; i++)
                {
                    Col.Add(Rows[i].ElementAt(j).Key, false);
                }
                Cols.Add(Col);
            }
        }

        public int TableIndex = -1;
        public int RowIndex = Int32.MaxValue;
        public int ColIndex = Int32.MaxValue;
        public int WinIndex = Int32.MaxValue;

        public bool IsWinner(List<int> Numbers)
        {
            for(int n = 0; n < Numbers.Count; n++)
            {
                var Number = Numbers[n];
                for(int i = 0; i < Rows.Count; i++)
                {
                    var Row = Rows[i];
                    if (Row.ContainsKey(Number)) Row[Number] = true;

                    if (Row.All(i => i.Value))
                    {
                        WinIndex = n;
                        RowIndex = i;
                        return true;
                    }
                }

                for (int i = 0; i < Cols.Count; i++)
                {
                    var Col = Cols[i];
                    if (Col.ContainsKey(Number)) Col[Number] = true;

                    if (Col.All(i => i.Value))
                    {
                        WinIndex = n;
                        ColIndex = i;
                        return true;
                    }
                }
            }

            return false;
        }

        public int SumOfAllUnmarkedNumbers()
        {
            var sum = Rows.Sum(r => r.Where(i => !i.Value).Sum(i => i.Key));
            return sum;
        }
    }

    public class Day4
    {
        private static List<BingoTable> FindAllWinningTables(List<int> Numbers, string InputBTables)
        {
            var TablesS = InputBTables.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<BingoTable> AllTables = new List<BingoTable>();

            BingoTable table = null;

            //parsing rows
            for (int i = 0; i < TablesS.Length; i++)
            {
                if (i % 5 == 0)
                {
                    if (table != null)
                    {
                        table.TableIndex = AllTables.Count;
                        table.PrepCols();
                        AllTables.Add(table);
                    }
                    table = new BingoTable();
                }

                var RowD = TablesS[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToDictionary(key => Convert.ToInt32(key), key => false);
                table.Rows.Add(RowD);
            }
            table.TableIndex = AllTables.Count;
            table.PrepCols();
            AllTables.Add(table);//last table

            return AllTables.Where(t => t.IsWinner(Numbers)).ToList();
        }

        public static int FinalScore(string InputANumbers, string InputBTables)
        {
            var Numbers = InputANumbers.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => Convert.ToInt32(i)).ToList();

            var WinnerTable = FindAllWinningTables(Numbers, InputBTables).OrderBy(i => i.WinIndex).FirstOrDefault();

            return WinnerTable.SumOfAllUnmarkedNumbers() * Numbers[WinnerTable.WinIndex];
        }

        public static int FinalScoreLastToWin(string InputANumbers, string InputBTables)
        {
            var Numbers = InputANumbers.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => Convert.ToInt32(i)).ToList();

            var WinnerTable = FindAllWinningTables(Numbers, InputBTables).OrderByDescending(i => i.WinIndex).FirstOrDefault();

            return WinnerTable.SumOfAllUnmarkedNumbers() * Numbers[WinnerTable.WinIndex];
        }
    }
}
