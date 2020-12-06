using System;

namespace TraderaAcronymBingo.Models
{
    public class SquareState
    {
        public int Index { get; set; }
        public Acronym Acronym { get; set; }
        public bool Selected { get; set; }
        public DateTime Timestamp { get; set; }

        public void Toggle()
        {
            Selected = !Selected;
            Timestamp = DateTime.Now;
        }
    }
}
