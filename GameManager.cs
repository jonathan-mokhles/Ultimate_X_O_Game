using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_X_O_Game
{
    internal class GameManager
    {
        BaseForm form;
        IBoard board;
        public GameManager( BaseForm form, IBoard board) {
            this.form = form;
            this.board = board;
            form.MoveMade += playermove;
        }

        public void playermove(byte i, byte j)
        {

            byte sym = (byte)(form.Turn() ? 2 : 1);


            board.Update(i, j,sym);
            string[] BoxesNames;
            if (board.IsWinner(out BoxesNames))
            {
                form.ShowWinner(BoxesNames);
                board.GameOver();
                return;
            }
            else if (board.IsDraw())
            {
                form.Draw();
                board.GameOver();
                return;
            }
            form.MakeTurn();
        }
    }
}
