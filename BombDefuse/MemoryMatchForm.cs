using BombDefuse.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BombDefuse
{
    
    public partial class MemoryMatchForm : Form
    {
        private int minutes, seconds;
        private MemoryMatch mm;
        public MemoryMatchForm()
        {
            InitializeComponent();
        }

        private Form1? mainForm;
        public MemoryMatchForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();

            mm = new();
        }
        private void MemoryMatchForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Memory Match is working!");

            minutes = 0;
            seconds = 0;
            timer1.Start();
            label2.Text = ConvertMinutesSecondsToStr(minutes, seconds);
            
        }

        private string ConvertMinutesSecondsToStr(int minutes, int seconds)
        {
            string displaySeconds;
            string displayMinutes;

            // converts minutes and seconds to a user-friendly format
            if (seconds < 10)
            {
                displaySeconds = $"{0}{seconds}";
            }
            else
                displaySeconds = $"{seconds}";

            if (minutes < 10)
            {
                displayMinutes = $"{0}{minutes}";
            }
            else
            {
                displayMinutes = $"{minutes}";
            }

            return $"{displayMinutes} minutes : {displaySeconds} : seconds elapsed";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //mm.data.SetMinutes(minutes);
           // mm.data.SetSeconds(seconds);
            //mm.SaveToFile();
            //mainForm.Form1_Load(dtf.data);
            this.Close();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.Cole_Ellishill;
            mm++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = Resources.SleepStair;
            mm++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources.haloSleep;
            mm++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources.Kiana;
            mm++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackgroundImage = Resources.Ty;
            mm++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = Resources.KK;
            mm++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackgroundImage = Resources.Ethan;
            mm++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackgroundImage = Resources.Omar;
            mm++;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

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

            string minutesSecondsStr = ConvertMinutesSecondsToStr(minutes, seconds);

            label2.Text = minutesSecondsStr;
        }
    }
}
