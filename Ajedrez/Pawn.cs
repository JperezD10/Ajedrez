using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Pawn : Piece
    {
        public Pawn(Color color, int x, int y) : base(color, x, y)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2659" : "\u265F";

        public override void NextMoves()
        {
            int x = CurrentPosition.X;
            int y = CurrentPosition.Y;

            this.NextMovements.Add(new Position(x, y + 1));
            this.NextMovements.Add(new Position(x+1, y + 1));
            this.NextMovements.Add(new Position(x-1, y + 1));
        }
    }
}
