namespace MvcMovie.Services;

using MvcMovie.Services.Interface;
class SeocndMessageWriterService : IMessageWriter
{
    private readonly ILogger<SeocndMessageWriterService> _logger;

    public SeocndMessageWriterService(ILogger<SeocndMessageWriterService> logger)
    {
        _logger = logger;
    }

    public void Write(string message)
    {
        _logger.LogInformation($"MyDependency2.WriteMessage Message: {message}");
    }
}
