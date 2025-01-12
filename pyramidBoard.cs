using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_X_O_Game
{
    internal class pyramidBoard :IBoard
    {
        public pyramidBoard() {
            board = new byte[3, 3];
            Moves = 0;
        }

        public override bool IsWinner(out string[] PictureBox)
        {
            PictureBox = new string[3];
            if (board[0,1] !=0 )
            {
                if (board[0, 0] == board[0, 1] && board[0, 1] == board[1, 0])
                {
                    PictureBox[0] = "PB" + 0 + 0;
                    PictureBox[1] = "PB" + 0 + 1;
                    PictureBox[2] = "PB" + 1 + 0;
                    return true;
                }
                if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] )
                {
                    PictureBox[0] = "PB" + 2 + 1;
                    PictureBox[1] = "PB" + 0 + 1;
                    PictureBox[2] = "PB" + 1 + 1;
                    return true;
                }
                if (board[0, 1] == board[1, 2] && board[0, 1] == board[0, 2] )
                {
                    PictureBox[0] = "PB" + 1 + 2;
                    PictureBox[1] = "PB" + 0 + 1;
                    PictureBox[2] = "PB" + 0 + 2;
                    return true;
                }
            } 
            if (board[2,1] !=0 )
            {
                if (board[0, 0] == board[2, 1] && board[2, 1] == board[2, 0])
                {
                    PictureBox[0] = "PB" + 0 + 0;
                    PictureBox[1] = "PB" + 2 + 1;
                    PictureBox[2] = "PB" + 2 + 0;
                    return true;
                }
                if (board[2, 2] == board[2, 1] && board[2, 0] == board[2, 1] )
                {
                    PictureBox[0] = "PB" + 2 + 2;
                    PictureBox[1] = "PB" + 2 + 1;
                    PictureBox[2] = "PB" + 2 + 0;
                    return true;
                }
                if (board[2, 1] == board[0, 2] && board[2, 1] == board[2, 2] )
                {
                    PictureBox[0] = "PB" +  0 + 2;
                    PictureBox[1] = "PB" + 2 + 1;
                    PictureBox[2] = "PB" + 2 + 1;
                    return true;
                }
            }
            if (board[1, 0] == board[1, 1] && board[1, 1] == board[2, 1] && (board[1, 1] > 0))
            {
                PictureBox[0] = "PB" + 1 + 1;
                PictureBox[1] = "PB" + 2 + 1;
                PictureBox[2] = "PB" + 1 + 0;
                return true;
            }
            return false;
        }
        public override bool IsDraw()
        {
            if (Moves == 9)
            {
                return true;
            }
            return false;
        }
        public override void Update(byte x, byte y, byte symbol)
        {
            byte n = 48;
            x -= (byte)n;
            y -= (byte)n;

            board[x, y] = symbol;
            Moves = Moves + 1;
        }
        public override void GameOver()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            Moves = 0;
        }
    }
}
