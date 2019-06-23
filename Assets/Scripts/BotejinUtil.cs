using UnityEngine;

namespace BotejinUtil
{
    enum BColor {
        WHITE = 16777215,   // #FFFFFF
        RED = 16711680,     // #FF0000
        BLUE = 255,         // #0000FF
        GREEN = 65280,      // #00FF00
        ORANGE = 16753920,  // #FFFA50
        YELLOW = 16776960,  // #FFFF00
        CYAN = 65535        // #00FFFF
    }
    public class Cell
    {
		private Cell[] next = new Cell[4];
		private BColor color = BColor.WHITE;
        public Vector2 Pos;
        public bool IsGoal = false;

		public Cell[] Next { get => next; }
		internal BColor Color { get => color; set => color = value; }

		public Cell(Vector2 pos) {
            this.Pos = pos;
        }
        public void SetNext(Cell front, Cell right, Cell back, Cell left) {
            next[0] = front;
            next[1] = right;
            next[2] = back;
            next[3] = left;
        }
    }
}
