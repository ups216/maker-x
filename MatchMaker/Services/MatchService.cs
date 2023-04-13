using MatchMaker.Entities;

namespace MatchMaker.Services;

public class MatchService : IMatchService
{
    private readonly List<GameMatch> _matches = new();
    private int _nextMatchId = 1;

    public async Task<GameMatch> FindMatchAsync(string player)
    {
        var existingMatch = _matches.FirstOrDefault(m => m.Player1 == player || m.Player2 == player);
        if (existingMatch != null)
        {
            return await Task.FromResult(existingMatch);
        }

        var openMatch = _matches.FirstOrDefault(m => m.Player2 == null);
        if (openMatch != null)
        {
            openMatch.Player2 = player;
            openMatch.State = MatchState.MatchFound;
            return await Task.FromResult(openMatch);
        }

        var newMatch = new GameMatch { Id = _nextMatchId++, Player1 = player, State = MatchState.WaitingForOpponent };
        _matches.Add(newMatch);
        return await Task.FromResult(newMatch);
    }
}