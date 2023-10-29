using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Knight : Piece
    {
        public Knight(Color color, int x, int y) : base(color, x, y)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2658" : "\u265E";

        public override void NextMoves()
        {
            throw new NotImplementedException();
        }
    }
}
