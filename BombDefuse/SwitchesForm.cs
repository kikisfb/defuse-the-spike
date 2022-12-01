using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombDefuse
{
    public partial class SwitchesForm : Form
    {
        bool[] states = new bool[10];
       
        private Random random;
        private Switches swi;
        private int minutes, seconds;

        public SwitchesForm()
        {
            InitializeComponent();
        }

        private Form1? mainForm;
        public SwitchesForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();

            random = new();
            swi = new();
            swi.data.SetId(5);
            swi.data.SetActivityStatus(true);
        }
        private void SwitchesForm_Load(object sender, EventArgs e)
        {

            minutes = 0;
            seconds = 0;

            timer1.Start();

            string filePath = "SaveFileSwitches.txt";            
            if (File.Exists(filePath))
            {
                states = swi.ReadState();

                minutes = swi.data.GetMinutes();
                seconds = swi.data.GetSeconds();
                label3.Text = ConvertMinutesSecondsToStr(minutes, seconds);

                if (states[0] == true)
                {
                    tglColor.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator.BackColor = Color.Red;
                }

                else
                {
                    tglColor.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator.BackColor = Color.Green;
                }

                if (states[1] == true)
                {
                    tglColor2.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator2.BackColor = Color.Red;
                }
                else
                {
                    tglColor2.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator2.BackColor = Color.Green;
                }

                if (states[2] == true)
                {
                    tglColor3.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator3.BackColor = Color.Red;
                }
                else
                {
                    tglColor3.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator3.BackColor = Color.Green;
                }

                if (states[3] == true)
                {
                    tglColor4.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator4.BackColor = Color.Red;
                }
                else
                {
                    tglColor4.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator4.BackColor = Color.Green;
                }

                if (states[4] == true)
                {
                    tglColor5.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator5.BackColor = Color.Red;
                }
                else
                {
                    tglColor5.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator5.BackColor = Color.Green;
                }

                //---------------------------------------

                if (states[5] == true)
                {
                    pictureBox1.BackColor = Color.Red;
                }
                else
                {
                    pictureBox1.BackColor = Color.Green;
                }

                if (states[6] == true)
                {
                    pictureBox2.BackColor = Color.Red;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                }

                if (states[7] == true)
                {
                    pictureBox3.BackColor = Color.Red;
                }
                else
                {
                    pictureBox3.BackColor = Color.Green;
                }

                if (states[8] == true)
                {
                    pictureBox4.BackColor = Color.Red;
                }
                else
                {
                    pictureBox4.BackColor = Color.Green;
                }

                if (states[9] == true)
                {
                    pictureBox5.BackColor = Color.Red;
                }
                else
                {
                    pictureBox5.BackColor = Color.Green;
                }
            }

            else
            {
                Random rnd = new Random();
                int type1 = rnd.Next(2);

                if (type1 == 0)
                {
                    tglColor.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator.BackColor = Color.Red;
                    states[0] = true;
                }
                else
                {
                    tglColor.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator.BackColor = Color.Green;
                    states[0] = false;
                }

                Random rnd2 = new Random();
                int type2 = rnd2.Next(2);

                if (type2 == 0)
                {
                    tglColor2.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator2.BackColor = Color.Red;
                    states[1] = true;
                }
                else
                {
                    tglColor2.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator2.BackColor = Color.Green;
                    states[1] = false;
                }

                Random rnd3 = new Random();
                int type3 = rnd3.Next(2);

                if (type3 == 0)
                {
                    tglColor3.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator3.BackColor = Color.Red;
                    states[2] = true;
                }
                else
                {
                    tglColor3.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator3.BackColor = Color.Green;
                    states[2] = false;
                }

                Random rnd4 = new Random();
                int type4 = rnd4.Next(2);

                if (type4 == 0)
                {
                    tglColor4.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator4.BackColor = Color.Red;
                    states[3] = true;
                }
                else
                {
                    tglColor4.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator4.BackColor = Color.Green;
                    states[3] = false;
                }

                Random rnd5 = new Random();
                int type5 = rnd5.Next(2);

                if (type5 == 0)
                {
                    tglColor5.BackgroundImage = Properties.Resources.btnRed;
                    statusIndicator5.BackColor = Color.Red;
                    states[4] = true;
                }
                else
                {
                    tglColor5.BackgroundImage = Properties.Resources.btnGreen;
                    statusIndicator5.BackColor = Color.Green;
                    states[4] = false;
                }

                //----------------------------
                //----------------------------

                Random rndBox1 = new Random();
                int typeBox1 = rndBox1.Next(2);

                if (typeBox1 == 0)
                {
                    pictureBox1.BackColor = Color.Red;
                    states[5] = true;
                }
                else
                {
                    pictureBox1.BackColor = Color.Green;
                    states[5] = false;
                }


                Random rndBox2 = new Random();
                int typeBox2 = rndBox2.Next(2);

                if (typeBox2 == 0)
                {
                    pictureBox2.BackColor = Color.Red;
                    states[6] = true;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                    states[6] = false;
                }

                Random rndBox3 = new Random();
                int typeBox3 = rndBox3.Next(2);

                if (typeBox3 == 0)
                {
                    pictureBox3.BackColor = Color.Red;
                    states[7] = true;
                }
                else
                {
                    pictureBox3.BackColor = Color.Green;
                    states[7] = false;
                }

                Random rndBox4 = new Random();
                int typeBox4 = rndBox2.Next(2);

                if (typeBox4 == 0)
                {
                    pictureBox4.BackColor = Color.Red;
                    states[8] = true;
                }
                else
                {
                    pictureBox4.BackColor = Color.Green;
                    states[8] = false;
                }

                Random rndBox5 = new Random();
                int typeBox5 = rndBox2.Next(2);

                if (typeBox5 == 0)
                {
                    pictureBox5.BackColor = Color.Red;
                    states[9] = true;
                }
                else
                {
                    pictureBox5.BackColor = Color.Green;
                    states[9] = false;
                }
            }

            tglColor.FlatStyle = FlatStyle.Flat;
            tglColor.FlatAppearance.BorderSize = 0;

            tglColor2.FlatStyle = FlatStyle.Flat;
            tglColor2.FlatAppearance.BorderSize = 0;

            tglColor3.FlatStyle = FlatStyle.Flat;
            tglColor3.FlatAppearance.BorderSize = 0;

            tglColor4.FlatStyle = FlatStyle.Flat;
            tglColor4.FlatAppearance.BorderSize = 0;

            tglColor5.FlatStyle = FlatStyle.Flat;
            tglColor5.FlatAppearance.BorderSize = 0;

        }

        private void tglColor_Click(object sender, EventArgs e)
        {
            if (states[0] != true)
            {
                tglColor.BackgroundImage = Properties.Resources.btnRed;
                statusIndicator.BackColor = Color.Red;
                states[0] = true;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
            else
            {
                tglColor.BackgroundImage = Properties.Resources.btnGreen;
                statusIndicator.BackColor = Color.Green;
                states[0] = false;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
        }

        private void tglColor2_Click(object sender, EventArgs e)
        {
            if (states[1] != true)
            {
                tglColor2.BackgroundImage = Properties.Resources.btnRed;
                statusIndicator2.BackColor = Color.Red;
                states[1] = true;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
            else
            {
                tglColor2.BackgroundImage = Properties.Resources.btnGreen;
                statusIndicator2.BackColor = Color.Green;
                states[1] = false;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
        }

        private void tglColor3_Click(object sender, EventArgs e)
        {
            if (states[2] != true)
            {
                tglColor3.BackgroundImage = Properties.Resources.btnRed;
                statusIndicator3.BackColor = Color.Red;
                states[2] = true;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
            else
            {
                tglColor3.BackgroundImage = Properties.Resources.btnGreen;
                statusIndicator3.BackColor = Color.Green;
                states[2] = false;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
        }

        private void tglColor4_Click(object sender, EventArgs e)
        {
            if (states[3] != true)
            {
                tglColor4.BackgroundImage = Properties.Resources.btnRed;
                statusIndicator4.BackColor = Color.Red;
                states[3] = true;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
            else
            {
                tglColor4.BackgroundImage = Properties.Resources.btnGreen;
                statusIndicator4.BackColor = Color.Green;
                states[3] = false;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
        }

        private void tglColor5_Click(object sender, EventArgs e)
        {
            if (states[4] != true)
            {
                tglColor5.BackgroundImage = Properties.Resources.btnRed;
                statusIndicator5.BackColor = Color.Red;
                states[4] = true;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
            }
            else
            {
                tglColor5.BackgroundImage = Properties.Resources.btnGreen;
                statusIndicator5.BackColor = Color.Green;
                states[4] = false;

                if (states[0] == states[5] && states[1] == states[6] && states[2] == states[7] && states[3] == states[8] && states[4] == states[9])
                {
                    timer1.Stop();
                    MessageBox.Show("Puzzle Complete!");
                    File.Delete("SaveFileSwitches.txt");
                    this.Close();
                    mainForm.Show();
                    swi.data.SetCompletionStatus(true);
                    mainForm.Form1_Load(swi.data);
                }
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

            swi.data.SetMinutes(minutes);
            swi.data.SetSeconds(seconds);

            label3.Text = minutesSecondsStr;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            swi.data.SetMinutes(minutes);
            swi.data.SetSeconds(seconds);
            swi.SaveState(states);
            this.Close();
            mainForm.Show();
            mainForm.Form1_Load(swi.data);
        }
    }
}
