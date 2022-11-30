namespace BombDefuse
{
    public partial class Form1 : Form
    {
        private int minutes, seconds;
        private int avgMinutes, avgSeconds;
        public Form1()
        {
            InitializeComponent();

            minutes = 7;
            seconds = 0;

            label3.Text = ConvertMinutesSecondsToStr(minutes, seconds) + "left";

            timer1.Start();
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
                    if (progressBar1.Value == 84)
                        progressBar1.Value += 16;
                    else
                        progressBar1.Value += 12;
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

        public static string ConvertMinutesSecondsToStr(int minutes, int seconds)
        {
            string displayMinutes;
            string displaySeconds;

            if (seconds < 10)
                displaySeconds = $"0{seconds}";
            else
                displaySeconds = seconds.ToString();

            if (minutes < 10)
                displayMinutes = $"0{minutes}";
            else
                displayMinutes = minutes.ToString();

            return $"{displayMinutes} minutes : {displaySeconds} seconds ";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(minutes == 0 && seconds == 0)
            {
                timer1.Stop();
                MessageBox.Show("The bomb has exploded! You lost.");
                Application.Exit();    
            }
            else if(minutes == 1 && seconds == 0)
            {
                minutes = 0; 
                seconds = 59;
                label3.ForeColor = Color.Red;
                MessageBox.Show("You have 1 minute left to complete the remaining puzzle(s)!");
            }
            else
            {
                if (seconds > 0)
                {
                    seconds--;
                }
                else
                {
                    seconds = 59;
                    minutes--;
                }
            }
            
            label3.Text = ConvertMinutesSecondsToStr(minutes, seconds) + "left";
        }
    }
}