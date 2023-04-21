using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Bishop : Piece
    {
        public Bishop(Color color) : base(color)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2657" : "\u265D";

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
