
namespace Snake_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Boardlb = new Guna.UI2.WinForms.Guna2Panel();
            this.lbHighScore = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNewGame = new Guna.UI2.WinForms.Guna2Button();
            this.LbResult = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ImgApple = new Guna.UI2.WinForms.Guna2PictureBox();
            this.FullPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Boardlb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgApple)).BeginInit();
            this.SuspendLayout();
            // 
            // Boardlb
            // 
            this.Boardlb.Controls.Add(this.lbHighScore);
            this.Boardlb.Controls.Add(this.guna2PictureBox1);
            this.Boardlb.Controls.Add(this.btnNewGame);
            this.Boardlb.Controls.Add(this.LbResult);
            this.Boardlb.Controls.Add(this.ImgApple);
            this.Boardlb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(77)))), ((int)(((byte)(31)))));
            this.Boardlb.Location = new System.Drawing.Point(0, 0);
            this.Boardlb.Name = "Boardlb";
            this.Boardlb.ShadowDecoration.Parent = this.Boardlb;
            this.Boardlb.Size = new System.Drawing.Size(863, 63);
            this.Boardlb.TabIndex = 0;
            // 
            // lbHighScore
            // 
            this.lbHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lbHighScore.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lbHighScore.Location = new System.Drawing.Point(764, 15);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(22, 37);
            this.lbHighScore.TabIndex = 4;
            this.lbHighScore.Text = "0";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Snake_Project.Properties.Resources._360_F_74655073_rXq0mSF6upUN9wZ8he22eKJDKmTMa8JH__1__removebg_preview;
            this.guna2PictureBox1.Location = new System.Drawing.Point(792, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(58, 56);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.BorderRadius = 15;
            this.btnNewGame.CheckedState.Parent = this.btnNewGame;
            this.btnNewGame.CustomImages.Parent = this.btnNewGame;
            this.btnNewGame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewGame.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.HoverState.Parent = this.btnNewGame;
            this.btnNewGame.Location = new System.Drawing.Point(339, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.ShadowDecoration.Parent = this.btnNewGame;
            this.btnNewGame.Size = new System.Drawing.Size(168, 40);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            // 
            // LbResult
            // 
            this.LbResult.BackColor = System.Drawing.Color.Transparent;
            this.LbResult.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResult.ForeColor = System.Drawing.SystemColors.Control;
            this.LbResult.Location = new System.Drawing.Point(86, 15);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(22, 37);
            this.LbResult.TabIndex = 1;
            this.LbResult.Text = "0";
            // 
            // ImgApple
            // 
            this.ImgApple.BackColor = System.Drawing.Color.Transparent;
            this.ImgApple.Image = global::Snake_Project.Properties.Resources._360_F_74655073_rXq0mSF6upUN9wZ8he22eKJDKmTMa8JH__1__removebg_preview;
            this.ImgApple.Location = new System.Drawing.Point(10, 3);
            this.ImgApple.Name = "ImgApple";
            this.ImgApple.ShadowDecoration.Parent = this.ImgApple;
            this.ImgApple.Size = new System.Drawing.Size(58, 56);
            this.ImgApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgApple.TabIndex = 0;
            this.ImgApple.TabStop = false;
            // 
            // FullPanel
            // 
            this.FullPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FullPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.FullPanel.Location = new System.Drawing.Point(0, 63);
            this.FullPanel.Name = "FullPanel";
            this.FullPanel.ShadowDecoration.Parent = this.FullPanel;
            this.FullPanel.Size = new System.Drawing.Size(863, 402);
            this.FullPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 464);
            this.Controls.Add(this.FullPanel);
            this.Controls.Add(this.Boardlb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sake Game";
            this.Boardlb.ResumeLayout(false);
            this.Boardlb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgApple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Boardlb;
        private Guna.UI2.WinForms.Guna2PictureBox ImgApple;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbResult;
        private Guna.UI2.WinForms.Guna2Panel FullPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHighScore;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnNewGame;
    }
}

