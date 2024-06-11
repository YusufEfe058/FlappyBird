namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBGround = new System.Windows.Forms.PictureBox();
            this.pBPipeTop = new System.Windows.Forms.PictureBox();
            this.pBBird = new System.Windows.Forms.PictureBox();
            this.pBPipeBottom = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // pBGround
            // 
            this.pBGround.Image = ((System.Drawing.Image)(resources.GetObject("pBGround.Image")));
            this.pBGround.Location = new System.Drawing.Point(-2, 409);
            this.pBGround.Name = "pBGround";
            this.pBGround.Size = new System.Drawing.Size(817, 77);
            this.pBGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGround.TabIndex = 0;
            this.pBGround.TabStop = false;
            // 
            // pBPipeTop
            // 
            this.pBPipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pBPipeTop.Image")));
            this.pBPipeTop.Location = new System.Drawing.Point(569, -2);
            this.pBPipeTop.Name = "pBPipeTop";
            this.pBPipeTop.Size = new System.Drawing.Size(64, 139);
            this.pBPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBPipeTop.TabIndex = 1;
            this.pBPipeTop.TabStop = false;
            // 
            // pBBird
            // 
            this.pBBird.Image = ((System.Drawing.Image)(resources.GetObject("pBBird.Image")));
            this.pBBird.Location = new System.Drawing.Point(34, 68);
            this.pBBird.Name = "pBBird";
            this.pBBird.Size = new System.Drawing.Size(81, 69);
            this.pBBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBird.TabIndex = 2;
            this.pBBird.TabStop = false;
            // 
            // pBPipeBottom
            // 
            this.pBPipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pBPipeBottom.Image")));
            this.pBPipeBottom.Location = new System.Drawing.Point(461, 278);
            this.pBPipeBottom.Name = "pBPipeBottom";
            this.pBPipeBottom.Size = new System.Drawing.Size(63, 145);
            this.pBPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBPipeBottom.TabIndex = 3;
            this.pBPipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.White;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(50, 448);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(93, 25);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score:0";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.BackColor = System.Drawing.Color.White;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameText.Location = new System.Drawing.Point(543, 448);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(139, 25);
            this.nameText.TabIndex = 5;
            this.nameText.Text = "PlayerName";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(815, 482);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pBGround);
            this.Controls.Add(this.pBBird);
            this.Controls.Add(this.pBPipeBottom);
            this.Controls.Add(this.pBPipeTop);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pBGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBGround;
        private System.Windows.Forms.PictureBox pBPipeTop;
        private System.Windows.Forms.PictureBox pBBird;
        private System.Windows.Forms.PictureBox pBPipeBottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

