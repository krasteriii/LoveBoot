namespace LoveBoot.Core.Models
{
    public class BotConfiguration
    {
        public CropSettings KeyCropSettings { get; set; }
        public CropSettings BarCropSettings { get; set; }
        public double KeyThreshold { get; set; }
        public double BarThreshold { get; set; }
    }

    public class CropSettings
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
