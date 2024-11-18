
namespace SimpleLeaderboard.Features.Leaderboard
{
    public class ScoreRepository : IScoreRepository
    {
        public async Task AddHighscoreAsync(HighScore highScore, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HighScore>> GetScoresAsync(int page, int pageSize, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
    public interface IScoreRepository
    {
        Task<IEnumerable<HighScore>> GetScoresAsync(int page, int pageSize, CancellationToken ct);
        Task AddHighscoreAsync(HighScore highScore, CancellationToken ct);
    }

}