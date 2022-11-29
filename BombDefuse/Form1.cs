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

        private void changeState(PuzzleData data, Button button)
        {
            bool completionStatus = data.GetCompletionStatus();
            bool activityStatus = data.GetActivityStatus();
            if(activityStatus)
            {
                if(completionStatus)
                {
                    button.BackColor = Color.LightGreen;
                    button.Enabled = false;
                }
                else
                {
                    button.BackColor = Color.LightYellow;
                }
            }
        }
        public void Form1_Load(PuzzleData data)
        {
            int id = data.GetId();
            
            if(id == 1)
            {
                changeState(data, TicTacToe);
            }
            else if(id == 2)
            {
                changeState(data, GuessTheFlag);
            }
            else if(id == 3)
            {
                changeState(data, MathGeek);
            }
            else if(id == 4)
            {
                changeState(data, Scramble);
            }
            else if(id == 5)
            {
                changeState(data, Switches);
            }
            else if(id == 6)
            {
                changeState(data, Battleship);
            }
            else if(id == 7)
            {
                changeState(data, DefeatThePokemon);
            }
            else if(id == 8)
            {
                changeState(data, MemoryMatch);
            }
            else
            {
                MessageBox.Show("PuzzleData ADT was not sent back correctly.");
                Application.Exit();
            }
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