using BombDefuse.Properties;
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
        string[] usedPokemon = { " ", " ", " ", " ", " ", " "};
        public DefeatThePokemon()
        {
            correctAnswers = 0;
        }

        public string LoadFromFile(ProgressBar progressBar1)
        {
            string fileName = "SaveFileDTP.txt";
            string[] lines = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "};

            if (File.Exists(fileName))
            {
                lines = File.ReadAllLines(fileName); 
                for(int i = 0; i < 6; i ++)
                {
                    usedPokemon[i] = lines[i];
                }
                correctAnswers = int.Parse(lines[7]);
                progressBar1.Value = int.Parse(lines[8]);
                data.SetMinutes(int.Parse(lines[9]));
                data.SetSeconds(int.Parse(lines[10]));
                return lines[6];
            }
            return "";
        }

        public void WriteToFile(string currentPokemon, int progress)
        {
            string fileName = "SaveFileDTP.txt";            
            string correctAnswer = Convert.ToString(correctAnswers);
            File.WriteAllLines(fileName, usedPokemon);
            File.AppendAllText(fileName, currentPokemon);
            File.AppendAllText(fileName, $"\n{correctAnswer}");
            File.AppendAllText(fileName, $"\n{progress}");
            File.AppendAllText(fileName, $"\n{data.GetMinutes()}\n{data.GetSeconds()}");
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

        public string checkUsedPokemon(string newImage, PictureBox pictureBox1, int randomPokemon)
        {
            Random rand = new Random();
            bool check = true;
            int check1 = 0;
            while (check)
            {
                switch (randomPokemon)
                {                    
                    case 0:
                        newImage = "Charmander";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if(check1 == 6)
                                {
                                    pictureBox1.Image = Resources.Charmander;  
                                    check = false;
                                }
                            }
                        }
                        break;
                    case 1:
                        newImage = "Dratini";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = Resources.Dratini;
                                    check = false;
                                }
                            }
                        }
                        break;
                    case 2:
                        newImage = "Riolu";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = Resources.Riolu;
                                    check = false;
                                }
                            }
                        }
                        break;
                    case 3:
                        newImage = "Mudkip";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = Resources.Mudkip;
                                    check = false;
                                    
                                }
                            }
                        }
                        break;
                    case 4:
                        newImage = "Geodude";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = Resources.Geodude;
                                    check = false;
                                    
                                }
                            }
                        }
                        break;
                    case 5:
                        newImage = "Umbreon";
                        for (int i = 0; i < usedPokemon.Length; i++)
                        {
                            if (newImage != usedPokemon[i])
                            {
                                check1++;
                                if (check1 == 6)
                                {
                                    pictureBox1.Image = Resources.Umbreon;
                                    check = false;
                                   
                                }
                            }
                        }
                        break;                       
                }
                check1 = 0;
                randomPokemon = rand.Next(0, 6);
            }
            return newImage;
        }
    }
}
