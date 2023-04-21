using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Table
    {
        public Piece[,] TableGame { get; set; } = new Piece[8, 8];

        public Table() 
        {
            SetInitialPawns();
            SetInitialRocks();
            SetInitialKnights();
            SetInitialBishops();
            SetInitialQueens();
            SetInitialKings();
        }

        private void SetInitialPawns()
        {
            for (int i = 0; i < 8; i++)
            {
                TableGame[1, i] = new Pawn(Color.Black);
                TableGame[6, i] = new Pawn(Color.White);
            }
        }

        private void SetInitialRocks()
        {
            TableGame[0,0] = new Rook(Color.Black);
            TableGame[0,7] = new Rook(Color.Black);
            TableGame[7, 0] = new Rook(Color.White);
            TableGame[7, 7] = new Rook(Color.White);
        }

        private void SetInitialKnights()
        {
            TableGame[0, 1] = new Knight(Color.Black);
            TableGame[0, 6] = new Knight(Color.Black);
            TableGame[7, 1] = new Knight(Color.White);
            TableGame[7, 6] = new Knight(Color.White);
        }

        private void SetInitialBishops()
        {
            TableGame[0, 2] = new Bishop(Color.Black);
            TableGame[0, 5] = new Bishop(Color.Black);
            TableGame[7, 2] = new Bishop(Color.White);
            TableGame[7, 5] = new Bishop(Color.White);
        }

        private void SetInitialQueens()
        {
            TableGame[0,3] = new Queen(Color.Black);
            TableGame[7,3] = new Queen(Color.White);
        }

        private void SetInitialKings()
        {
            TableGame[0, 4] = new King(Color.Black);
            TableGame[7, 4] = new King(Color.White);
        }

        public void DrawTable()
        {
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < TableGame.GetLength(0); i++)
            {
                string line = "";
                for (int j = 0; j < TableGame.GetLength(1); j++)
                {
                    string icon = TableGame[i, j] == null ? "*" : TableGame[i,j].IconCode;

                    //this spacing is a bug with the windows terminal. With others terminal don't be need.
                    #region fix withe pawn
                    string spacing = " ";
                    if (TableGame[i, j] is Pawn && TableGame[i, j].Color == Color.White)
                    {
                        spacing = "";
                    }
                    #endregion
                    line += icon + spacing;

                    if (j == 7)
                    {
                        Console.WriteLine(line);
                        Console.WriteLine(Environment.NewLine);
                    }
                }
            }
        }
    }
}
