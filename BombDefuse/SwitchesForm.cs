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
    public partial class SwitchesForm : Form
    {
        public SwitchesForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public SwitchesForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }
        private void SwitchesForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Switches is working!");
        }
    }
}
