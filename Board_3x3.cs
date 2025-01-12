using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_X_O_Game
{
    internal class Board_3x3 : IBoard
    {
        public Board_3x3()
        {
            board = new byte[3, 3];
            Moves = 0;
        }
        public override bool IsWinner(out string[] arr)
        {
            arr = new string[3];
            for (int i = 0; i < 3; i++)
            {
                
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && (board[i, 0] > 0))
                {
                    arr[0] = "PB" + i + 0;
                    arr[1] = "PB" + i + 1;
                    arr[2] = "PB" + i + 2;
                    return true;
                }
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && (board[0, i] > 0))
                {
                    arr[0] = "PB" + 0 + i;
                    arr[1] = "PB" + 1 + i;
                    arr[2] = "PB" + 2 + i;
                    return true;
                }
            }
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && (board[1, 1] > 0)))
            {
                arr[0] = "PB" + 0 + 0;
                arr[1] = "PB" + 1 + 1;
                arr[2] = "PB" + 2 + 2;
                return true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && (board[1, 1] > 0)){

                arr[0] = "PB" + 0 + 2;
                arr[1] = "PB" + 1 + 1;
                arr[2] = "PB" + 2 + 0;
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
        public override void GameOver() {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i,j] = 0;
                }
            }
            Moves = 0;
        }
    
        
    }
}
