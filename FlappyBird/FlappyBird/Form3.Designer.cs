namespace FlappyBird
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText1 = new System.Windows.Forms.Label();
            this.scoreText1 = new System.Windows.Forms.Label();
            this.newplayerButton = new System.Windows.Forms.Button();
            this.playagainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(180, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLAYER NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(203, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE :";
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameText1.Location = new System.Drawing.Point(377, 97);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(135, 25);
            this.nameText1.TabIndex = 2;
            this.nameText1.Text = "Player Name";
            // 
            // scoreText1
            // 
            this.scoreText1.AutoSize = true;
            this.scoreText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText1.Location = new System.Drawing.Point(377, 155);
            this.scoreText1.Name = "scoreText1";
            this.scoreText1.Size = new System.Drawing.Size(68, 25);
            this.scoreText1.TabIndex = 3;
            this.scoreText1.Text = "Score";
            // 
            // newplayerButton
            // 
            this.newplayerButton.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newplayerButton.Location = new System.Drawing.Point(245, 250);
            this.newplayerButton.Name = "newplayerButton";
            this.newplayerButton.Size = new System.Drawing.Size(176, 37);
            this.newplayerButton.TabIndex = 4;
            this.newplayerButton.Text = "NEW PLAYER";
            this.newplayerButton.UseVisualStyleBackColor = true;
            this.newplayerButton.Click += new System.EventHandler(this.newplayerButton_Click);
            // 
            // playagainButton
            // 
            this.playagainButton.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainButton.Location = new System.Drawing.Point(245, 307);
            this.playagainButton.Name = "playagainButton";
            this.playagainButton.Size = new System.Drawing.Size(176, 37);
            this.playagainButton.TabIndex = 5;
            this.playagainButton.Text = "PLAY AGAIN";
            this.playagainButton.UseVisualStyleBackColor = true;
            this.playagainButton.Click += new System.EventHandler(this.playagainButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playagainButton);
            this.Controls.Add(this.newplayerButton);
            this.Controls.Add(this.scoreText1);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "GAME OVER!!!";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.Label scoreText1;
        private System.Windows.Forms.Button newplayerButton;
        private System.Windows.Forms.Button playagainButton;
    }
}