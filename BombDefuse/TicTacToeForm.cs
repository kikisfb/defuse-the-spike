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
        private TicTacToe tic;
        private int minutes, seconds;
        private Random random;
        private const int MAX_MOVES = 9;
        private List<Button> buttons;

        private Key[,] board = { { Key.EMPTY, Key.EMPTY, Key.EMPTY },
                 { Key.EMPTY, Key.EMPTY, Key.EMPTY },
                 { Key.EMPTY, Key.EMPTY, Key.EMPTY }
               };

        private Form1? mainForm;
        public TicTacToeForm(Form1 callingForm)
        {
            this.mainForm = callingForm;

            InitializeComponent();

            random = new();
            tic = new();
            tic.data.SetId(1);

            var list = new List<Button> { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            buttons = list;
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Player versus. AI\nTicTacToe";
            minutes = 0;
            seconds = 0;
            timer1.Start();
            label2.Text = "00 minutes : 00 seconds elapsed";
        }

        private int GetIndexFromButton(Button thisButton)
        {
            int index = -1;

            if (thisButton.Name == "button1")
            {
                index = 1;
            }
            else if(thisButton.Name == "button2")
            {
                index = 2;
            }
            else if(thisButton.Name == "button3")
            {
                index = 3;
            }
            else if(thisButton.Name == "button4")
            {
                index = 4;
            }
            else if(thisButton.Name == "button5")
            {
                index = 5;
            }
            else if(thisButton.Name == "button6")
            {
                index = 6;
            }
            else if(thisButton.Name == "button7")
            {
                index = 7;
            }
            else if(thisButton.Name == "button8")
            {
                index = 8;
            }
            else if(thisButton.Name == "button9")
            {
                index = 9;
            }
            else if(thisButton.Name == "button10")
            {
                index = 10;
            }

            return index;
        }

        private bool check(TicStats s)
        {
            Status status = s.GetStatus();
            if(status == Status.WINNER)
            {
                Key k = s.GetKey();
                if(k == Key.PLAYER)
                {
                    MessageBox.Show("Congratulations! You have beaten the AI. Click Ok to go back to the main menu.");
                    closeForm();
                    return true;
                }
                else
                {
                    MessageBox.Show("Oh no! The AI has beaten you. Click OK to try again.");
                    reset();
                }
            }
            else if(status == Status.STUCK)
            {
                MessageBox.Show("Oops! The game got stuck.");
                reset();
            }

            return false;
        }

        private void reset()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = Key.EMPTY;
                }
            }

            foreach (Button button in buttons)
            {
                button.ResetText();
                button.Enabled = true;
                button.BackColor = DefaultBackColor;
            }
        }

        private void closeForm()
        {
            mainForm.Show();

            // Call the main form load to pass PuzzleData

            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            int index = GetIndexFromButton(thisButton) - 2;

            if(index == -1)
            {
                closeForm();
            }
            else
            {
                if (tic.PlayerMove(board, index, Key.PLAYER))
                {
                    thisButton.Text = "X";
                    thisButton.BackColor = Color.LightBlue;
                    thisButton.Enabled = false;
                    if (check(tic.stats))
                        return;
                    
                    int currRandom;

                    do
                    {
                        currRandom = random.Next(0, MAX_MOVES);
                    } while (!tic.PlayerMove(board, currRandom, Key.AI));
                    buttons[currRandom].Text = "O";
                    buttons[currRandom].BackColor = Color.LightCoral;
                    buttons[currRandom].Enabled = false;

                    if (check(tic.stats))
                        return;
                }
                else
                    MessageBox.Show("ERROR! That position is already occupied. Try a different one.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string displayMinutes;
            string displaySeconds;

            if(seconds < 60)
            {
                seconds++;
            }
            else
            {
                seconds = 0;
                minutes++;
            }

            if (seconds < 10)
            {
                displaySeconds = $"{0}{seconds}";
            }
            else
                displaySeconds = $"{seconds}";

            if(minutes < 10)
            {
                displayMinutes = $"{0}{minutes}";
            }
            else
            {
                displayMinutes = $"{minutes}";
            }

            label2.Text = $"{displayMinutes} minutes : {displaySeconds} seconds elapsed";
        }
    }
}
