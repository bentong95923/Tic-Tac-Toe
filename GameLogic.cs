namespace TicTacToe
{
    public static class GameLogic
    {
        public static GameState CheckGameState(List<Button> buttons)
        {
            GameState status = GameState.InProgress;
            if (IsPlayerWin(Player.X, buttons))
            {
                status = GameState.PlayerXWins;
            }
            else if (IsPlayerWin(Player.O, buttons))
            {
                status = GameState.PlayerOWins;
            }
            else if (buttons.All(b => b.Text != ""))
            {
                status = GameState.Draw;
            }
            return status;
        }

        public static bool IsPlayerWin(Player player, List<Button> buttons)
        {
            var playerText = player.ToString();
            return
            (
                // Rows
                buttons[0].Text == playerText && buttons[1].Text == playerText && buttons[2].Text == playerText ||
                buttons[3].Text == playerText && buttons[4].Text == playerText && buttons[5].Text == playerText ||
                buttons[6].Text == playerText && buttons[7].Text == playerText && buttons[8].Text == playerText ||

                // Columns
                buttons[0].Text == playerText && buttons[3].Text == playerText && buttons[6].Text == playerText ||
                buttons[1].Text == playerText && buttons[4].Text == playerText && buttons[7].Text == playerText ||
                buttons[2].Text == playerText && buttons[5].Text == playerText && buttons[8].Text == playerText ||

                // Diagonals
                buttons[0].Text == playerText && buttons[4].Text == playerText && buttons[8].Text == playerText ||
                buttons[2].Text == playerText && buttons[4].Text == playerText && buttons[6].Text == playerText
            );
        }
    }
}
