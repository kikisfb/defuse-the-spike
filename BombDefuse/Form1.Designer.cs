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
            this.components = new System.ComponentModel.Container();
            this.TicTacToe = new System.Windows.Forms.Button();
            this.GuessTheFlag = new System.Windows.Forms.Button();
            this.MathGeek = new System.Windows.Forms.Button();
            this.Scramble = new System.Windows.Forms.Button();
            this.Switches = new System.Windows.Forms.Button();
            this.Battleship = new System.Windows.Forms.Button();
            this.DefeatThePokemon = new System.Windows.Forms.Button();
            this.MemoryMatch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TicTacToe
            // 
            this.TicTacToe.Location = new System.Drawing.Point(25, 139);
            this.TicTacToe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicTacToe.Name = "TicTacToe";
            this.TicTacToe.Size = new System.Drawing.Size(136, 34);
            this.TicTacToe.TabIndex = 0;
            this.TicTacToe.Text = "TicTacToe";
            this.TicTacToe.UseVisualStyleBackColor = true;
            this.TicTacToe.Click += new System.EventHandler(this.TicTacToe_Click);
            // 
            // GuessTheFlag
            // 
            this.GuessTheFlag.Location = new System.Drawing.Point(197, 139);
            this.GuessTheFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuessTheFlag.Name = "GuessTheFlag";
            this.GuessTheFlag.Size = new System.Drawing.Size(136, 34);
            this.GuessTheFlag.TabIndex = 1;
            this.GuessTheFlag.Text = "Guess The Flag";
            this.GuessTheFlag.UseVisualStyleBackColor = true;
            this.GuessTheFlag.Click += new System.EventHandler(this.GuessTheFlag_Click);
            // 
            // MathGeek
            // 
            this.MathGeek.Location = new System.Drawing.Point(370, 139);
            this.MathGeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MathGeek.Name = "MathGeek";
            this.MathGeek.Size = new System.Drawing.Size(136, 34);
            this.MathGeek.TabIndex = 2;
            this.MathGeek.Text = "Math Geek";
            this.MathGeek.UseVisualStyleBackColor = true;
            this.MathGeek.Click += new System.EventHandler(this.MathGeek_Click);
            // 
            // Scramble
            // 
            this.Scramble.Location = new System.Drawing.Point(539, 139);
            this.Scramble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Scramble.Name = "Scramble";
            this.Scramble.Size = new System.Drawing.Size(136, 34);
            this.Scramble.TabIndex = 3;
            this.Scramble.Text = "Scramble";
            this.Scramble.UseVisualStyleBackColor = true;
            this.Scramble.Click += new System.EventHandler(this.Scramble_Click);
            // 
            // Switches
            // 
            this.Switches.Location = new System.Drawing.Point(25, 218);
            this.Switches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Switches.Name = "Switches";
            this.Switches.Size = new System.Drawing.Size(136, 34);
            this.Switches.TabIndex = 4;
            this.Switches.Text = "Switches";
            this.Switches.UseVisualStyleBackColor = true;
            this.Switches.Click += new System.EventHandler(this.Switches_Click);
            // 
            // Battleship
            // 
            this.Battleship.Location = new System.Drawing.Point(197, 218);
            this.Battleship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Battleship.Name = "Battleship";
            this.Battleship.Size = new System.Drawing.Size(136, 34);
            this.Battleship.TabIndex = 5;
            this.Battleship.Text = "Battleship";
            this.Battleship.UseVisualStyleBackColor = true;
            this.Battleship.Click += new System.EventHandler(this.Battleship_Click);
            // 
            // DefeatThePokemon
            // 
            this.DefeatThePokemon.Location = new System.Drawing.Point(370, 218);
            this.DefeatThePokemon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DefeatThePokemon.Name = "DefeatThePokemon";
            this.DefeatThePokemon.Size = new System.Drawing.Size(136, 34);
            this.DefeatThePokemon.TabIndex = 6;
            this.DefeatThePokemon.Text = "Defeat the Pokémon";
            this.DefeatThePokemon.UseVisualStyleBackColor = true;
            this.DefeatThePokemon.Click += new System.EventHandler(this.DefeatThePokemon_Click);
            // 
            // MemoryMatch
            // 
            this.MemoryMatch.Location = new System.Drawing.Point(539, 218);
            this.MemoryMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemoryMatch.Name = "MemoryMatch";
            this.MemoryMatch.Size = new System.Drawing.Size(136, 34);
            this.MemoryMatch.TabIndex = 7;
            this.MemoryMatch.Text = "Memory Match";
            this.MemoryMatch.UseVisualStyleBackColor = true;
            this.MemoryMatch.Click += new System.EventHandler(this.MemoryMatch_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Defuse the Spike";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(247, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "00 minutes : 00 seconds left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Average puzzle completion time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "00 minutes : 00 seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemoryMatch);
            this.Controls.Add(this.DefeatThePokemon);
            this.Controls.Add(this.Battleship);
            this.Controls.Add(this.Switches);
            this.Controls.Add(this.Scramble);
            this.Controls.Add(this.MathGeek);
            this.Controls.Add(this.GuessTheFlag);
            this.Controls.Add(this.TicTacToe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}