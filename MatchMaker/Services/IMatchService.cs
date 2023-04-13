using MatchMaker.Entities;

namespace MatchMaker.Services;

public interface IMatchService
{
    Task<GameMatch> FindMatchAsync(string player);
}