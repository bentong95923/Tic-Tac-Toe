namespace TicTacToe
{
    public partial class GameWindow : Form
    {
        List<Button> buttons;
        List<Label> labels;
        readonly Random random;
        GameStatus gameStatus;

        public GameWindow()
        {
            InitializeComponent();
            LoadButtonsAndLabels();
            random = new Random();
            gameStatus = new GameStatus();
            StartGame();
        }

        private void LoadButtonsAndLabels()
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

            labels =
            [
                label1,
                label2,
                label3,
                label4
            ];
        }

        private void ComputerMove(object sender, EventArgs e)
        {
            var buttonToClick = buttons
                .Where(b => b.Text == "")
                .OrderBy(b => random.Next())
                .First();
            buttonToClick.Text = gameStatus.PlayerTurn.ToString();
            LockButtons();
            var state = GameLogic.CheckGameState(buttons);
            ComputerMoves.Stop();
            if (state == GameState.InProgress)
            {
                gameStatus.PlayerTurn = Player.X;
                UnlockButtons();
                return;
            }
            EndGame(state);
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            var buttonClicked = (Button)sender;
            buttonClicked.Text = gameStatus.PlayerTurn.ToString();
            LockButtons();
            var state = GameLogic.CheckGameState(buttons);
            if (state == GameState.InProgress)
            {
                gameStatus.PlayerTurn = Player.O;
                ComputerMoves.Start();
                return;
            }
            EndGame(state);
        }

        private void EndGame(GameState status)
        {
            LockButtons();

            var message = "";
            switch (status)
            {
                case GameState.PlayerXWins:
                    gameStatus.PlayerWins++;
                    label3.Text = $"Wins - {gameStatus.PlayerWins}";
                    message = "Player X wins!";
                    break;
                case GameState.PlayerOWins:
                    gameStatus.AiWins++;
                    label4.Text = $"Wins - {gameStatus.AiWins}";
                    message = "AI wins!";
                    break;
                case GameState.Draw:
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
            ResetGame();
        }

        private void ResetGame()
        {
            if (ComputerMoves.Enabled)
            {
                ComputerMoves.Stop();
            }
            foreach (var button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
            // Randomly select the starting player
            gameStatus.PlayerTurn = (Player)random.Next(0, Enum.GetValues<Player>().Length);
            if (gameStatus.PlayerTurn == Player.O)
            {
                ComputerMoves.Start();
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void LockButtons()
        {
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void UnlockButtons()
        {
            foreach (var button in buttons)
            {
                button.Enabled = true;
            }
        }
    }
}
