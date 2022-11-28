﻿using Microsoft.VisualBasic.ApplicationServices;
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
        string[] usedPokemon = { " ", " ", " ", " ", " ", " "};
        public DefeatThePokemon()
        {
            correctAnswers = 0;
        }

        public string LoadFromFile()
        {
            string fileName = "SaveFile.txt";
            string[] lines = { " ", " ", " ", " ", " ", " ", " ", " "};

            if (File.Exists(fileName))
            {
                lines = File.ReadAllLines(fileName); 
                for(int i = 0; i < 6; i ++)
                {
                    usedPokemon[i] = lines[i];
                }
                correctAnswers = int.Parse(lines[7]);
                return lines[6];
            }
            return "";
        }

        public void WriteToFile(PictureBox pictureBox1)
        {
            string fileName = "SaveFile.txt";
            string imagePath = pictureBox1.ImageLocation;
            string imageName = imagePath.Substring(imagePath.LastIndexOf('/') + 1);
            string correctAnswer = Convert.ToString(correctAnswers);
            File.WriteAllLines(fileName, usedPokemon);
            File.AppendAllText(fileName, imageName);
            File.AppendAllText(fileName, $"\n{correctAnswer}");
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
                if (usedPokemon[i] == " ")
                {
                    usedPokemon[i] = pokemon;
                    i = usedPokemon.Length;
                }
            }
        }

        public static DefeatThePokemon operator ++(DefeatThePokemon dtf)
        {
            dtf.correctAnswers++;
            return dtf;
        }

        public void checkUsedPokemon(string newImage, PictureBox pictureBox1, int randomPokemon)
        {
            Random rand = new Random();
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
