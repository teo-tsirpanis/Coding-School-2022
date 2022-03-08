namespace EpsilonNet.CodingSchool2022.Session_05;

public class Message
{
    public Guid ID { get; }

    public DateTime TimeStamp { get; }

    // Was "Message" in the spec, renamed due to collisions.
    public string Payload { get; }

    public Message(Guid id, DateTime timeStamp, string message)
    {
        ID = id;
        TimeStamp = timeStamp;
        Payload = message;
    }

    public override string ToString()
    {
        return $"[{ID}, {TimeStamp}] {Payload}";
    }
}
