using NUnit.Framework;
using Moq.AutoMock;
using Moq;

using SimpleLeaderboard.Features.Leaderboard;


namespace SimpleLeaderboard.Tests.Features.Leaderboard
{
    public class LeadeboardServiceTests
    {
        private AutoMocker _autoMocker;
        private LeaderboardService _sut;
        
        [SetUp]
        public void SetUp()
        {
            _autoMocker = new AutoMocker();
            _sut = _autoMocker.CreateInstance<LeaderboardService>();
        }

        [Test]
        public async Task GetHighScoresAsync_Should_Return_HighScore()
        {
            // Arrange
            var ct = new CancellationToken();

            // Act
            var highScores = await _sut.GetHighScoresAsync(1, 10, ct);

            Assert.That(highScores, Is.InstanceOf<IEnumerable<HighScore>>());
        }
    }
}