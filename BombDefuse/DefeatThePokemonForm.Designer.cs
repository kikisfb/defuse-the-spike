namespace BombDefuse
{
    partial class DefeatThePokemonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefeatThePokemonForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WaterGun = new System.Windows.Forms.Button();
            this.DragonBreath = new System.Windows.Forms.Button();
            this.Psychic = new System.Windows.Forms.Button();
            this.GrassKnot = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HowToPlay = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(361, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WaterGun
            // 
            this.WaterGun.BackColor = System.Drawing.Color.Blue;
            this.WaterGun.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WaterGun.Location = new System.Drawing.Point(14, 603);
            this.WaterGun.Name = "WaterGun";
            this.WaterGun.Size = new System.Drawing.Size(207, 149);
            this.WaterGun.TabIndex = 1;
            this.WaterGun.Text = "Water Gun";
            this.WaterGun.UseVisualStyleBackColor = false;
            this.WaterGun.Click += new System.EventHandler(this.WaterGun_Click);
            // 
            // DragonBreath
            // 
            this.DragonBreath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DragonBreath.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DragonBreath.Location = new System.Drawing.Point(307, 603);
            this.DragonBreath.Name = "DragonBreath";
            this.DragonBreath.Size = new System.Drawing.Size(207, 149);
            this.DragonBreath.TabIndex = 2;
            this.DragonBreath.Text = "Dragon Breath";
            this.DragonBreath.UseVisualStyleBackColor = false;
            this.DragonBreath.Click += new System.EventHandler(this.DragonBreath_Click);
            // 
            // Psychic
            // 
            this.Psychic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Psychic.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Psychic.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Psychic.Location = new System.Drawing.Point(619, 603);
            this.Psychic.Name = "Psychic";
            this.Psychic.Size = new System.Drawing.Size(201, 149);
            this.Psychic.TabIndex = 3;
            this.Psychic.Text = "Psychic";
            this.Psychic.UseVisualStyleBackColor = false;
            this.Psychic.Click += new System.EventHandler(this.Psychic_Click);
            // 
            // GrassKnot
            // 
            this.GrassKnot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GrassKnot.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrassKnot.Location = new System.Drawing.Point(911, 603);
            this.GrassKnot.Name = "GrassKnot";
            this.GrassKnot.Size = new System.Drawing.Size(207, 149);
            this.GrassKnot.TabIndex = 4;
            this.GrassKnot.Text = "Grass Knot";
            this.GrassKnot.UseVisualStyleBackColor = false;
            this.GrassKnot.Click += new System.EventHandler(this.GrassKnot_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(19, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 69);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 74);
            this.label1.TabIndex = 7;
            this.label1.Text = "Defeat The Pokemon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HowToPlay
            // 
            this.HowToPlay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HowToPlay.Location = new System.Drawing.Point(968, 56);
            this.HowToPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(139, 101);
            this.HowToPlay.TabIndex = 8;
            this.HowToPlay.Text = "How To Play";
            this.HowToPlay.UseVisualStyleBackColor = true;
            this.HowToPlay.Click += new System.EventHandler(this.button6_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(883, 269);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 75);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "Correct Answers:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // DefeatThePokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 767);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.HowToPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.GrassKnot);
            this.Controls.Add(this.Psychic);
            this.Controls.Add(this.DragonBreath);
            this.Controls.Add(this.WaterGun);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DefeatThePokemonForm";
            this.Text = "DefeatThePokemonForm";
            this.Load += new System.EventHandler(this.DefeatThePokemonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button WaterGun;
        private Button DragonBreath;
        private Button Psychic;
        private Button GrassKnot;
        private Button HowToPlay;
        private ProgressBar progressBar1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}