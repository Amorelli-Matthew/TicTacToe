
namespace TicTacToe
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.XorO = new System.Windows.Forms.ImageList(this.components);
            this.labelGame1 = new System.Windows.Forms.Label();
            this.labelGame2 = new System.Windows.Forms.Label();
            this.labelGame4 = new System.Windows.Forms.Label();
            this.labelGame5 = new System.Windows.Forms.Label();
            this.labelGame6 = new System.Windows.Forms.Label();
            this.labelGame7 = new System.Windows.Forms.Label();
            this.labelGame8 = new System.Windows.Forms.Label();
            this.labelGame9 = new System.Windows.Forms.Label();
            this.labelGame3 = new System.Windows.Forms.Label();
            this.labelTextWinner = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.LightCyan;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(13, 383);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(155, 66);
            this.buttonNewGame.TabIndex = 18;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // XorO
            // 
            this.XorO.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("XorO.ImageStream")));
            this.XorO.TransparentColor = System.Drawing.Color.Transparent;
            this.XorO.Images.SetKeyName(0, "699px-Deseret_capital_long_O.svg.png");
            this.XorO.Images.SetKeyName(1, "1200px-LetterX.svg.png");
            // 
            // labelGame1
            // 
            this.labelGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame1.Location = new System.Drawing.Point(31, 70);
            this.labelGame1.Name = "labelGame1";
            this.labelGame1.Size = new System.Drawing.Size(71, 75);
            this.labelGame1.TabIndex = 45;
            this.labelGame1.Text = "X";
            // 
            // labelGame2
            // 
            this.labelGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame2.Location = new System.Drawing.Point(164, 70);
            this.labelGame2.Name = "labelGame2";
            this.labelGame2.Size = new System.Drawing.Size(71, 75);
            this.labelGame2.TabIndex = 46;
            this.labelGame2.Text = "X";
            // 
            // labelGame4
            // 
            this.labelGame4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame4.Location = new System.Drawing.Point(31, 170);
            this.labelGame4.Name = "labelGame4";
            this.labelGame4.Size = new System.Drawing.Size(71, 75);
            this.labelGame4.TabIndex = 48;
            this.labelGame4.Text = "X";
            // 
            // labelGame5
            // 
            this.labelGame5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame5.Location = new System.Drawing.Point(164, 170);
            this.labelGame5.Name = "labelGame5";
            this.labelGame5.Size = new System.Drawing.Size(71, 75);
            this.labelGame5.TabIndex = 49;
            this.labelGame5.Text = "X";
            // 
            // labelGame6
            // 
            this.labelGame6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame6.Location = new System.Drawing.Point(287, 170);
            this.labelGame6.Name = "labelGame6";
            this.labelGame6.Size = new System.Drawing.Size(71, 75);
            this.labelGame6.TabIndex = 50;
            this.labelGame6.Text = "X";
            // 
            // labelGame7
            // 
            this.labelGame7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame7.Location = new System.Drawing.Point(31, 266);
            this.labelGame7.Name = "labelGame7";
            this.labelGame7.Size = new System.Drawing.Size(71, 75);
            this.labelGame7.TabIndex = 51;
            this.labelGame7.Text = "X";
            // 
            // labelGame8
            // 
            this.labelGame8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame8.Location = new System.Drawing.Point(164, 266);
            this.labelGame8.Name = "labelGame8";
            this.labelGame8.Size = new System.Drawing.Size(71, 75);
            this.labelGame8.TabIndex = 52;
            this.labelGame8.Text = "X";
            // 
            // labelGame9
            // 
            this.labelGame9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame9.Location = new System.Drawing.Point(287, 266);
            this.labelGame9.Name = "labelGame9";
            this.labelGame9.Size = new System.Drawing.Size(71, 75);
            this.labelGame9.TabIndex = 53;
            this.labelGame9.Text = "X";
            // 
            // labelGame3
            // 
            this.labelGame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame3.Location = new System.Drawing.Point(287, 70);
            this.labelGame3.Name = "labelGame3";
            this.labelGame3.Size = new System.Drawing.Size(71, 75);
            this.labelGame3.TabIndex = 47;
            this.labelGame3.Text = "X";
            // 
            // labelTextWinner
            // 
            this.labelTextWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextWinner.Location = new System.Drawing.Point(33, 341);
            this.labelTextWinner.Name = "labelTextWinner";
            this.labelTextWinner.Size = new System.Drawing.Size(325, 40);
            this.labelTextWinner.TabIndex = 54;
            this.labelTextWinner.Text = "The Winner!";
            this.labelTextWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(41, 32);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(302, 33);
            this.labelTittle.TabIndex = 55;
            this.labelTittle.Text = "Tic Tac Toe Simulater";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 66);
            this.button1.TabIndex = 56;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.labelTextWinner);
            this.Controls.Add(this.labelGame9);
            this.Controls.Add(this.labelGame8);
            this.Controls.Add(this.labelGame7);
            this.Controls.Add(this.labelGame6);
            this.Controls.Add(this.labelGame5);
            this.Controls.Add(this.labelGame4);
            this.Controls.Add(this.labelGame3);
            this.Controls.Add(this.labelGame2);
            this.Controls.Add(this.labelGame1);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.ImageList XorO;
        private System.Windows.Forms.Label labelGame1;
        private System.Windows.Forms.Label labelGame2;
        private System.Windows.Forms.Label labelGame4;
        private System.Windows.Forms.Label labelGame5;
        private System.Windows.Forms.Label labelGame6;
        private System.Windows.Forms.Label labelGame7;
        private System.Windows.Forms.Label labelGame8;
        private System.Windows.Forms.Label labelGame9;
        private System.Windows.Forms.Label labelGame3;
        private System.Windows.Forms.Label labelTextWinner;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Button button1;
    }
}

