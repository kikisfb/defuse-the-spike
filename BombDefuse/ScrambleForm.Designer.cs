﻿namespace BombDefuse
{
    partial class ScrambleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrambleForm));
            this.checkButton = new System.Windows.Forms.Button();
            this.ChecktTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.RosyBrown;
            this.checkButton.Location = new System.Drawing.Point(197, 285);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(87, 36);
            this.checkButton.TabIndex = 15;
            this.checkButton.Text = "CHECK";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ChecktTextBox
            // 
            this.ChecktTextBox.Location = new System.Drawing.Point(121, 200);
            this.ChecktTextBox.Multiline = true;
            this.ChecktTextBox.Name = "ChecktTextBox";
            this.ChecktTextBox.Size = new System.Drawing.Size(266, 67);
            this.ChecktTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "Make a 5-letter word with the letters below";
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonR.Location = new System.Drawing.Point(415, 117);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(53, 56);
            this.buttonR.TabIndex = 12;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonA.Location = new System.Drawing.Point(324, 117);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(53, 56);
            this.buttonA.TabIndex = 11;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonT.Location = new System.Drawing.Point(231, 117);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(53, 56);
            this.buttonT.TabIndex = 10;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonD.Location = new System.Drawing.Point(133, 117);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(53, 56);
            this.buttonD.TabIndex = 9;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonE.Location = new System.Drawing.Point(41, 117);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(53, 56);
            this.buttonE.TabIndex = 8;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // ScrambleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 343);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.ChecktTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonE);
            this.Name = "ScrambleForm";
            this.Text = "ScrambleForm";
            this.Load += new System.EventHandler(this.ScrambleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button checkButton;
        private TextBox ChecktTextBox;
        private Label label1;
        private Button buttonR;
        private Button buttonA;
        private Button buttonT;
        private Button buttonD;
        private Button buttonE;
    }
}