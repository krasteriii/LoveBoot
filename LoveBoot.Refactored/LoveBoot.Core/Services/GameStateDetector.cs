using LoveBoot.Core.Interfaces;
using LoveBoot.Core.Models;
using System.Linq;

namespace LoveBoot.Core.Services
{
    public class GameStateDetector : IGameStateDetector
    {
        private readonly IImageRecognitionService _imageRecognitionService;
        private GameState _previousGameState;

        public GameStateDetector(IImageRecognitionService imageRecognitionService)
        {
            _imageRecognitionService = imageRecognitionService;
            _previousGameState = new GameState { NeedsAction = false };
        }

        public async Task<GameState> GetCurrentStateAsync(CancellationToken token)
        {
            var detectedKeys = await _imageRecognitionService.DetectKeysAsync(token);
            var newGameState = new GameState { NeedsAction = false };

            if (detectedKeys.Any())
            {
                var keyToPress = detectedKeys.First().Key;
                if (keyToPress != (_previousGameState.RequiredKey))
                {
                    newGameState.NeedsAction = true;
                    newGameState.RequiredKey = keyToPress;
                }
            }

            _previousGameState = newGameState;
            return newGameState;
        }
    }
}
