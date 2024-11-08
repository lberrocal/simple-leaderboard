namespace SimpleLeaderboard.Features.Leaderboard
{
    public class HighScore
    {
        public int Score { get; set; }
        public required string PlayerName { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
    }
}