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
    public partial class BattleshipForm : Form
    {
        public BattleshipForm()
        {
            InitializeComponent();
        }

        private Form? mainForm;
        public BattleshipForm(Form callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();
        }
        private void BattleshipForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Battleship is working!");
        }
    }
}
