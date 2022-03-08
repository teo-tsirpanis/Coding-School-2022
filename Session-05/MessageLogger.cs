namespace EpsilonNet.CodingSchool2022.Session_05;

public class MessageLogger
{
    private Message?[] _messages;

    int _count;

    public MessageLogger()
    {
        _messages = new Message[64];
        _count = 0;
    }

    public Message[] ReadAll()
    {
        // We assume that all messages written so far are not null.
        return _messages.AsSpan(0, _count).ToArray()!;
    }

    public void Write(Message message)
    {
        if (_count == _messages.Length)
            Array.Resize(ref _messages, _messages.Length * 2);

        _messages[_count++] = message;
    }

    // A conventience method that creates a GUID and sets the time to now.
    public void Write(string message)
    {
        var messageObj = new Message(Guid.NewGuid(), DateTime.UtcNow, message);

        Write(messageObj);
    }

    public void Clear()
    {
        Array.Clear(_messages, 0, _count);
        _count = 0;
    }
}
