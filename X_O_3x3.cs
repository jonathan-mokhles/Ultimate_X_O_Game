using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_X_O_Game
{
    public partial class X_O_3x3 : Form
    {
        public X_O_3x3()
        {
            InitializeComponent();
        }

        private void Tic_Tac_Toe_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen pen = new Pen(color);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 540, 90, 540, 340);
            e.Graphics.DrawLine(pen, 400, 90, 400, 340);
            e.Graphics.DrawLine(pen, 270, 170, 670, 170);
            e.Graphics.DrawLine(pen, 270, 264, 670, 264);
        }

        bool turn = true;
        byte n = 0;

        void Turn()
        {
            turn = !turn;
            if (turn)
            {
                label3.Text = "Player 1";
            }
            else
            {
                label3.Text = "Player 2";
            }
        }
        void EndGame(bool isdraw)
        {
            pB1.Enabled = false;
            pB2.Enabled = false;
            pB3.Enabled = false;
            pB4.Enabled = false;
            pB5.Enabled = false;
            pB6.Enabled = false;
            pB7.Enabled = false;
            pB8.Enabled = false;
            pB9.Enabled = false;

            if (isdraw)
            {
                label5.Text = "Draw";
                MessageBox.Show("Draw");
                return;
            }

            label5.Text = label3.Text;
            MessageBox.Show(label3.Text + " wins");

        }
        bool IsEquel(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag.ToString() != "0" && (pb1.Tag.ToString() == pb2.Tag.ToString()) && (pb1.Tag.ToString() == pb3.Tag.ToString()))
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow; 
                pb3.BackColor = Color.GreenYellow;
                return true;
            }
            return false;
        }
        bool checkWinner()
        {
            if (IsEquel(pB1, pB2, pB3))
                return true;
             if (IsEquel(pB4, pB5, pB6))
                return true;
             if (IsEquel(pB7, pB8, pB9))
                return true;
             if (IsEquel(pB1, pB4, pB7))
                return true;
             if (IsEquel(pB2, pB5, pB8))
                return true;
             if (IsEquel(pB3, pB6, pB9))
                return true;
             if (IsEquel(pB1, pB5, pB9))
                return true;
             if (IsEquel(pB3, pB5, pB7))
                return true;
   
            return false;
        }
        void tic_tac(PictureBox pB)
        {
            if (pB.Tag.ToString() != "0")
            {
                MessageBox.Show("error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            n++;
            if (turn)
            {
                pB.Image = Properties.Resources.X;
                pB.Tag = 'X';
            }
            else
            {
                pB.Image = Properties.Resources.O;
                pB.Tag = 'O';
            }

            if (checkWinner())
            {
                EndGame(false);
                return;
            }
            else if (n == 9)
            {
                EndGame(true);
                return;
            }
            Turn();

        }

        private void pB_Click(object sender, EventArgs e)
        {
            tic_tac((PictureBox)sender);
        }
    
        private void btnRestart_Click(object sender, EventArgs e)
        {
            turn = true;
            n = 0;
            label3.Text = "player 1";
            label5.Text = "no Winner";

            pB1.Image = Properties.Resources.QM;
            pB1.Enabled = true;

            pB2.Image = Properties.Resources.QM;
            
            pB2.Enabled = true;

            pB3.Image = Properties.Resources.QM;
            pB3.Enabled = true;

            pB4.Image = Properties.Resources.QM;
            pB4.Enabled = true;

            pB5.Image = Properties.Resources.QM;
            pB5.Enabled = true;

            pB6.Image = Properties.Resources.QM;
            pB6.Enabled = true;

            pB7.Image = Properties.Resources.QM;
            pB7.Enabled = true;

            pB8.Image = Properties.Resources.QM;
            pB8.Enabled = true;

            pB9.Image = Properties.Resources.QM;
            pB9.Enabled = true;

            pB1.Tag = 0;
            pB2.Tag = 0; 
            pB3.Tag = 0; 
            pB4.Tag = 0; 
            pB5.Tag = 0; 
            pB6.Tag = 0; 
            pB7.Tag = 0; 
            pB8.Tag = 0; 
            pB9.Tag = 0; 

            pB1.BackColor = SystemColors.ActiveCaptionText;
            pB2.BackColor = SystemColors.ActiveCaptionText;
            pB3.BackColor = SystemColors.ActiveCaptionText;
            pB4.BackColor = SystemColors.ActiveCaptionText;
            pB5.BackColor = SystemColors.ActiveCaptionText;
            pB6.BackColor = SystemColors.ActiveCaptionText;
            pB7.BackColor = SystemColors.ActiveCaptionText;
            pB8.BackColor = SystemColors.ActiveCaptionText;
            pB9.BackColor = SystemColors.ActiveCaptionText;
        }
    }
}
