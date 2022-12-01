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
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void resetButtons()
        {
            button2.Enabled = button3.Enabled = button4.Enabled = true;
            button2.BackColor = button3.BackColor = button4.BackColor = Color.White;
        }

        private Button getEnabled()
        {
            if (!button2.Enabled)
                return button2;
            else if (!button3.Enabled)
                return button3;
            else if (!button4.Enabled)
                return button4;
            else
                return new();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Name == "button2" || button.Name == "button3" || button.Name == "button4")
            {
                resetButtons();
                button.BackColor = Color.LightSteelBlue;
                button.Enabled = false;
            }
            else
            {
                Button enabledButton = getEnabled();
                if(enabledButton.Text == "")
                {
                    MessageBox.Show("You haven't selected a difficulty yet!");
                }
                else
                {
                    Form1 form1 = new Form1(this, enabledButton);

                    form1.Show();

                    Hide();
                }
            }
        }

    }
}
