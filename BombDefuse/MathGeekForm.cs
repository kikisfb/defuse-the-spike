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
        public MathGeekForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public MathGeekForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }
        private void MathGeekForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Math Geek is working!");
        }
    }
}
