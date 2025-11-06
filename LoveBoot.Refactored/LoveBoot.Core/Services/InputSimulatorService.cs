using H.InputSimulator;
using LoveBoot.Core.Interfaces;
using LoveBoot.Core.Models;

namespace LoveBoot.Core.Services
{
    public class InputSimulatorService : IInputSimulatorService
    {
        private readonly IInputSimulator _inputSimulator;

        public InputSimulatorService()
        {
            _inputSimulator = new InputSimulator();
        }

        public Task PressKeyAsync(KeyCode key, CancellationToken token)
        {
            _inputSimulator.Keyboard.KeyPress(MapKeyCode(key));
            return Task.CompletedTask;
        }

        public Task TypeTextAsync(string text, CancellationToken token)
        {
            _inputSimulator.Keyboard.TextEntry(text);
            return Task.CompletedTask;
        }

        private VirtualKeyCode MapKeyCode(KeyCode key)
        {
            return key switch
            {
                KeyCode.Up => VirtualKeyCode.UP,
                KeyCode.Down => VirtualKeyCode.DOWN,
                KeyCode.Left => VirtualKeyCode.LEFT,
                KeyCode.Right => VirtualKeyCode.RIGHT,
                KeyCode.Space => VirtualKeyCode.SPACE,
                KeyCode.UpLeft => VirtualKeyCode.HOME,
                KeyCode.UpRight => VirtualKeyCode.PRIOR,
                KeyCode.DownLeft => VirtualKeyCode.END,
                KeyCode.DownRight => VirtualKeyCode.NEXT,
                _ => VirtualKeyCode.VK_0,
            };
        }
    }
}
