using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombDefuse
{
    public partial class MathGeekForm : Form
    {
        private MathGeek mathg;
        private int seconds, minutes;
        public MathGeekForm()
        {
            InitializeComponent();
        }

        private Form1? mainForm;
        public MathGeekForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
            mathg = new();
            mathg.data.SetId(3);
            
        }
        private void MathGeekForm_Load(object sender, EventArgs e)
        {
            minutes = 0;
            seconds =0;
           
            timer1.Start();
            label1.Text = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";
            string isOpened = mathg.readEquationFile();
            labelequation.Text = mathg.getEquation();
            minutes=mathg.data.GetMinutes();
            seconds=mathg.data.GetSeconds();
            label1.Text = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";

            mathg.data.SetActivityStatus(true);
            if(isOpened!=" ")
            {
                labelequation.Text = isOpened;
            }
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            mathg.data.SetMinutes(minutes);
            mathg.data.SetSeconds(seconds);
            mathg.SaveFile();
            this.Close();
            mainForm.Form1_Load(mathg.data);
            mainForm.Show();
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text == mathg.getAnswer())
            {
                mathg.data.SetSeconds(seconds);
                mathg.data.SetMinutes(minutes);
                mathg.data.SetCompletionStatus(true);
                File.Delete("equationsSaved.txt");
                timer1.Stop();
                MessageBox.Show("You Won!"); 
                this.Close();
                mainForm.Form1_Load(mathg.data);
                mainForm.Show();
            }
            else
                MessageBox.Show("Try Again");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds < 60)
            {
                seconds++;
            }
            else
            {
                seconds = 0;
                minutes++;
            }
            string minutesSecondsStr = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";
            label1.Text = minutesSecondsStr;
        }
    }
}
