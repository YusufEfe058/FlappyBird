using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;

            GameDb.UserName = textBox1.Text;
            this.Hide();
            var form1 = new Form1();
            form1.Show();
            GameDb.ClickCount = 0;
        }
    }
}
