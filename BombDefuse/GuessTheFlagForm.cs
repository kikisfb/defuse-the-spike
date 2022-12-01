using BombDefuse.Properties;
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
    public partial class GuessTheFlagForm : Form
    {
        private Random random;
        private GuessTheFlag gfl;
        private int minutes, seconds;

        private Form1? mainForm;
        public GuessTheFlagForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();

            random = new();
            gfl = new();
            gfl.data.SetId(2);
            gfl.data.SetActivityStatus(true);
        }

        private void SetImageFromFlag(string flag)
        {
            if(flag == "canada")
            {
                pictureBox1.BackgroundImage = Resources.canada;
            }
            else if(flag == "brazil")
            {
                pictureBox1.BackgroundImage = Resources.brazil;
            }
            else if (flag == "australia")
            {
                pictureBox1.BackgroundImage = Resources.australia;
            }
            else if (flag == "iran")
            {
                pictureBox1.BackgroundImage = Resources.iran;
            }
            else if (flag == "poland")
            {
                pictureBox1.BackgroundImage = Resources.poland;
            }
            else if (flag == "china")
            {
                pictureBox1.BackgroundImage = Resources.china;
            }
            else if (flag == "france")
            {
                pictureBox1.BackgroundImage = Resources.france;
            }
            else if (flag == "germany")
            {
                pictureBox1.BackgroundImage = Resources.germany;
            }
            else if (flag == "mexico")
            {
                pictureBox1.BackgroundImage = Resources.mexico;
            }
            else if (flag == "japan")
            {
                pictureBox1.BackgroundImage = Resources.japan;
            }
        }

        private void GuessTheFlagForm_Load(object sender, EventArgs e)
        {
            /* Read past state if existing */
            gfl.ReadState();

            minutes = gfl.data.GetMinutes();
            seconds = gfl.data.GetSeconds();
            label2.Text = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";
            timer1.Start();

            /* Start with the first flag */
            if(gfl.GetCurrentFlag() == "")
                gfl.NextFlag(random);
            SetImageFromFlag(gfl.GetCurrentFlag());
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;

            if(thisButton.Name == "check")
            {
                textBox1.Text = textBox1.Text.Trim(new char[] { '\r', '\n'});
                Validation validation = gfl.TakeInput(textBox1.Text);
                if(validation == Validation.EMPTY)
                {
                    MessageBox.Show("The input can't be an empty guess. Try again!");
                }
                else 
                {
                    if (validation == Validation.NOALPHA)
                    {
                        MessageBox.Show("The input can't contain numbers. Try again!");
                    }
                    else
                    {
                        bool guessIsCorrect = gfl.FlagMatches(textBox1.Text);
                        if (guessIsCorrect)
                        {
                            timer1.Stop();
                            MessageBox.Show("You have guessed the right flag! Click OK to go back to the main menu.");
                            gfl.data.SetCompletionStatus(true);
                            File.Delete("gflState.txt");
                            closeForm();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Wrong guess! Click OK to try again with a different flag.");
                            gfl.AddCurrentToUsed();
                            gfl.NextFlag(random);
                            SetImageFromFlag(gfl.GetCurrentFlag());
                        }
                    }

                    textBox1.Text = "";
                }
            }
            else
            {
                closeForm();
            }

            gfl.SaveState();
        }

        private void closeForm()
        {
            mainForm.Show();

            // Call the main form load to pass PuzzleData
            gfl.data.SetMinutes(minutes);
            gfl.data.SetSeconds(seconds);
            mainForm.Form1_Load(gfl.data);

            this.Close();
        }

        private void EnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button_Click(check, e);
            }
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
