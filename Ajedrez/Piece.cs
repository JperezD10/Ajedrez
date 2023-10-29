using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public abstract class Piece
    {
        public Piece(Color color, int x, int y)
        {
            this.Color = color;
            this.CurrentPosition = new(x, y);
        }
        public abstract string IconCode { get; }
        public Color Color { get; set; }
        public bool Alive { get; set; } = true;

        public Position CurrentPosition { get; set; }
        public List<Position> NextMovements { get; set; } = new();

        public bool Move(Position nextPosition)
        {
            var canMove = this.NextMovements.Exists(m => m.X == nextPosition.X && m.Y == nextPosition.Y);
            if (!canMove) return false;
            CurrentPosition = nextPosition;
            return true;
        }
        public abstract void NextMoves();
    }
}
