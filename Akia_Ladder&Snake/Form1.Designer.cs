namespace Akia_Ladder_Snake
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
            System.Windows.Forms.Button btnExit;
            this.btnStart = new System.Windows.Forms.Button();
            this.tbPlayerOne = new System.Windows.Forms.TextBox();
            this.tbPlayerTwo = new System.Windows.Forms.TextBox();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.BTNexit;
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Location = new System.Drawing.Point(811, -2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(76, 62);
            btnExit.TabIndex = 7;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.playbtn;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(347, 364);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 93);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbPlayerOne
            // 
            this.tbPlayerOne.Location = new System.Drawing.Point(142, 276);
            this.tbPlayerOne.Name = "tbPlayerOne";
            this.tbPlayerOne.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerOne.TabIndex = 1;
            this.tbPlayerOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlayerTwo
            // 
            this.tbPlayerTwo.Location = new System.Drawing.Point(654, 276);
            this.tbPlayerTwo.Name = "tbPlayerTwo";
            this.tbPlayerTwo.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerTwo.TabIndex = 2;
            this.tbPlayerTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOne.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.Location = new System.Drawing.Point(139, 254);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(103, 17);
            this.lblPlayerOne.TabIndex = 3;
            this.lblPlayerOne.Text = "Player 1 Name";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.Location = new System.Drawing.Point(651, 254);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(104, 17);
            this.lblPlayerTwo.TabIndex = 4;
            this.lblPlayerTwo.Text = "Player 2 Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.char2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(94, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 42);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.char3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(761, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 42);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "made by Jervie Martin H. Akia for Exam.org";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.Form1Load;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.tbPlayerTwo);
            this.Controls.Add(this.tbPlayerOne);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbPlayerOne;
        private System.Windows.Forms.TextBox tbPlayerTwo;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

