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
    public partial class DefeatThePokemonForm : Form
    {
        private DefeatThePokemon dtf;
        string currentPokemon;
        private int minutes, seconds;
        public DefeatThePokemonForm()
        {
            InitializeComponent();
        }

        private Form1? mainForm;
        public DefeatThePokemonForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();

            dtf = new();
        }
        private void DefeatThePokemonForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Defeat the Pokémon is working!");
            minutes = 0;
            seconds = 0;
            timer1.Start();
            
            string image = dtf.LoadFromFile(progressBar1);
            minutes = dtf.data.GetMinutes();
            seconds = dtf.data.GetSeconds();
            label3.Text = ConvertMinutesSecondsToStr(minutes, seconds);
            label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
            if (image == "Charmander")
            {
                pictureBox1.Image = Resources.Charmander;
            }
            else if (image == "Dratini")
            {
                pictureBox1.Image = Resources.Dratini;
            }
            else if (image == "Riolu")
            {
                pictureBox1.Image = Resources.Riolu;
            }
            else if (image == "Mudkip")
            {
                pictureBox1.Image = Resources.Mudkip;
            }
            else if (image == "Geodude")
            {
                pictureBox1.Image = Resources.Geodude;
            }
            else if (image == "Umbreon")
            {
                pictureBox1.Image = Resources.Umbreon;
            }
            else
            {
                pictureBox1.Image = Resources.Charmander;
            }
            if(image != "")
            {
                currentPokemon = image;
            }
            else
            {
                currentPokemon = "Charmander";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dtf.data.SetMinutes(minutes);
            dtf.data.SetSeconds(seconds);
            dtf.WriteToFile(currentPokemon, progressBar1.Value);
            //mainForm.Form1_Load(dtf.data);
            this.Close();
            mainForm.Show();
        }

        private void WaterGun_Click(object sender, EventArgs e)
        {            
            string correctTyping = "Charmander";
            string correctTyping2 = "Geodude";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, currentPokemon, correctTyping);
            bool correct2 = dtf.checkAnswer(pictureBox1, currentPokemon, correctTyping2);
            if (correct || correct2)
            {
                MessageBox.Show("It's Super Effective!");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileDTP.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);
                
            }
            else
            {
                MessageBox.Show("It's Not Very Effective");
            }
           currentPokemon = dtf.checkUsedPokemon(currentPokemon, pictureBox1, randomPokemon);
        }

        private void DragonBreath_Click(object sender, EventArgs e)
        {
            string correctTyping = "Dratini";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, currentPokemon, correctTyping);
            if (correct)
            {
                MessageBox.Show("It's Super Effective!");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileDTP.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);
                
            }
            else
            {
                MessageBox.Show("It's Not Very Effective");
            }
            currentPokemon = dtf.checkUsedPokemon(currentPokemon, pictureBox1, randomPokemon);
        }

        private void Psychic_Click(object sender, EventArgs e)
        {
            string correctTyping = "Riolu";
            string correctTyping2 = "Umbreon";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, currentPokemon, correctTyping);
            bool correct2 = dtf.checkAnswer(pictureBox1, currentPokemon, correctTyping2);
            if (correct || correct2)
            {
                MessageBox.Show("It's Super Effective!");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileDTP.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);
                
            }
            else
            {
                MessageBox.Show("It's Not Very Effective");
            }
            currentPokemon = dtf.checkUsedPokemon(currentPokemon, pictureBox1, randomPokemon);
        }

        private void GrassKnot_Click(object sender, EventArgs e)
        {
            string correctTyping = "Mudkip";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, currentPokemon, correctTyping);
            if (correct)
            {
                MessageBox.Show("It's Super Effective!");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Congrats, You Completed the Puzzle!");
                    File.Delete("SaveFileDTP.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);               
            }
            else
            {
                MessageBox.Show("It's Not Very Effective");
            }
            currentPokemon = dtf.checkUsedPokemon(currentPokemon, pictureBox1, randomPokemon);
        }

        private void label1_Click(object sender, EventArgs e)
        {            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Play\nA Pokemon will be displayed in the center of the screen. \nThere are 4 moves to choose from. \nYou must click the move you think is the most effective against the pokemon shown on screen based on the pokemon types.");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

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

            label3.Text = minutesSecondsStr;
        }
    }
}

