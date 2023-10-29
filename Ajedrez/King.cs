using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class King : Piece
    {
        public King(Color color, int x, int y) : base(color, x, y)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2654" : "\u265A";

        public override void NextMoves()
        {
            throw new NotImplementedException();
        }
    }
}
