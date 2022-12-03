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

namespace BombDefuse
{
    public partial class BattleshipForm : Form
    {

        bool[] battleship = new bool[16];

        private Random random;
        private Battleship bat;
        private int minutes, seconds;

        public BattleshipForm()
        {
            InitializeComponent();
        }

        private Form1? mainForm;
        public BattleshipForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();

            random = new();
            bat = new();
            bat.data.SetId(6);
            bat.data.SetActivityStatus(true);
        }
        private void BattleshipForm_Load(object sender, EventArgs e)
        {
            minutes = 0;
            seconds = 0;

            timer1.Start();

            string filePath = "SaveFileBattleship.txt";
            if (File.Exists(filePath))
            {
                battleship = bat.ReadState();

                minutes = bat.data.GetMinutes();
                seconds = bat.data.GetSeconds();
                label1.Text = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";

                label4.Text = bat.getTurns().ToString();

                RemainingGuessesIndicator(bat.getTurns());

                if (battleship[0] == true)
                {
                    button1.BackColor = Color.Silver;
                    button1.BackgroundImage = Resources.Battleship___MIss3;
                    button1.Enabled = false;
                }
                else
                    button1.BackColor = Color.Gray;

                if (battleship[1] == true)
                {
                    button2.BackColor = Color.Silver;
                    button2.BackgroundImage = Resources.Battleship___MIss3;
                    button2.Enabled = false;
                }
                else
                    button2.BackColor = Color.Gray;

                if (battleship[2] == true)
                {
                    button3.BackColor = Color.Silver;
                    button3.BackgroundImage = Resources.Battleship___MIss3;
                    button3.Enabled = false;
                }
                else
                    button3.BackColor = Color.Gray;

                if (battleship[3] == true)
                {
                    button4.BackColor = Color.Silver;
                    button4.BackgroundImage = Resources.Battleship___MIss3;
                    button4.Enabled = false;
                }
                else
                    button4.BackColor = Color.Gray;

                if (battleship[4] == true)
                {
                    button5.BackColor = Color.Silver;
                    button5.BackgroundImage = Resources.Battleship___MIss3;
                    button5.Enabled = false;
                }
                else
                    button5.BackColor = Color.Gray;

                if (battleship[5] == true)
                {
                    button6.BackColor = Color.Silver;
                    button6.BackgroundImage = Resources.Battleship___MIss3;
                    button6.Enabled = false;
                }
                else
                    button6.BackColor = Color.Gray;

                if (battleship[6] == true)
                {
                    button7.BackColor = Color.Silver;
                    button7.BackgroundImage = Resources.Battleship___MIss3;
                    button7.Enabled = false;
                }
                else
                    button7.BackColor = Color.Gray;

                if (battleship[7] == true)
                {
                    button8.BackColor = Color.Silver;
                    button8.BackgroundImage = Resources.Battleship___MIss3;
                    button8.Enabled = false;
                }
                else
                    button8.BackColor = Color.Gray;

                if (battleship[8] == true)
                {
                    button9.BackColor = Color.Silver;
                    button9.BackgroundImage = Resources.Battleship___MIss3;
                    button9.Enabled = false;
                }
                else
                    button9.BackColor = Color.Gray;

                if (battleship[9] == true)
                {
                    button10.BackColor = Color.Silver;
                    button10.BackgroundImage = Resources.Battleship___MIss3;
                    button10.Enabled = false;
                }
                else
                    button10.BackColor = Color.Gray;

                if (battleship[10] == true)
                {
                    button11.BackColor = Color.Silver;
                    button11.BackgroundImage = Resources.Battleship___MIss3;
                    button11.Enabled = false;
                }
                else
                    button11.BackColor = Color.Gray;

                if (battleship[11] == true)
                {
                    button12.BackColor = Color.Silver;
                    button12.BackgroundImage = Resources.Battleship___MIss3;
                    button12.Enabled = false;
                }
                else
                    button12.BackColor = Color.Gray;

                if (battleship[12] == true)
                {
                    button13.BackColor = Color.Silver;
                    button13.BackgroundImage = Resources.Battleship___MIss3;
                    button13.Enabled = false;
                }
                else
                    button13.BackColor = Color.Gray;

                if (battleship[13] == true)
                {
                    button14.BackColor = Color.Silver;
                    button14.BackgroundImage = Resources.Battleship___MIss3;
                    button14.Enabled = false;
                }
                else
                    button14.BackColor = Color.Gray;

                if (battleship[14] == true)
                {
                    button15.BackColor = Color.Silver;
                    button15.BackgroundImage = Resources.Battleship___MIss3;
                    button15.Enabled = false;
                }
                else
                    button15.BackColor = Color.Gray;

                if (battleship[15] == true)
                {
                    button16.BackColor = Color.Silver;
                    button16.BackgroundImage = Resources.Battleship___MIss3;
                    button16.Enabled = false;
                }
                else
                    button16.BackColor = Color.Gray;
            }

            else
            {
                label4.Text = bat.getTurns().ToString();

                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                button13.BackColor = Color.Gray;
                button14.BackColor = Color.Gray;
                button15.BackColor = Color.Gray;
                button16.BackColor = Color.Gray;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            battleship[0] = true;
            button1.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button1.BackColor = Color.Silver;
            button1.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            battleship[1] = true;
            button2.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button2.BackColor = Color.Silver;
            button2.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            battleship[2] = true;
            button3.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button3.BackColor = Color.Silver;
            button3.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            battleship[3] = true;
            button4.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button4.BackColor = Color.Silver;
            button4.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            battleship[4] = true;
            button5.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button5.BackColor = Color.Silver;
            button5.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            battleship[5] = true;
            button6.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button6.BackColor = Color.Silver;
            button6.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            battleship[6] = true;
            button7.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button7.BackColor = Color.Silver;
            button7.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            battleship[7] = true;
            button8.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button8.BackColor = Color.Silver;
            button8.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            battleship[8] = true;
            button9.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button9.BackColor = Color.Silver;
            button9.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            battleship[9] = true;
            button10.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button10.BackColor = Color.Silver;
            button10.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            battleship[10] = true;
            button11.BackgroundImage = Resources.Battleship___Hit3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button11.BackColor = Color.Silver;
            button11.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            timer1.Stop();
            MessageBox.Show("You sunk my battleship!");
            File.Delete("SaveFileBattleship.txt");
            this.Close();
            mainForm.Show();
            bat.data.SetCompletionStatus(true);
            //this.Show();
            mainForm.Form1_Load(bat.data);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            battleship[11] = true;
            button12.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button12.BackColor = Color.Silver;
            button12.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            battleship[12] = true;
            button13.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button13.BackColor = Color.Silver;
            button13.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            battleship[13] = true;
            button14.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button14.BackColor = Color.Silver;
            button14.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            battleship[14] = true;
            button15.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button15.BackColor = Color.Silver;
            button15.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            battleship[15] = true;
            button16.BackgroundImage = Resources.Battleship___MIss3;
            bat--;
            label4.Text = bat.getTurns().ToString();

            button16.BackColor = Color.Silver;
            button16.Enabled = false;

            RemainingGuessesIndicator(bat.getTurns());

            if (bat.getTurns() == 0)
            {
                MessageBox.Show("Try Again!");
                File.Delete("SaveFileBattleship.txt");
                this.Close();
                //this.Show();
                mainForm.Show();
                mainForm.Form1_Load(bat.data);
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

            bat.data.SetMinutes(minutes);
            bat.data.SetSeconds(seconds);

            label1.Text = minutesSecondsStr;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            bat.data.SetMinutes(minutes);
            bat.data.SetSeconds(seconds);
            bat.SaveState(battleship);
            this.Close();
            mainForm.Show();
            mainForm.Form1_Load(bat.data);
        }

        public void RemainingGuessesIndicator(int guesses)
        {
            if (guesses == 9)
            {
                pictureBox2.BackColor = Color.Red;
            }

            if (guesses == 8)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
            }

            if (guesses == 7)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
            }

            if (guesses == 6)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
                pictureBox5.BackColor = Color.Red;
            }

            if (guesses == 5)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
                pictureBox5.BackColor = Color.Red;
                pictureBox6.BackColor = Color.Red;
            }

            if (guesses == 4)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
                pictureBox5.BackColor = Color.Red;
                pictureBox6.BackColor = Color.Red;
                pictureBox7.BackColor = Color.Red;
            }

            if (guesses == 3)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
                pictureBox5.BackColor = Color.Red;
                pictureBox6.BackColor = Color.Red;
                pictureBox7.BackColor = Color.Red;
                pictureBox8.BackColor = Color.Red;
            }

            if (guesses == 2)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
                pictureBox5.BackColor = Color.Red;
                pictureBox6.BackColor = Color.Red;
                pictureBox7.BackColor = Color.Red;
                pictureBox8.BackColor = Color.Red;
                pictureBox9.BackColor = Color.Red;
            }

            if (guesses == 1)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
                pictureBox5.BackColor = Color.Red;
                pictureBox6.BackColor = Color.Red;
                pictureBox7.BackColor = Color.Red;
                pictureBox8.BackColor = Color.Red;
                pictureBox9.BackColor = Color.Red;
                pictureBox10.BackColor = Color.Red;
            }

            if (guesses == 0)
            {
                pictureBox2.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
                pictureBox4.BackColor = Color.Red;
                pictureBox5.BackColor = Color.Red;
                pictureBox6.BackColor = Color.Red;
                pictureBox7.BackColor = Color.Red;
                pictureBox8.BackColor = Color.Red;
                pictureBox9.BackColor = Color.Red;
                pictureBox10.BackColor = Color.Red;
                pictureBox11.BackColor = Color.Red;
            }

        }
    }
}
