namespace EpsilonNet.CodingSchool2022.Session_05;

public abstract class AbstractSpecificResolver
{
    public AbstractSpecificResolver()
    {
    }

    public abstract string? Execute(string content, MessageLogger logger);
}
