using System;
namespace Ajedrez
{
	public class Position
	{
		public Position(int x, int y)
		{
            this.X = x;
            this.Y = y;
        }

		public int X { get; set; }
		public int Y { get; set; }

		public void SetPosition(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
	}
}

