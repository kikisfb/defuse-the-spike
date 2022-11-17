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
    public partial class GuessTheFlagForm : Form
    {
        public GuessTheFlagForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public GuessTheFlagForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }
        private void GuessTheFlagForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Guess is working!");
        }
    }
}
