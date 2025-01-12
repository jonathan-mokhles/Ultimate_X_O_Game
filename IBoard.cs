using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_X_O_Game
{
    public abstract class IBoard
    {
        public IBoard() { }

        protected int Moves = 0;
        protected byte[,] board;

        public abstract bool IsWinner(out string[] points);
        public abstract bool IsDraw();
        public abstract void Update(byte x, byte y,byte symbol);
        public abstract void GameOver();
            
    }
}
