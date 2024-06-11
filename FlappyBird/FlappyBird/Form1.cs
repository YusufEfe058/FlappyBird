using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int gravity = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameText.Text = GameDb.UserName;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pBBird.Top += gravity;
            Debug.WriteLine(pBBird.Top);

            pBPipeBottom.Left -= boruHızı;
            pBPipeTop.Left -= boruHızı;
            scoreText.Text = "Score: " + GameDb.Score;
            if (pBPipeBottom.Left < -150)
            {
                pBPipeBottom.Left = 800;
                GameDb.Score++;
            }
            if (pBPipeTop.Left < -180)
            {
                pBPipeTop.Left = 950;
                GameDb.Score++;
            }
            if (pBBird.Bounds.IntersectsWith(pBPipeBottom.Bounds) || pBBird.Bounds.IntersectsWith(pBPipeTop.Bounds) || pBBird.Bounds.IntersectsWith(pBGround.Bounds))
            {
                endGame();
            }
            if (GameDb.Score > 10)
            {
                boruHızı = 15;
            }
            if (pBBird.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over!!!";
            var form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
