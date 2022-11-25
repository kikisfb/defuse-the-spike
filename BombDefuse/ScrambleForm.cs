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
    public partial class ScrambleForm : Form
    {
        private Scramble scram;
        public ScrambleForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public ScrambleForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
            scram = new Scramble();
        }
        private void ScrambleForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Scramble is working");
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            bool result = scram.checkGuess(ChecktTextBox.Text.ToUpper());
            if (result == true)
            {
                MessageBox.Show("You Won");
                this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Try again");

            }


        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            ChecktTextBox.Text += ((Button)sender).Text;
        }
    }
}
