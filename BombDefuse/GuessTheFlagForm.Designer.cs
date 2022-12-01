namespace BombDefuse
{
    partial class GuessTheFlagForm
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
            this.goBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.BackgroundImage = global::BombDefuse.Properties.Resources._44927;
            this.goBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goBack.Location = new System.Drawing.Point(12, 11);
            this.goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(66, 52);
            this.goBack.TabIndex = 3;
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guess the country of the flag";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(428, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 75);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(EnterKeyPressed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "00 minutes : 00 seconds elapsed";
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.LightGreen;
            this.check.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check.Location = new System.Drawing.Point(488, 233);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(107, 42);
            this.check.TabIndex = 7;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(98, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 156);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GuessTheFlagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BombDefuse.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GuessTheFlagForm";
            this.Text = "GuessTheFlagForm";
            this.Load += new System.EventHandler(this.GuessTheFlagForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button goBack;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button check;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}