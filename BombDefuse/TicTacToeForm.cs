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
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public TicTacToeForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tic is working!");
        }
    }
}
