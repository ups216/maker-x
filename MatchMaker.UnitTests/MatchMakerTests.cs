using MatchMaker.Entities;
using MatchMaker.Services;

namespace MatchMaker.UnitTests;

public class MatchMakerTests
{
    [Fact]
    public async Task FindMatchAsync_ReturnsExistingMatch_IfPlayerIsAlreadyInMatch()
    {
        // Arrange
        var match = new GameMatch { Id = 1, Player1 = "Alice", Player2 = "Bob", State = MatchState.GameReady };
        var service = new MatchService();

        // Act
        var result = await service.FindMatchAsync("Bob");

        // Assert
        Assert.Equal(match, result);
    }

    [Fact]
    public async Task FindMatchAsync_ReturnsOpenMatch_IfOneExists()
    {
        // Arrange
        var match = new GameMatch { Id = 1, Player1 = "Alice", State = MatchState.WaitingForOpponent };
        var service = new MatchService();

        // Act
        var result = await service.FindMatchAsync("Bob");

        // Assert
        Assert.Equal("Bob", result.Player2);
        Assert.Equal(MatchState.MatchFound, result.State);
    }

    [Fact]
    public async Task FindMatchAsync_CreatesNewMatch_IfNoExistingOrOpenMatch()
    {
        // Arrange
        var service = new MatchService();

        // Act
        var result = await service.FindMatchAsync("Alice");

        // Assert
        Assert.Equal(1, result.Id);
        Assert.Equal("Alice", result.Player1);
        Assert.Equal(MatchState.WaitingForOpponent, result.State);
    }
}