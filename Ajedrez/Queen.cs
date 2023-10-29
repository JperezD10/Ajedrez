using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Queen : Piece
    {
        public Queen(Color color, int x, int y) : base(color, x, y)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2655" : "\u265B";

        public override void NextMoves()
        {
            throw new NotImplementedException();
        }
    }
}
