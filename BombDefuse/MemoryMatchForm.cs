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
    public partial class MemoryMatchForm : Form
    {
        public MemoryMatchForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public MemoryMatchForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }
        private void MemoryMatchForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Memory Match is working!");
        }
    }
}
