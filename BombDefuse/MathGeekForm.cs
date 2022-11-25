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
    public partial class MathGeekForm : Form
    {
        private MathGeek mathg;
        public MathGeekForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public MathGeekForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
            mathg = new();
            
        }
        private void MathGeekForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Math Geek is working!");
            labelequation.Text = mathg.getEquation();
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text == mathg.getAnswer())
            {
                MessageBox.Show("You Won!"); 
                this.Close();
                mainForm.Show();
            }
            else
                MessageBox.Show("Try Again");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void equationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
