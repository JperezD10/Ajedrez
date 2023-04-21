using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Rook : Piece
    {
        public Rook(Color color) : base(color)
        {
        }

        public override string IconCode => Color == Color.Black ? "\u2656" : "\u265C";



        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
