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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void WaterGun_Click(object sender, EventArgs e)
        {
            
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Charmander.png";
            string correctTyping2 = "Geodude.jpg";
            //dtf.checkUsedPokemon(imageName, pictureBox1);


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
                dtf.checkUsedPokemon(imageName, pictureBox1);
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
           
        }

        private void DragonBreath_Click(object sender, EventArgs e)
        {
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Dratini.png";
           // dtf.checkUsedPokemon(imageName, pictureBox1);

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
                dtf.checkUsedPokemon(imageName, pictureBox1);
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void Psychic_Click(object sender, EventArgs e)
        {
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Riolu.png";
            string correctTyping2 = "Umbreon.jpg";
           // dtf.checkUsedPokemon(imageName, pictureBox1);


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
                dtf.checkUsedPokemon(imageName, pictureBox1);
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void GrassKnot_Click(object sender, EventArgs e)
        {
            string imgPath = pictureBox1.ImageLocation;
            string imageName = imgPath.Substring(imgPath.LastIndexOf('/') + 1);
            string correctTyping = "Mudkip.jpg";
           // dtf.checkUsedPokemon(imageName, pictureBox1);

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
                dtf.checkUsedPokemon(imageName, pictureBox1);
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string used;
            for(int i = 0; i < dtf.usedPokemonSize(); i++)
            {
                used = dtf.printTestPokemon(i);
                MessageBox.Show(used);
            }
            
        }
    }
}
