using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Knight : Piece
    {
        public Knight(Color color) : base(color)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2658" : "\u265E";

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
