using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Jugador
    {
        public Jugador(string nombre, Color side)
        {
            Nombre = nombre;
            Side = side;
        }

        public string Nombre { get; set; }
        public Color Side { get; set; }
    }
}
