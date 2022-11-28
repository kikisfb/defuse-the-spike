using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombDefuse
{
    //test branch push
    public class DefeatThePokemon : Puzzle
    {
        int correctAnswers;
        string[] usedPokemon = { "", "", "", "", "", ""};
        public DefeatThePokemon()
        {
            correctAnswers = 0;
        }

        public void LoadFromFile()
        {

        }

        public void WriteToFile()
        {

        }

        public bool checkAnswer(PictureBox pictureBox1, string imageName, string fileName)
        {

            if (imageName == fileName)
            {
                
                return true;
            }
            else
            {

                return false;
            }

            
        }

        public int getCorrectAnswers()
        {
            return this.correctAnswers;
        }

        public void setCorrectAnswers(int newAnswers)
        {
            correctAnswers = newAnswers;
        }

        public void addPokemon(string pokemon)
        {
            for(int i = 0; i < usedPokemon.Length; i++)
            {
                if (usedPokemon[i] == "")
                {
                    usedPokemon[i] = pokemon;
                    i = usedPokemon.Length;
                }
            }
        }

        public string[] getUsedPokemon()
        {
            return usedPokemon;
        }

        public int usedPokemonSize()
        {
            return usedPokemon.Length;
        }

        public string printTestPokemon(int i)
        {
            return usedPokemon[i];
        }

        public static DefeatThePokemon operator ++(DefeatThePokemon dtf)
        {
            dtf.correctAnswers++;
            return dtf;
        }

        public void checkUsedPokemon(string newImage, PictureBox pictureBox1)
        {
            Random rand = new Random();
            int randomPokemon = rand.Next(0, 6);
            bool check = true;
            int check1 = 0;
            while (check)
            {
                switch (randomPokemon)
                {                    
                    case 0:
                        newImage = "Charmander.png";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if(check1 == 6)
                                {
                                    pictureBox1.Image = System.Drawing.Image.FromFile(@"../Pictures/Charmander.png");
                                    pictureBox1.ImageLocation = (@"../Pictures/Charmander.png");
                                    check = false;
                                }
                            }
                        }
                        break;
                    case 1:
                        newImage = "Dratini.png";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = System.Drawing.Image.FromFile(@"../Pictures/Dratini.png");
                                    pictureBox1.ImageLocation = (@"../Pictures/Dratini.png");
                                    check = false;
                                }
                            }
                        }
                        break;
                    case 2:
                        newImage = "Riolu.png";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = System.Drawing.Image.FromFile(@"../Pictures/Riolu.png");
                                    pictureBox1.ImageLocation = (@"../Pictures/Riolu.png");
                                    check = false;
                                }
                            }
                        }
                        break;
                    case 3:
                        newImage = "Mudkip.jpg";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = System.Drawing.Image.FromFile(@"../Pictures/Mudkip.jpg");
                                    pictureBox1.ImageLocation = (@"../Pictures/Mudkip.jpg");
                                    check = false;
                                    
                                }
                            }
                        }
                        break;
                    case 4:
                        newImage = "Geodude.jpg";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = System.Drawing.Image.FromFile(@"../Pictures/Geodude.jpg");
                                    pictureBox1.ImageLocation = (@"../Pictures/Geodude.jpg");
                                    check = false;
                                    
                                }
                            }
                        }
                        break;
                    case 5:
                        newImage = "Umbreon.jpg";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = System.Drawing.Image.FromFile(@"../Pictures/Umbreon.jpg");
                                    pictureBox1.ImageLocation = (@"../Pictures/Umbreon.jpg");
                                    check = false;
                                   
                                }
                            }
                        }
                        break;                       
                }
                check1 = 0;
                randomPokemon = rand.Next(0, 6);
            }
        }
    }
}
