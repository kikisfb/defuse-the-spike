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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefeatThePokemonForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WaterGun = new System.Windows.Forms.Button();
            this.DragonBreath = new System.Windows.Forms.Button();
            this.Psychic = new System.Windows.Forms.Button();
            this.GrassKnot = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(318, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WaterGun
            // 
            this.WaterGun.BackColor = System.Drawing.Color.Blue;
            this.WaterGun.Location = new System.Drawing.Point(10, 338);
            this.WaterGun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WaterGun.Name = "WaterGun";
            this.WaterGun.Size = new System.Drawing.Size(181, 112);
            this.WaterGun.TabIndex = 1;
            this.WaterGun.Text = "Water Gun";
            this.WaterGun.UseVisualStyleBackColor = false;
            this.WaterGun.Click += new System.EventHandler(this.WaterGun_Click);
            // 
            // DragonBreath
            // 
            this.DragonBreath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DragonBreath.Location = new System.Drawing.Point(272, 338);
            this.DragonBreath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DragonBreath.Name = "DragonBreath";
            this.DragonBreath.Size = new System.Drawing.Size(181, 112);
            this.DragonBreath.TabIndex = 2;
            this.DragonBreath.Text = "Dragon Breath";
            this.DragonBreath.UseVisualStyleBackColor = false;
            this.DragonBreath.Click += new System.EventHandler(this.DragonBreath_Click);
            // 
            // Psychic
            // 
            this.Psychic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Psychic.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Psychic.Location = new System.Drawing.Point(544, 338);
            this.Psychic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Psychic.Name = "Psychic";
            this.Psychic.Size = new System.Drawing.Size(176, 112);
            this.Psychic.TabIndex = 3;
            this.Psychic.Text = "Psychic";
            this.Psychic.UseVisualStyleBackColor = false;
            this.Psychic.Click += new System.EventHandler(this.Psychic_Click);
            // 
            // GrassKnot
            // 
            this.GrassKnot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GrassKnot.Location = new System.Drawing.Point(799, 338);
            this.GrassKnot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrassKnot.Name = "GrassKnot";
            this.GrassKnot.Size = new System.Drawing.Size(181, 112);
            this.GrassKnot.TabIndex = 4;
            this.GrassKnot.Text = "Grass Knot";
            this.GrassKnot.UseVisualStyleBackColor = false;
            this.GrassKnot.Click += new System.EventHandler(this.GrassKnot_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(17, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 52);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Defeat The Pokemon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DefeatThePokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.GrassKnot);
            this.Controls.Add(this.Psychic);
            this.Controls.Add(this.DragonBreath);
            this.Controls.Add(this.WaterGun);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}