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
            scram.data.SetId(4);
            
        }
        private void ScrambleForm_Load(object sender, EventArgs e)
        {
            scram.data.SetActivityStatus(true);
            minutes = 0;
            seconds = 0;
            timer1.Start();

            label2.Text = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";
            string chosenWord;
            
            string isLoaded = scram.readFile();
            
            
            chosenWord = scram.getWord();
               
            minutes = scram.data.GetMinutes();
            seconds = scram.data.GetSeconds();
            label2.Text = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";
            ;
            buttonE.Text = chosenWord[4].ToString();
            buttonD.Text = chosenWord[3].ToString();
            buttonT.Text = chosenWord[0].ToString();
            buttonA.Text = chosenWord[2].ToString();
            buttonR.Text = chosenWord[1].ToString();
        }
        private void closeForm()
        {
            mainForm.Show();
            scram.data.SetMinutes(minutes);
            scram.data.SetSeconds(seconds);
            // mainForm.Form1_Load(scram.data);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {   
            bool result = scram.checkGuess(ChecktTextBox.Text.ToUpper());
            
            if (result == true)
            {
                scram.data.SetMinutes(minutes);
                scram.data.SetSeconds(seconds);
                scram.data.SetCompletionStatus(true);
                File.Delete("wordSaved.txt");
                timer1.Stop();
                MessageBox.Show("You Won");
                this.Close();
                mainForm.Form1_Load(scram.data);
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
            scram.data.SetMinutes(minutes);
            scram.data.SetSeconds(seconds);
            scram.SaveFile();

            this.Close();
            mainForm.Form1_Load(scram.data);

            mainForm.Show();
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

            label2.Text = minutesSecondsStr;
        }
    }
}
