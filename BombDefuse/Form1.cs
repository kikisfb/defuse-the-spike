namespace BombDefuse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TicTacToe_Click(object sender, EventArgs e)
        {
            TicTacToeForm tic = new TicTacToeForm(this);

            tic.Show();

            this.Hide();
        }


        private void GuessTheFlag_Click(object sender, EventArgs e)
        {
            GuessTheFlagForm gtf = new GuessTheFlagForm(this);

            gtf.Show();

            this.Hide();
        }

        private void MathGeek_Click(object sender, EventArgs e)
        {
            MathGeekForm mg = new MathGeekForm(this);

            mg.Show();

            this.Hide();
        }

        private void Scramble_Click(object sender, EventArgs e)
        {
            ScrambleForm scrm = new ScrambleForm(this);

            scrm.Show();

            this.Hide();
        }

        private void Switches_Click(object sender, EventArgs e)
        {
            SwitchesForm sw = new SwitchesForm(this);

            sw.Show();

            this.Hide();
        }

        private void Battleship_Click(object sender, EventArgs e)
        {
            BattleshipForm bts = new BattleshipForm(this);

            bts.Show();

            this.Hide();
        }

        private void DefeatThePokemon_Click(object sender, EventArgs e)
        {
            DefeatThePokemonForm dtp = new DefeatThePokemonForm(this);

            dtp.Show();

            this.Hide();
        }

        private void MemoryMatch_Click(object sender, EventArgs e)
        {
            MemoryMatchForm mm = new MemoryMatchForm(this);

            mm.Show();

            this.Hide();
        }
    }
}