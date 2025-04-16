namespace TicTacToe
{
    public class GameStatus
    {
        public GameStatus()
        {
            PlayerWins = 0;
            AiWins = 0;            
        }
        public int PlayerWins { get; set; }
        public int AiWins { get; set; }
        public Player PlayerTurn { get; set; }
    }
}
