using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BombDefuse
{
    public class MathGeek : Puzzle
    {
        private string[] equations;
        private string[] answers;
        private string currentEquation;
        private string currentAnswer;

        public MathGeek()
        {
            equations = File.ReadAllLines("mathGeekEquations.txt");
            answers = File.ReadAllLines("mathGeekAnswers.txt");
            chooseEquation();
        }
        private void chooseEquation()
        {
            Random random= new Random();
            int index = random.Next(equations.Length);
            currentEquation = equations[index];
            currentAnswer = answers[index];
        }
        public string getAnswer()
        {
            
            return currentAnswer;
        }
        public string getEquation()
        {
            return currentEquation;
        }
    }
}
