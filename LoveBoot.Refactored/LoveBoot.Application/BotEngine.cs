using LoveBoot.Core.Interfaces;
using Microsoft.Extensions.Hosting;

namespace LoveBoot.Application
{
    public class BotEngine : BackgroundService
    {
        private readonly IGameStateDetector _gameStateDetector;
        private readonly IInputSimulatorService _inputSimulator;

        public BotEngine(IGameStateDetector gameStateDetector, IInputSimulatorService inputSimulator)
        {
            _gameStateDetector = gameStateDetector;
            _inputSimulator = inputSimulator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var gameState = await _gameStateDetector.GetCurrentStateAsync(stoppingToken);
                if (gameState.NeedsAction)
                {
                    await _inputSimulator.PressKeyAsync(gameState.RequiredKey, stoppingToken);
                }

                await Task.Delay(10, stoppingToken); // Small delay to prevent tight loop
            }
        }
    }
}
