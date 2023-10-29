using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Bishop : Piece
    {
        public Bishop(Color color, int x, int y) : base(color, x, y)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2657" : "\u265D";

        public override void NextMoves()
        {
            throw new NotImplementedException();
        }
    }
}
