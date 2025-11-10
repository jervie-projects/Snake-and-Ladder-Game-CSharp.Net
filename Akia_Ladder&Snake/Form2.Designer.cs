namespace Akia_Ladder_Snake
{
    partial class Form2
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
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPlayerTwo = new System.Windows.Forms.PictureBox();
            this.pbPlayerOne = new System.Windows.Forms.PictureBox();
            this.pbDiceOne = new System.Windows.Forms.PictureBox();
            this.pbDiceTwo = new System.Windows.Forms.PictureBox();
            this.pbDiceThree = new System.Windows.Forms.PictureBox();
            this.pbDiceFour = new System.Windows.Forms.PictureBox();
            this.pbDiceFive = new System.Windows.Forms.PictureBox();
            this.pbDiceSix = new System.Windows.Forms.PictureBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.boxP1indicator = new System.Windows.Forms.PictureBox();
            this.boxP2indicator = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP1indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP2indicator)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.BackColor = System.Drawing.Color.Black;
            this.lblPlayerOne.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.White;
            this.lblPlayerOne.Location = new System.Drawing.Point(146, 211);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(106, 32);
            this.lblPlayerOne.TabIndex = 0;
            this.lblPlayerOne.Text = "player 1";
            this.lblPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.BackColor = System.Drawing.Color.Black;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTwo.Location = new System.Drawing.Point(145, 246);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(107, 32);
            this.lblPlayerTwo.TabIndex = 1;
            this.lblPlayerTwo.Text = "player 2";
            this.lblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.GameBoard;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbPlayerTwo);
            this.panel1.Controls.Add(this.pbPlayerOne);
            this.panel1.Location = new System.Drawing.Point(2, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 509);
            this.panel1.TabIndex = 2;
            // 
            // pbPlayerTwo
            // 
            this.pbPlayerTwo.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.char3;
            this.pbPlayerTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayerTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerTwo.Location = new System.Drawing.Point(41, 458);
            this.pbPlayerTwo.Name = "pbPlayerTwo";
            this.pbPlayerTwo.Size = new System.Drawing.Size(32, 46);
            this.pbPlayerTwo.TabIndex = 1;
            this.pbPlayerTwo.TabStop = false;
            // 
            // pbPlayerOne
            // 
            this.pbPlayerOne.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.char2;
            this.pbPlayerOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayerOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerOne.Location = new System.Drawing.Point(4, 459);
            this.pbPlayerOne.Name = "pbPlayerOne";
            this.pbPlayerOne.Size = new System.Drawing.Size(32, 46);
            this.pbPlayerOne.TabIndex = 0;
            this.pbPlayerOne.TabStop = false;
            // 
            // pbDiceOne
            // 
            this.pbDiceOne.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources._1;
            this.pbDiceOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceOne.Location = new System.Drawing.Point(132, 340);
            this.pbDiceOne.Name = "pbDiceOne";
            this.pbDiceOne.Size = new System.Drawing.Size(91, 84);
            this.pbDiceOne.TabIndex = 3;
            this.pbDiceOne.TabStop = false;
            // 
            // pbDiceTwo
            // 
            this.pbDiceTwo.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources._2;
            this.pbDiceTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceTwo.Location = new System.Drawing.Point(132, 340);
            this.pbDiceTwo.Name = "pbDiceTwo";
            this.pbDiceTwo.Size = new System.Drawing.Size(91, 84);
            this.pbDiceTwo.TabIndex = 4;
            this.pbDiceTwo.TabStop = false;
            // 
            // pbDiceThree
            // 
            this.pbDiceThree.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources._3;
            this.pbDiceThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceThree.Location = new System.Drawing.Point(132, 340);
            this.pbDiceThree.Name = "pbDiceThree";
            this.pbDiceThree.Size = new System.Drawing.Size(91, 84);
            this.pbDiceThree.TabIndex = 5;
            this.pbDiceThree.TabStop = false;
            // 
            // pbDiceFour
            // 
            this.pbDiceFour.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources._4;
            this.pbDiceFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceFour.Location = new System.Drawing.Point(132, 340);
            this.pbDiceFour.Name = "pbDiceFour";
            this.pbDiceFour.Size = new System.Drawing.Size(91, 84);
            this.pbDiceFour.TabIndex = 6;
            this.pbDiceFour.TabStop = false;
            // 
            // pbDiceFive
            // 
            this.pbDiceFive.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources._5;
            this.pbDiceFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceFive.Location = new System.Drawing.Point(132, 340);
            this.pbDiceFive.Name = "pbDiceFive";
            this.pbDiceFive.Size = new System.Drawing.Size(91, 84);
            this.pbDiceFive.TabIndex = 7;
            this.pbDiceFive.TabStop = false;
            // 
            // pbDiceSix
            // 
            this.pbDiceSix.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources._6;
            this.pbDiceSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceSix.Location = new System.Drawing.Point(132, 340);
            this.pbDiceSix.Name = "pbDiceSix";
            this.pbDiceSix.Size = new System.Drawing.Size(91, 84);
            this.pbDiceSix.TabIndex = 8;
            this.pbDiceSix.TabStop = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.Cyan;
            this.btnRollDice.FlatAppearance.BorderSize = 0;
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRollDice.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(123, 441);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(115, 44);
            this.btnRollDice.TabIndex = 9;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // boxP1indicator
            // 
            this.boxP1indicator.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.char2;
            this.boxP1indicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxP1indicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxP1indicator.Location = new System.Drawing.Point(107, 210);
            this.boxP1indicator.Name = "boxP1indicator";
            this.boxP1indicator.Size = new System.Drawing.Size(45, 32);
            this.boxP1indicator.TabIndex = 10;
            this.boxP1indicator.TabStop = false;
            // 
            // boxP2indicator
            // 
            this.boxP2indicator.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.char3;
            this.boxP2indicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxP2indicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxP2indicator.Location = new System.Drawing.Point(108, 246);
            this.boxP2indicator.Name = "boxP2indicator";
            this.boxP2indicator.Size = new System.Drawing.Size(45, 32);
            this.boxP2indicator.TabIndex = 11;
            this.boxP2indicator.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.BTNexit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(185, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 69);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.Transparent;
            this.restartBtn.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.restart;
            this.restartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartBtn.FlatAppearance.BorderSize = 0;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBtn.Location = new System.Drawing.Point(107, 65);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(67, 61);
            this.restartBtn.TabIndex = 14;
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Akia_Ladder_Snake.Properties.Resources.boardlayout;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbDiceOne);
            this.panel2.Controls.Add(this.pbDiceFive);
            this.panel2.Controls.Add(this.lblPlayerOne);
            this.panel2.Controls.Add(this.pbDiceFour);
            this.panel2.Controls.Add(this.restartBtn);
            this.panel2.Controls.Add(this.pbDiceThree);
            this.panel2.Controls.Add(this.lblPlayerTwo);
            this.panel2.Controls.Add(this.btnRollDice);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.boxP1indicator);
            this.panel2.Controls.Add(this.boxP2indicator);
            this.panel2.Controls.Add(this.pbDiceTwo);
            this.panel2.Controls.Add(this.pbDiceSix);
            this.panel2.Location = new System.Drawing.Point(659, -50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 630);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Players";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP1indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP2indicator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblPlayerOne;
        public System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbDiceFive;
        private System.Windows.Forms.PictureBox pbDiceFour;
        private System.Windows.Forms.PictureBox pbDiceTwo;
        private System.Windows.Forms.PictureBox pbDiceThree;
        private System.Windows.Forms.PictureBox pbDiceSix;
        private System.Windows.Forms.PictureBox pbDiceOne;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox pbPlayerTwo;
        private System.Windows.Forms.PictureBox pbPlayerOne;
        private System.Windows.Forms.PictureBox boxP1indicator;
        private System.Windows.Forms.PictureBox boxP2indicator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}