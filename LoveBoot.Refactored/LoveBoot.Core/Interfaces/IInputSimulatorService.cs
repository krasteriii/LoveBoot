using LoveBoot.Core.Models;

namespace LoveBoot.Core.Interfaces
{
    public interface IInputSimulatorService
    {
        Task PressKeyAsync(KeyCode key, CancellationToken token);
        Task TypeTextAsync(string text, CancellationToken token);
    }
}
