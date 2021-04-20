namespace Color_Block_Game
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
            this.pnlRunningBlock = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pnlGameInteract = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLifes = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlRunningBlock.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.pnlGameInteract.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRunningBlock
            // 
            this.pnlRunningBlock.BackColor = System.Drawing.Color.White;
            this.pnlRunningBlock.Controls.Add(this.pnlGame);
            this.pnlRunningBlock.Location = new System.Drawing.Point(2, 1);
            this.pnlRunningBlock.Name = "pnlRunningBlock";
            this.pnlRunningBlock.Size = new System.Drawing.Size(405, 540);
            this.pnlRunningBlock.TabIndex = 1;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.DimGray;
            this.pnlGame.Controls.Add(this.label4);
            this.pnlGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlGame.Location = new System.Drawing.Point(0, 422);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(405, 22);
            this.pnlGame.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose the right color :3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.Red;
            this.lblGameName.Location = new System.Drawing.Point(28, 8);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(117, 41);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Colour";
            // 
            // pnlGameInteract
            // 
            this.pnlGameInteract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlGameInteract.Controls.Add(this.button1);
            this.pnlGameInteract.Controls.Add(this.lblLifes);
            this.pnlGameInteract.Controls.Add(this.lblScore);
            this.pnlGameInteract.Controls.Add(this.label2);
            this.pnlGameInteract.Controls.Add(this.label1);
            this.pnlGameInteract.Controls.Add(this.lblGameName);
            this.pnlGameInteract.Location = new System.Drawing.Point(407, 1);
            this.pnlGameInteract.Name = "pnlGameInteract";
            this.pnlGameInteract.Size = new System.Drawing.Size(191, 540);
            this.pnlGameInteract.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblLifes
            // 
            this.lblLifes.AutoSize = true;
            this.lblLifes.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifes.Location = new System.Drawing.Point(29, 474);
            this.lblLifes.Name = "lblLifes";
            this.lblLifes.Size = new System.Drawing.Size(122, 34);
            this.lblLifes.TabIndex = 5;
            this.lblLifes.Text = "Lifes: 3";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(29, 422);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(132, 34);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Block";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 539);
            this.Controls.Add(this.pnlGameInteract);
            this.Controls.Add(this.pnlRunningBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour Block Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pnlRunningBlock.ResumeLayout(false);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.pnlGameInteract.ResumeLayout(false);
            this.pnlGameInteract.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRunningBlock;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Panel pnlGameInteract;
        private System.Windows.Forms.Label lblLifes;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

