namespace TicTacToe
{
    public partial class GameWindow : Form
    {
        List<Button> buttons;
        readonly Random random;
        int playerWins;
        int aiWins;
        Player playerTurn;

        public GameWindow()
        {
            InitializeComponent();
            LoadButtons();
            random = new Random();
            StartGame();
        }

        private void LoadButtons()
        {
            buttons =
            [
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9
            ];
        }

        private void ComputerMove(object sender, EventArgs e)
        {
            var buttonToClick = buttons
                .Where(b => b.Enabled)
                .OrderBy(b => random.Next())
                .First();
            buttonToClick.Text = playerTurn.ToString();
            buttonToClick.Enabled = false;
            var status = ShouldEndGame();
            ComputerMoves.Stop();
            if (status == GameStatus.InProgress)
            {
                playerTurn = Player.X;
                return;
            }
            EndGame(status);
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            var buttonClicked = (Button)sender;
            buttonClicked.Text = playerTurn.ToString();
            buttonClicked.Enabled = false;
            var status = ShouldEndGame();
            if (status == GameStatus.InProgress)
            {
                playerTurn = Player.O;
                ComputerMoves.Start();
                return;
            }
            EndGame(status);
        }

        private GameStatus ShouldEndGame()
        {
            GameStatus status = GameStatus.InProgress;
            if (IsPlayerWin(Player.X))
            {
                status = GameStatus.PlayerXWins;
            }
            else if (IsPlayerWin(Player.O))
            {
                status = GameStatus.PlayerOWins;
            }
            else if (buttons.All(b => !b.Enabled))
            {
                status = GameStatus.Draw;
            }
            return status;
        }

        private bool IsPlayerWin(Player player)
        {
            var playerText = player.ToString();
            return
            (
                // Rows
                button1.Text == playerText && button2.Text == playerText && button3.Text == playerText ||
                button4.Text == playerText && button5.Text == playerText && button6.Text == playerText ||
                button7.Text == playerText && button8.Text == playerText && button9.Text == playerText ||

                // Columns
                button1.Text == playerText && button4.Text == playerText && button7.Text == playerText ||
                button2.Text == playerText && button5.Text == playerText && button8.Text == playerText ||
                button3.Text == playerText && button6.Text == playerText && button9.Text == playerText ||

                // Diagonals
                button1.Text == playerText && button5.Text == playerText && button9.Text == playerText ||
                button3.Text == playerText && button5.Text == playerText && button7.Text == playerText
            );
        }

        private void EndGame(GameStatus status)
        {
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }

            var message = "";
            switch (status)
            {
                case GameStatus.PlayerXWins:
                    playerWins++;
                    label3.Text = $"Wins - {playerWins}";
                    message = "Player X wins!";
                    break;
                case GameStatus.PlayerOWins:
                    aiWins++;
                    label4.Text = $"Wins - {aiWins}";
                    message = "AI wins!";
                    break;
                case GameStatus.Draw:
                    message = "It's a draw!";
                    break;
                default:
                    break;
            }

            MessageBox.Show(message);
            ResetGame();
        }

        private void StartGame()
        {
            playerWins = 0;
            aiWins = 0;
            ResetGame();
        }

        private void ResetGame()
        {
            foreach (var button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
            playerTurn = Player.X;
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
