namespace SimpleLeaderboard.Features.Leaderboard
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly IScoreRepository _scoreRepository;

        public LeaderboardService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public async Task<IEnumerable<HighScore>> GetHighScoresAsync(int page, int pageSize, CancellationToken ct)
        {
            var highScores = await _scoreRepository.GetScoresAsync(page, pageSize, ct);

            return highScores;
        }

        public async Task<int> SaveHighScoreAndGetPlaceAsync(HighScore highScore, CancellationToken ct)
        {
            await _scoreRepository.AddHighscoreAsync(highScore, ct);

            return 0;
        }
    }

    public interface ILeaderboardService
    {
        public Task<IEnumerable<HighScore>> GetHighScoresAsync(int page, int pageSize, CancellationToken ct);
        public Task<int> SaveHighScoreAndGetPlaceAsync(HighScore highScore, CancellationToken ct);
    }

}