using LoveBoot.Core.Interfaces;
using LoveBoot.Core.Models;

namespace LoveBoot.Core.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public BotConfiguration GetConfiguration()
        {
            return new BotConfiguration
            {
                KeyCropSettings = new CropSettings { X = 250, Y = 473, Width = 524, Height = 58 },
                BarCropSettings = new CropSettings { X = 254, Y = 518, Width = 524, Height = 43 },
                KeyThreshold = 0.94,
                BarThreshold = 0.9
            };
        }
    }
}
