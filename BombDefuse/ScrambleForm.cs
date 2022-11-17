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
        public ScrambleForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public ScrambleForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }
        private void ScrambleForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Scramble is working");
        }
    }
}
