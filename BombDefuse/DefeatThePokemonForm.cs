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
        public DefeatThePokemonForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public DefeatThePokemonForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }
        private void DefeatThePokemonForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Defeat the Pokémon is working!");
        }
    }
}
