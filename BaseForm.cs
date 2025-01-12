using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_X_O_Game
{
    public  partial class BaseForm : System.Windows.Forms.Form
    {
        protected IBoard board;
        public BaseForm()
        {
            InitializeComponent();
        }
   
        public event Action<byte, byte> MoveMade;
        public void OnMoved(byte i, byte j)
        {
            MoveMade?.Invoke(i,j);
        }




        protected bool turn = true;
        public void Draw()
        {
            winLabel.Text = "Draw";
            winLabel.ForeColor = Color.Gray;
            MessageBox.Show("Draw");
            EndGame();
        }

        public void ShowWinner(string[] BoxesNames)
        {
            foreach (string box in BoxesNames)
            {
                PictureBox PB = this.Controls[box] as PictureBox;
                PB.BackColor = Color.Green;
            }
            winLabel.Text = PlayerLabel.Text;
            winLabel.ForeColor = Color.GreenYellow;
            MessageBox.Show(PlayerLabel.Text + " wins");
            EndGame();
        }

        protected void RestartGame()
        {
            turn = true;
            PlayerLabel.Text = "player 1";
            winLabel.Text = "no Winner";
            winLabel.ForeColor = Color.DodgerBlue;
        }

        protected virtual void BtnRestart_Click(object sender, EventArgs e) { }
        protected virtual void EndGame() { }

        public bool Turn()
        {
            return turn;
        }

        public void MakeTurn()
        {
            turn = !turn;
            if (turn)
            {
                PlayerLabel.Text = "Player 1";
            }
            else
            {
                PlayerLabel.Text = "Player 2";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
    
}
