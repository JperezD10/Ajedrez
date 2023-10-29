using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Table
    {
        //vertical(y), horizontal(x)
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
            for (int x = 0; x < 8; x++)
            {
                TableGame[1, x] = new Pawn(Color.Black,x,1);
                TableGame[6, x] = new Pawn(Color.White,x,6);
            }
        }

        private void SetInitialRocks()
        {
            TableGame[0,0] = new Rook(Color.Black,0,0);
            TableGame[0,7] = new Rook(Color.Black,7,0);
            TableGame[7, 0] = new Rook(Color.White,0,7);
            TableGame[7, 7] = new Rook(Color.White,7,7);
        }

        private void SetInitialKnights()
        {
            TableGame[0, 1] = new Knight(Color.Black,1,0);
            TableGame[0, 6] = new Knight(Color.Black,6,0);
            TableGame[7, 1] = new Knight(Color.White,1,7);
            TableGame[7, 6] = new Knight(Color.White,6,7);
        }

        private void SetInitialBishops()
        {
            TableGame[0, 2] = new Bishop(Color.Black,2,0);
            TableGame[0, 5] = new Bishop(Color.Black,5,0);
            TableGame[7, 2] = new Bishop(Color.White,2,7);
            TableGame[7, 5] = new Bishop(Color.White,5,7);
        }

        private void SetInitialQueens()
        {
            TableGame[0,3] = new Queen(Color.Black,3,0);
            TableGame[7,3] = new Queen(Color.White,3,7);
        }

        private void SetInitialKings()
        {
            TableGame[0, 4] = new King(Color.Black,4,0);
            TableGame[7, 4] = new King(Color.White,4,7);
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
