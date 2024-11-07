using System;
using System.Windows.Forms;

namespace Signatyrka
{
    public partial class Form_Gra : Form
    {
        int rounds = 3;
        int timerPerRound = 6;
        bool gameover = false;
        string[] CPUchoiceList = { "rock", "paper", "scissor", "paper", "scissor", "rock" };
        int randomNumber = 0;
        Random rnd = new Random();
        string CPUchoice;
        string playerChoice;
        int playerwins;
        int AIwins;

        public Form_Gra()
        {
            InitializeComponent();
            countDownTimer.Enabled = true;
            playerChoice = "none";
            txtTime.Text = "5";
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissor";
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            timerPerRound -= 1;
            txtTime.Text = timerPerRound.ToString();
            roundsText.Text = "Rounds: " + rounds;

            if (timerPerRound < 1)
            {
                countDownTimer.Enabled = false;
                timerPerRound = 6;
                randomNumber = rnd.Next(0, CPUchoiceList.Length);
                CPUchoice = CPUchoiceList[randomNumber];

                switch (CPUchoice)
                {
                    case "rock":
                        picCPU.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        picCPU.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        picCPU.Image = Properties.Resources.scissors;
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerwins > AIwins)
                    {
                        MessageBox.Show("Player Wins This Game");
                    }
                    else
                    {
                        MessageBox.Show("CPU Wins This Game");
                    }
                    gameover = true;
                }
            }
        }

        private void checkGame()
        {
            if (playerChoice == "rock" && CPUchoice == "paper")
            {
                AIwins += 1;
                rounds -= 1;
                MessageBox.Show("CPU Wins, Paper Covers Rocks");
            }
            else if (playerChoice == "scissor" && CPUchoice == "rock")
            {
                AIwins += 1;
                rounds -= 1;
                MessageBox.Show("CPU Wins, Rock Breaks Scissors");
            }
            else if (playerChoice == "paper" && CPUchoice == "scissor")
            {
                AIwins += 1;
                rounds -= 1;
                MessageBox.Show("CPU Wins, Scissor cuts paper");
            }
            else if (playerChoice == "rock" && CPUchoice == "scissor")
            {
                playerwins += 1;
                rounds -= 1;
                MessageBox.Show("Player Wins, Rock Breaks Scissors");
            }
            else if (playerChoice == "paper" && CPUchoice == "rock")
            {
                playerwins += 1;
                rounds -= 1;
                MessageBox.Show("Player Wins, Paper Covers Rocks");
            }
            else if (playerChoice == "scissor" && CPUchoice == "paper")
            {
                playerwins += 1;
                rounds -= 1;
                MessageBox.Show("Player Wins, Scissor cuts paper");
            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("Make your Choice");
            }
            else
            {
                MessageBox.Show("Draw");
            }

            startNextRound();
        }

        public void startNextRound()
        {
            if (gameover)
                return;

            txtMessage.Text = "Player: " + playerwins + " - " + "CPU: " + AIwins;
            playerChoice = "none";
            countDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
        }

        private void restartGame(object sender, EventArgs e)
        {
            playerwins = 0;
            AIwins = 0;
            rounds = 3;
            txtMessage.Text = "Player: " + playerwins + " - " + "CPU: " + AIwins;
            playerChoice = "none";
            txtTime.Text = "5";
            countDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
            gameover = false;
        }

        private void Form_Gra_Load(object sender, EventArgs e)
        {
            // Any additional load settings can go here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Setting settingsForm = new Form_Setting();
            settingsForm.ShowDialog();
            this.Close();
        }
    }
}
