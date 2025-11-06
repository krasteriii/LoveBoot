namespace LoveBoot.Core.Interfaces
{
    public interface IImageRecognitionService
    {
        Task<IEnumerable<KeyDetection>> DetectKeysAsync(CancellationToken token);
    }
}
