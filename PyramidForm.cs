using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ultimate_X_O_Game
{
    public partial class PyramidForm : Ultimate_X_O_Game.BaseForm
    {
        public PyramidForm()
        {
            InitializeComponent();
        }
        protected override void BtnRestart_Click(object sender, EventArgs e)
        {

            base.RestartGame();
            PB00.Enabled = true;
            PB01.Enabled = true;
            PB02.Enabled = true;
            PB10.Enabled = true;
            PB11.Enabled = true;
            PB12.Enabled = true;
            PB20.Enabled = true;
            PB21.Enabled = true;
            PB22.Enabled = true;

            PB01.Image = Properties.Resources.QM;
            PB02.Image = Properties.Resources.QM;
            PB10.Image = Properties.Resources.QM;
            PB11.Image = Properties.Resources.QM;
            PB00.Image = Properties.Resources.QM;
            PB12.Image = Properties.Resources.QM;
            PB20.Image = Properties.Resources.QM;
            PB21.Image = Properties.Resources.QM;
            PB22.Image = Properties.Resources.QM;

            PB00.Tag = "QM";
            PB01.Tag = "QM";
            PB02.Tag = "QM";
            PB10.Tag = "QM";
            PB11.Tag = "QM";
            PB12.Tag = "QM";
            PB20.Tag = "QM";
            PB21.Tag = "QM";
            PB22.Tag = "QM";

            PB00.BackColor = Color.Black;
            PB01.BackColor = Color.Black;
            PB02.BackColor = Color.Black;
            PB10.BackColor = Color.Black;
            PB11.BackColor = Color.Black;
            PB12.BackColor = Color.Black;
            PB20.BackColor = Color.Black;
            PB21.BackColor = Color.Black;
            PB22.BackColor = Color.Black;



        }
        protected override void EndGame()
        {

            PB00.Enabled = false;
            PB01.Enabled = false;
            PB02.Enabled = false;
            PB10.Enabled = false;
            PB11.Enabled = false;
            PB12.Enabled = false;
            PB20.Enabled = false;
            PB21.Enabled = false;
            PB22.Enabled = false;

        }
        private void PB_Click(object sender, EventArgs e)
        {
            PictureBox pb = ((PictureBox)sender);

            if (pb.Tag != "QM")
            {
                MessageBox.Show("error");
                return;
            }
            else
            {
                if (turn)
                {
                    pb.Image = Properties.Resources.X;
                    pb.Tag = "X";
                }
                else
                {
                    pb.Image = Properties.Resources.O;
                    pb.Tag = "O";
                }

            }

            string s = pb.Name;

            OnMoved((byte)s[2], (byte)s[3]);


        }

    }
}
