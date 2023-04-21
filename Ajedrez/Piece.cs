using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public abstract class Piece
    {
        public Piece(Color color)
        {
            this.Color = color;   
        }
        public abstract string IconCode { get; }
        public Color Color { get; set; }
        public bool Alive { get; set; } = true;

        public abstract void Move();

    }
}
