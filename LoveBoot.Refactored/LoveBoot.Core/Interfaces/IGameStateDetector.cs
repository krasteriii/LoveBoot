using LoveBoot.Core.Models;

namespace LoveBoot.Core.Interfaces
{
    public interface IGameStateDetector
    {
        Task<GameState> GetCurrentStateAsync(CancellationToken token);
    }
}
