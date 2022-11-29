using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombDefuse
{
    public partial class ScrambleForm : Form
    {
        private Scramble scram;
        private int minutes, seconds;
        public ScrambleForm()
        {
            InitializeComponent();
        }

        private Form1? mainForm;
        public ScrambleForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
            scram = new Scramble();
            string chosenWord=scram.getWord();
            string[] winningWords=scram.getWinningWords();
            buttonE.Text = chosenWord[4].ToString();
            buttonD.Text = chosenWord[3].ToString();
            buttonT.Text = chosenWord[0].ToString();
            buttonA.Text = chosenWord[2].ToString();
            buttonR.Text = chosenWord[1].ToString();
        }
        private void ScrambleForm_Load(object sender, EventArgs e)
        {
            minutes = 0;
            seconds = 0;
            timer1.Start();
            label2.Text = "00 minutes :: 00 seconds elapsed";

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            bool result = scram.checkGuess(ChecktTextBox.Text.ToUpper());
            if (result == true)
            {
                MessageBox.Show("You Won");
                this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Try again");
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
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
