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
            pictureBox1.Image = System.Drawing.Image.FromFile(@"../Pictures/Charmander.png");
            pictureBox1.ImageLocation = (@"../Pictures/Charmander.png");
            //string image = dtf.LoadFromFile();
            //pictureBox1.Image = System.Drawing.Image.FromFile($"../Pictures/{image}");
            //pictureBox1.ImageLocation = ($"../Pictures/{image}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //dtf.WriteToFile(pictureBox1);
            //mainForm.Form1_Load(dtf.data);
            this.Close();
            mainForm.Show();
        }

        private void WaterGun_Click(object sender, EventArgs e)
        {            
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Charmander.png";
            string correctTyping2 = "Geodude.jpg";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, imageName, correctTyping);
            bool correct2 = dtf.checkAnswer(pictureBox1, imageName, correctTyping2);
            if (correct || correct2)
            {
                MessageBox.Show("Super Effective");
                dtf++;
                if(dtf.getCorrectAnswers() == 3)
                {
                    MessageBox.Show("Nice");                   
                }
                dtf.addPokemon(imageName);
                
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
           dtf.checkUsedPokemon(imageName, pictureBox1, randomPokemon);
        }

        private void DragonBreath_Click(object sender, EventArgs e)
        {
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Dratini.png";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, imageName, correctTyping);
            if (correct)
            {
                MessageBox.Show("Super Effective");
                dtf++;
                if (dtf.getCorrectAnswers() == 3)
                {
                    MessageBox.Show("Nice");
                }
                dtf.addPokemon(imageName);
                
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
            dtf.checkUsedPokemon(imageName, pictureBox1, randomPokemon);
        }

        private void Psychic_Click(object sender, EventArgs e)
        {
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Riolu.png";
            string correctTyping2 = "Umbreon.jpg";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, imageName, correctTyping);
            bool correct2 = dtf.checkAnswer(pictureBox1, imageName, correctTyping2);
            if (correct || correct2)
            {
                MessageBox.Show("Super Effective");
                dtf++;
                if (dtf.getCorrectAnswers() == 3)
                {
                    MessageBox.Show("Nice");
                }
                dtf.addPokemon(imageName);
                
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
            dtf.checkUsedPokemon(imageName, pictureBox1, randomPokemon);
        }

        private void GrassKnot_Click(object sender, EventArgs e)
        {
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Mudkip.jpg";
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);

            bool correct = dtf.checkAnswer(pictureBox1, imageName, correctTyping);
            if (correct)
            {
                MessageBox.Show("Super Effective");
                dtf++;
                if (dtf.getCorrectAnswers() == 3)
                {
                    MessageBox.Show("Nice");
                }
                dtf.addPokemon(imageName);               
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
            dtf.checkUsedPokemon(imageName, pictureBox1, randomPokemon);
        }

        private void label1_Click(object sender, EventArgs e)
        {            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Play\nA Pokemon will be displayed in the center of the screen. \nThere are 4 moves to choose from. \nYou must click the move you think is the most effective against the pokemon shown on screen based on the pokemon types.");
        }
    }
}
