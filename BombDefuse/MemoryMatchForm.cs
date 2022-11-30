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
        private bool[] flippedButtonsAtLoad = new bool[16];
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

            mm.data.SetActivityStatus(true);
            mm.data.SetId(8);
        }
        private void MemoryMatchForm_Load(object sender, EventArgs e)
        {
            minutes = 0;
            seconds = 0;
            timer1.Start();            

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

            flippedButtonsAtLoad = mm.ReadFromFile();
            minutes = mm.data.GetMinutes();
            seconds = mm.data.GetSeconds();
            label2.Text = ConvertMinutesSecondsToStr(minutes, seconds);
            if (flippedButtonsAtLoad[0] == true)
            {
                button1.BackgroundImage = Resources.Cole_Ellishill;
                button1.Enabled = false;
            }
            if (flippedButtonsAtLoad[1] == true)
            {
                button2.BackgroundImage = Resources.SleepStair;
                button2.Enabled = false;
            }
            if (flippedButtonsAtLoad[2] == true)
            {
                button3.BackgroundImage = Resources.haloSleep;
                button3.Enabled = false;
            }
            if (flippedButtonsAtLoad[3] == true)
            {
                button4.BackgroundImage = Resources.Kiana;
                button4.Enabled = false;
            }
            if (flippedButtonsAtLoad[4] == true)
            {
                button5.BackgroundImage = Resources.Ty;
                button5.Enabled = false;
            }
            if (flippedButtonsAtLoad[5] == true)
            {
                button6.BackgroundImage = Resources.KK;
                button6.Enabled = false;
            }
            if (flippedButtonsAtLoad[6] == true)
            {
                button7.BackgroundImage = Resources.Ethan;
                button7.Enabled = false;
            }
            if (flippedButtonsAtLoad[7] == true)
            {
                button8.BackgroundImage = Resources.Omar;
                button8.Enabled = false;
            }
            if (flippedButtonsAtLoad[8] == true)
            {
                button9.BackgroundImage = Resources.Ty;
                button9.Enabled = false;
            }
            if (flippedButtonsAtLoad[9] == true)
            {
                button10.BackgroundImage = Resources.SleepStair;
                button10.Enabled = false;
            }
            if (flippedButtonsAtLoad[10] == true)
            {
                button11.BackgroundImage = Resources.haloSleep;
                button11.Enabled = false;
            }
            if (flippedButtonsAtLoad[11] == true)
            {
                button12.BackgroundImage = Resources.Kiana;
                button12.Enabled = false;
            }
            if (flippedButtonsAtLoad[12] == true)
            {
                button13.BackgroundImage = Resources.Ethan;
                button13.Enabled = false;
            }
            if (flippedButtonsAtLoad[13] == true)
            {
                button14.BackgroundImage = Resources.Cole_Ellishill;
                button14.Enabled = false;
            }
            if (flippedButtonsAtLoad[14] == true)
            {
                button15.BackgroundImage = Resources.KK;
                button15.Enabled = false;
            }
            if (flippedButtonsAtLoad[15] == true)
            {
                button16.BackgroundImage = Resources.Omar;
                button16.Enabled = false;
            }
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
            mm.data.SetMinutes(minutes);
            mm.data.SetSeconds(seconds);
            mm.SaveToFile(flippedButtonsAtLoad);
            this.Close();
            mainForm.Show();
            mainForm.Form1_Load(mm.data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.Cole_Ellishill;
            flippedButton[mm.getTurns()] = 1;
            mm++;
            button1.Enabled = false;
            if(mm.getTurns() == 2)
            {
                
                if (flippedButton[0] != 14)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button1.BackgroundImage = Resources.lightgrey;
                    button1.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[0] = true;
                    flippedButtonsAtLoad[13] = true;
                }
                mm.setTurns(0);
                if(mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 10)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button2.BackgroundImage = Resources.lightgrey;
                    button2.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[1] = true;
                    flippedButtonsAtLoad[9] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 11)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button3.BackgroundImage = Resources.lightgrey;
                    button3.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[2] = true;
                    flippedButtonsAtLoad[10] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 12)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button4.BackgroundImage = Resources.lightgrey;
                    button4.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[3] = true;
                    flippedButtonsAtLoad[11] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 9)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button5.BackgroundImage = Resources.lightgrey;
                    button5.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[4] = true;
                    flippedButtonsAtLoad[8] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 15)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button6.BackgroundImage = Resources.lightgrey;
                    button6.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[5] = true;
                    flippedButtonsAtLoad[14] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 13)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button7.BackgroundImage = Resources.lightgrey;
                    button7.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[6] = true;
                    flippedButtonsAtLoad[12] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 16)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button8.BackgroundImage = Resources.lightgrey;
                    button8.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[7] = true;
                    flippedButtonsAtLoad[15] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 5)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button9.BackgroundImage = Resources.lightgrey;
                    button9.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[8] = true;
                    flippedButtonsAtLoad[4] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 2)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button10.BackgroundImage = Resources.lightgrey;
                    button10.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[9] = true;
                    flippedButtonsAtLoad[1] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 3)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button11.BackgroundImage = Resources.lightgrey;
                    button11.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[10] = true;
                    flippedButtonsAtLoad[2] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 4)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button12.BackgroundImage = Resources.lightgrey;
                    button12.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[11] = true;
                    flippedButtonsAtLoad[3] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 7)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button13.BackgroundImage = Resources.lightgrey;
                    button13.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[12] = true;
                    flippedButtonsAtLoad[6] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 1)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button14.BackgroundImage = Resources.lightgrey;
                    button14.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[13] = true;
                    flippedButtonsAtLoad[0] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 6)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button15.BackgroundImage = Resources.lightgrey;
                    button15.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[14] = true;
                    flippedButtonsAtLoad[5] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show(); 
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
                
                if (flippedButton[0] != 8)
                {
                    MessageBox.Show("Try Again");
                    flipButton();
                    button16.BackgroundImage = Resources.lightgrey;
                    button16.Enabled = true;
                }
                else
                {
                    mm.IncrementPairs();
                    flippedButtonsAtLoad[15] = true;
                    flippedButtonsAtLoad[7] = true;
                }
                mm.setTurns(0);
                if (mm.getFlippedPairs() == 8)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileMM.txt");
                    mm.data.SetMinutes(minutes);
                    mm.data.SetSeconds(seconds);
                    this.Close();
                    mainForm.Show();
                    mm.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(mm.data);
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
