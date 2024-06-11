using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nameText1.Text = GameDb.UserName;
            scoreText1.Text = GameDb.Score.ToString();
        }


        private void newplayerButton_Click(object sender, EventArgs e)
        {
            GameDb.UserName = "";
            GameDb.Score = 0;
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

        private void playagainButton_Click(object sender, EventArgs e)
        {
            GameDb.ClickCount++;

            if (GameDb.ClickCount < 3)
            {
                GameDb.Score = 0;
                this.Hide();
                var form1 = new Form1();
                form1.Show();
            }

            else
            {
                MessageBox.Show("Daha Fazla Oynama Hakkınız Kalmadı");
                this.Hide();
                var form2 = new Form2();
                form2.Show();
            }
        }
    }
}

