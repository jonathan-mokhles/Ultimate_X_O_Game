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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        IBoard board;
        BaseForm form;
        GameManager gameManager;

        private void btn3x3_Click(object sender, EventArgs e)
        {
            board = new Board_3x3();
            form = new Form3x3();
            gameManager = new GameManager(form,board);
            form.Show();

        }

        private void btnPyramid_Click(object sender, EventArgs e)
        {
            board = new pyramidBoard();
            form = new PyramidForm();
            gameManager = new GameManager(form, board);
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
