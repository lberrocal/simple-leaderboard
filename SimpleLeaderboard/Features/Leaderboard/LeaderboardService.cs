namespace SimpleLeaderboard.Features.Leaderboard
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly IScoreRepository _scoreRepository;

        public LeaderboardService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public async Task<IEnumerable<HighScore>> GetHighScoresAsync(int page, int pageSize)
        {
            var highScores = await _scoreRepository.GetScoresAsync(page, pageSize);

            return highScores;
        }

        public Task<int> SaveHighScoreAndGetPlaceAsync(HighScore highScore)
        {
            throw new NotImplementedException();
        }
    }

    public interface ILeaderboardService
    {
        public Task<IEnumerable<HighScore>> GetHighScoresAsync(int page, int pageSize);
        public Task<int> SaveHighScoreAndGetPlaceAsync(HighScore highScore);
    }

}