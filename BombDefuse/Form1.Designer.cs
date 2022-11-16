namespace BombDefuse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TicTacToe = new System.Windows.Forms.Button();
            this.GuessTheFlag = new System.Windows.Forms.Button();
            this.MathGeek = new System.Windows.Forms.Button();
            this.Scramble = new System.Windows.Forms.Button();
            this.Switches = new System.Windows.Forms.Button();
            this.Battleship = new System.Windows.Forms.Button();
            this.DefeatThePokemon = new System.Windows.Forms.Button();
            this.MemoryMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicTacToe
            // 
            this.TicTacToe.Location = new System.Drawing.Point(29, 185);
            this.TicTacToe.Name = "TicTacToe";
            this.TicTacToe.Size = new System.Drawing.Size(156, 46);
            this.TicTacToe.TabIndex = 0;
            this.TicTacToe.Text = "TicTacToe";
            this.TicTacToe.UseVisualStyleBackColor = true;
            this.TicTacToe.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuessTheFlag
            // 
            this.GuessTheFlag.Location = new System.Drawing.Point(225, 185);
            this.GuessTheFlag.Name = "GuessTheFlag";
            this.GuessTheFlag.Size = new System.Drawing.Size(156, 46);
            this.GuessTheFlag.TabIndex = 1;
            this.GuessTheFlag.Text = "Guess The Flag";
            this.GuessTheFlag.UseVisualStyleBackColor = true;
            // 
            // MathGeek
            // 
            this.MathGeek.Location = new System.Drawing.Point(423, 185);
            this.MathGeek.Name = "MathGeek";
            this.MathGeek.Size = new System.Drawing.Size(156, 46);
            this.MathGeek.TabIndex = 2;
            this.MathGeek.Text = "Math Geek";
            this.MathGeek.UseVisualStyleBackColor = true;
            // 
            // Scramble
            // 
            this.Scramble.Location = new System.Drawing.Point(616, 185);
            this.Scramble.Name = "Scramble";
            this.Scramble.Size = new System.Drawing.Size(156, 46);
            this.Scramble.TabIndex = 3;
            this.Scramble.Text = "Scramble";
            this.Scramble.UseVisualStyleBackColor = true;
            // 
            // Switches
            // 
            this.Switches.Location = new System.Drawing.Point(29, 290);
            this.Switches.Name = "Switches";
            this.Switches.Size = new System.Drawing.Size(156, 46);
            this.Switches.TabIndex = 4;
            this.Switches.Text = "Switches";
            this.Switches.UseVisualStyleBackColor = true;
            // 
            // Battleship
            // 
            this.Battleship.Location = new System.Drawing.Point(225, 290);
            this.Battleship.Name = "Battleship";
            this.Battleship.Size = new System.Drawing.Size(156, 46);
            this.Battleship.TabIndex = 5;
            this.Battleship.Text = "Battleship";
            this.Battleship.UseVisualStyleBackColor = true;
            // 
            // DefeatThePokemon
            // 
            this.DefeatThePokemon.Location = new System.Drawing.Point(423, 290);
            this.DefeatThePokemon.Name = "DefeatThePokemon";
            this.DefeatThePokemon.Size = new System.Drawing.Size(156, 46);
            this.DefeatThePokemon.TabIndex = 6;
            this.DefeatThePokemon.Text = "Defeat the Pokémon";
            this.DefeatThePokemon.UseVisualStyleBackColor = true;
            // 
            // MemoryMatch
            // 
            this.MemoryMatch.Location = new System.Drawing.Point(616, 290);
            this.MemoryMatch.Name = "MemoryMatch";
            this.MemoryMatch.Size = new System.Drawing.Size(156, 46);
            this.MemoryMatch.TabIndex = 7;
            this.MemoryMatch.Text = "Memory Match";
            this.MemoryMatch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.MemoryMatch);
            this.Controls.Add(this.DefeatThePokemon);
            this.Controls.Add(this.Battleship);
            this.Controls.Add(this.Switches);
            this.Controls.Add(this.Scramble);
            this.Controls.Add(this.MathGeek);
            this.Controls.Add(this.GuessTheFlag);
            this.Controls.Add(this.TicTacToe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button TicTacToe;
        private Button GuessTheFlag;
        private Button MathGeek;
        private Button Scramble;
        private Button Switches;
        private Button Battleship;
        private Button DefeatThePokemon;
        private Button MemoryMatch;
    }
}