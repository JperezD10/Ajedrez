using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Pawn : Piece
    {
        public Pawn(Color color) : base(color)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2659" : "\u265F";

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
