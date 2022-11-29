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
        private int[] flippedButton = new int[2];
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

            button1.BackgroundImage = Resources.lightgrey;
            button2.BackgroundImage = Resources.lightgrey;
            button3.BackgroundImage = Resources.lightgrey;
            button4.BackgroundImage = Resources.lightgrey;
            button5.BackgroundImage = Resources.lightgrey;
            button6.BackgroundImage = Resources.lightgrey;
            button7.BackgroundImage = Resources.lightgrey;
            button8.BackgroundImage = Resources.lightgrey;
            button9.BackgroundImage = Resources.lightgrey;
            button10.BackgroundImage = Resources.lightgrey;
            button11.BackgroundImage = Resources.lightgrey;
            button12.BackgroundImage = Resources.lightgrey;
            button13.BackgroundImage = Resources.lightgrey;
            button14.BackgroundImage = Resources.lightgrey;
            button15.BackgroundImage = Resources.lightgrey;
            button16.BackgroundImage = Resources.lightgrey;
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
            flippedButton[mm.getTurns()] = 1;
            mm++;
            button1.Enabled = false;
            if(mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 14)
                {
                    flipButton();
                    button1.BackgroundImage = Resources.lightgrey;
                    button1.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if(mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = Resources.SleepStair;
            flippedButton[mm.getTurns()] = 2;
            mm++;
            button2.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 10)
                {
                    flipButton();
                    button2.BackgroundImage = Resources.lightgrey;
                    button2.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources.haloSleep;
            flippedButton[mm.getTurns()] = 3;
            mm++;
            button3.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 11)
                {
                    flipButton();
                    button3.BackgroundImage = Resources.lightgrey;
                    button3.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources.Kiana;
            flippedButton[mm.getTurns()] = 4;
            mm++;
            button4.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 12)
                {
                    flipButton();
                    button4.BackgroundImage = Resources.lightgrey;
                    button4.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackgroundImage = Resources.Ty;
            flippedButton[mm.getTurns()] = 5;
            mm++;
            button5.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 9)
                {
                    flipButton();
                    button5.BackgroundImage = Resources.lightgrey;
                    button5.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = Resources.KK;
            flippedButton[mm.getTurns()] = 6;
            mm++;
            button6.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 15)
                {
                    flipButton();
                    button6.BackgroundImage = Resources.lightgrey;
                    button6.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackgroundImage = Resources.Ethan;
            flippedButton[mm.getTurns()] = 7;
            mm++;
            button7.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 13)
                {
                    flipButton();
                    button7.BackgroundImage = Resources.lightgrey;
                    button7.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackgroundImage = Resources.Omar;
            flippedButton[mm.getTurns()] = 8;
            mm++;
            button8.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 16)
                {
                    flipButton();
                    button8.BackgroundImage = Resources.lightgrey;
                    button8.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackgroundImage = Resources.Ty;
            flippedButton[mm.getTurns()] = 9;
            mm++;
            button9.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 5)
                {
                    flipButton();
                    button9.BackgroundImage = Resources.lightgrey;
                    button9.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackgroundImage = Resources.SleepStair;
            flippedButton[mm.getTurns()] = 10;
            mm++;
            button10.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 2)
                {
                    flipButton();
                    button10.BackgroundImage = Resources.lightgrey;
                    button10.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackgroundImage = Resources.haloSleep;
            flippedButton[mm.getTurns()] = 11;
            mm++;
            button11.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 3)
                {
                    flipButton();
                    button11.BackgroundImage = Resources.lightgrey;
                    button11.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackgroundImage = Resources.Kiana;
            flippedButton[mm.getTurns()] = 12;
            mm++;
            button12.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 4)
                {
                    flipButton();
                    button12.BackgroundImage = Resources.lightgrey;
                    button12.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackgroundImage = Resources.Ethan;
            flippedButton[mm.getTurns()] = 13;
            mm++;
            button13.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 7)
                {
                    flipButton();
                    button13.BackgroundImage = Resources.lightgrey;
                    button13.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackgroundImage = Resources.Cole_Ellishill;
            flippedButton[mm.getTurns()] = 14;
            mm++;
            button14.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 1)
                {
                    flipButton();
                    button14.BackgroundImage = Resources.lightgrey;
                    button14.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackgroundImage = Resources.KK;
            flippedButton[mm.getTurns()] = 15;
            mm++;
            button15.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 6)
                {
                    flipButton();
                    button15.BackgroundImage = Resources.lightgrey;
                    button15.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackgroundImage = Resources.Omar;
            flippedButton[mm.getTurns()] = 16;
            mm++;
            button16.Enabled = false;
            if (mm.getTurns() == 2)
            {
                MessageBox.Show("It made it here");
                if (flippedButton[0] != 8)
                {
                    flipButton();
                    button16.BackgroundImage = Resources.lightgrey;
                    button16.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Nice");
                }
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

            string minutesSecondsStr = ConvertMinutesSecondsToStr(minutes, seconds);

            label2.Text = minutesSecondsStr;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Play\nClick a button to reveal an image.\nClick another button to reveal another image.\nIf the images are the same, they will stay revealed. If they are not the same, they will hide themselves again.\nFlip all pairs to win the game.");
        }

        private void flipButton()
        {
            if (flippedButton[0] == 1)
            {
                button1.Enabled = true;
                button1.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 2)
            {
                button2.Enabled = true;
                button2.BackgroundImage = Resources.lightgrey; 
            }
            else if (flippedButton[0] == 3)
            {
                button3.Enabled = true;
                button3.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 4)
            {
                button4.Enabled = true;
                button4.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 5)
            {
                button5.Enabled = true;
                button5.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 6)
            {
                button6.Enabled = true;
                button6.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 7)
            {
                button7.Enabled = true;
                button7.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 8)
            {
                button8.Enabled = true;
                button8.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 9)
            {
                button9.Enabled = true;
                button9.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 10)
            {
                button10.Enabled = true;
                button10.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 11)
            {
                button11.Enabled = true;
                button11.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 12)
            {
                button12.Enabled = true;
                button12.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 13)
            {
                button13.Enabled = true;
                button13.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 14)
            {
                button14.Enabled = true;
                button14.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 15)
            {
                button15.Enabled = true;
                button15.BackgroundImage = Resources.lightgrey;
            }
            else if (flippedButton[0] == 16)
            {
                button16.Enabled = true;
                button16.BackgroundImage = Resources.lightgrey;
            }
        }

    }
}
