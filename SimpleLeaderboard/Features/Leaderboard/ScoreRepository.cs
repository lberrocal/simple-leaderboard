
namespace SimpleLeaderboard.Features.Leaderboard
{
    public class ScoreRepository : IScoreRepository
    {
        public Task<IEnumerable<HighScore>> GetScoresAsync(int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
    public interface IScoreRepository
    {
        Task<IEnumerable<HighScore>> GetScoresAsync(int page, int pageSize);
    }

}