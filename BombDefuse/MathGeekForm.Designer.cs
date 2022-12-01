namespace BombDefuse
{
    partial class MathGeekForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathGeekForm));
            this.GoBackButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.equationLabel = new System.Windows.Forms.Label();
            this.labelequation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackButton.BackgroundImage")));
            this.GoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoBackButton.Location = new System.Drawing.Point(10, 10);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(52, 48);
            this.GoBackButton.TabIndex = 0;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerTextBox.Location = new System.Drawing.Point(148, 275);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(225, 112);
            this.AnswerTextBox.TabIndex = 3;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckButton.Location = new System.Drawing.Point(215, 407);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(82, 25);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Plum;
            this.label2.Location = new System.Drawing.Point(88, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 84);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer the equation \r\nin the text box below";
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.equationLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equationLabel.Location = new System.Drawing.Point(103, 223);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(0, 51);
            this.equationLabel.TabIndex = 1;
            // 
            // labelequation
            // 
            this.labelequation.AutoSize = true;
            this.labelequation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelequation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelequation.ForeColor = System.Drawing.Color.Purple;
            this.labelequation.Location = new System.Drawing.Point(170, 194);
            this.labelequation.Name = "labelequation";
            this.labelequation.Size = new System.Drawing.Size(0, 32);
            this.labelequation.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // MathGeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelequation);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equationLabel);
            this.Controls.Add(this.GoBackButton);
            this.Name = "MathGeekForm";
            this.Text = "MathGeekForm";
            this.Load += new System.EventHandler(this.MathGeekForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GoBackButton;
        private TextBox AnswerTextBox;
        private Button CheckButton;
        private Label label2;
        private Label equationLabel;
        private Label labelequation;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}