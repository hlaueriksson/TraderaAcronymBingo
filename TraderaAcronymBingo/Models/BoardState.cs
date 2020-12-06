using System.Collections.Generic;
using System.Linq;

namespace TraderaAcronymBingo.Models
{
    public class BoardState
    {
        private static readonly List<List<int>> Winners = new List<List<int>>
        {
            // Rows
            new List<int> {0, 1, 2, 3, 4},
            new List<int> {5, 6, 7, 8, 9},
            new List<int> {10, 11, 12, 13, 14},
            new List<int> {15, 16, 17, 18, 19},
            new List<int> {20, 21, 22, 23, 24},

            // Columns
            new List<int> {0, 5, 10, 15, 20},
            new List<int> {1, 6, 11, 16, 21},
            new List<int> {2, 7, 12, 17, 22},
            new List<int> {3, 8, 13, 18, 23},
            new List<int> {4, 9, 14, 19, 24},

            // Diagonals
            new List<int> {0, 6, 12, 18, 24},
            new List<int> {4, 8, 12, 16, 20}
        };

        public SquareState[] Squares { get; }

        public BoardState()
        {
            Squares = Acronyms.All
                .Randomize()
                .Take(25)
                .Select((x, i) => new SquareState { Index = i, Acronym = x })
                .ToArray();
        }

        public SquareState[] GetSelectedSquares()
        {
            return Squares
                .Where(x => x.Selected)
                .OrderBy(x => x.Timestamp)
                .ToArray();
        }

        public bool HasWon()
        {
            var indexes = Squares.Where(x => x.Selected).Select(x => x.Index).ToList();

            return indexes.Count >= 5 && Winners.Any(x => x.All(y => indexes.Contains(y)));
        }
    }
}
