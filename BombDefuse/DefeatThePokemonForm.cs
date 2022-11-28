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
        public DefeatThePokemonForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public DefeatThePokemonForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();

            dtf = new();
        }
        private void DefeatThePokemonForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Defeat the Pokémon is working!");            
            string image = dtf.LoadFromFile(progressBar1);
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
                MessageBox.Show("Super Effective");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Nice");
                    File.Delete("SaveFile.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);
                
            }
            else
            {
                MessageBox.Show("Incorrect");
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
                MessageBox.Show("Super Effective");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Nice");
                    File.Delete("SaveFile.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);
                
            }
            else
            {
                MessageBox.Show("Incorrect");
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
                MessageBox.Show("Super Effective");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Nice");
                    File.Delete("SaveFile.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);
                
            }
            else
            {
                MessageBox.Show("Incorrect");
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
                MessageBox.Show("Super Effective");
                dtf++;
                progressBar1.Value += 25;
                progressBar1.Update();
                label2.Text = "Correct Answers: " + $"{dtf.getCorrectAnswers()}";
                if (dtf.getCorrectAnswers() == 4)
                {
                    MessageBox.Show("Nice");
                    File.Delete("SaveFile.txt");
                    this.Close();
                    mainForm.Show();
                }
                dtf.addPokemon(currentPokemon);               
            }
            else
            {
                MessageBox.Show("Incorrect");
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
    }
}
