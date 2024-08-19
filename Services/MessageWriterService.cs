namespace MvcMovie.Services;

using MvcMovie.Services.Interface;

class MessageWriterService : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
    }
}