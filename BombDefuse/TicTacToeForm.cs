using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private const int MAX_STUCK = 3;
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
            tic.data.SetActivityStatus(true);

            buttons = new List<Button> { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
        }

        private void ChangeButton(Button button, string text, Color color, bool enabled)
        {
            button.Text = text;
            button.BackColor = color;
            button.Enabled = enabled;
        }
        private void LoadKeysIntoGUI(Key[,] board)
        {
            for (int i = 0, counter = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++, counter++)
                {
                    if (board[i, j] == Key.PLAYER)
                    {
                        ChangeButton(buttons[counter], "X", Color.LightBlue, false);
                    }
                    else if (board[i, j] == Key.AI)
                    {
                        ChangeButton(buttons[counter], "O", Color.LightCoral, false);
                    }
                }
            }
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            /* Set initial data of the sub-GUI */
            label1.Text = "Player versus. AI\nTicTacToe";
            timer1.Start();
            label2.Text = "00 minutes : 00 seconds elapsed";

            /* Read past state if existing */
            tic.ReadState(board);

            minutes = tic.data.GetMinutes();
            seconds = tic.data.GetSeconds();
            if(minutes > 0 || seconds > 0)
            {
                label2.Text = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";
            }

            LoadKeysIntoGUI(board);
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

        private int check(TicStats s)
        {
            int check = -1;
            Status status = s.GetStatus();
            if(status == Status.WINNER)
            {
                Key k = s.GetKey();
                if(k == Key.PLAYER)
                {
                    timer1.Stop();
                    MessageBox.Show("Congratulations! You have beaten the AI. Click OK to go back to the main menu.");
                    check = 1;
                }
                else
                {
                    MessageBox.Show("Oh no! The AI won!. Click OK to try again.");
                    check = 0;
                }
            }
            else if(status == Status.STUCK)
            {
                
                int stuck = tic.stats.GetAmountStuck() + 1;
                if(stuck == MAX_STUCK)
                {
                    timer1.Stop();
                    MessageBox.Show("The game got stuck for the third time. You win by default! Click OK to go back to the main menu.");
                    check = 1;
                    tic.stats.SetStatus(Status.WINNER);
                }
                else
                {
                    string stuckStr = stuck == 1 ? "first" : "second";
                    MessageBox.Show($"The game got stuck for the {stuckStr} time. You will win by default on the third time.");
                    tic.stats.SetAmountStuck(stuck);
                    check = 2;
                }
            }

            if(check == 1)
            {
                tic.data.SetCompletionStatus(true);
                File.Delete("ticState.txt");
                File.Delete("ticKeys.txt");
                closeForm();
            }
            else
            {
                if (check != -1)
                    reset();
                tic.SaveState(board);
            }

            return check;
        }

        private void reset()
        {
            /* resets the internal TicTacToe grid */
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = Key.EMPTY;
                }
            }

            /* resets the GUI grid */
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

            tic.data.SetMinutes(minutes);
            tic.data.SetSeconds(seconds);

            this.Close();

            mainForm.Form1_Load(tic.data);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            int index = GetIndexFromButton(thisButton) - 2; // translates button index into array index

            if(index == -1) // go back button clicked
            {
                tic.SaveState(board);
                closeForm();
            }
            else
            {
                if (tic.PlayerMove(board, index, Key.PLAYER))
                {
                    ChangeButton(thisButton, "X", Color.LightBlue, false);
                    if (check(tic.stats) > 0)
                        return;
                    
                    int currRandom;

                    do
                    {
                        currRandom = random.Next(0, MAX_MOVES);
                    } while (!tic.PlayerMove(board, currRandom, Key.AI));
                    ChangeButton(buttons[currRandom], "O", Color.LightCoral, false);

                    if (check(tic.stats) > 0)
                        return;
                }
                else
                    MessageBox.Show("ERROR! That position is already occupied. Try a different one.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (seconds < 60)
            {
                seconds++;
            }
            else
            {
                seconds = 0;
                minutes++;
            }

            string minutesSecondsStr = Form1.ConvertMinutesSecondsToStr(minutes, seconds) + "elapsed";

            label2.Text = minutesSecondsStr;
        }
    }
}
