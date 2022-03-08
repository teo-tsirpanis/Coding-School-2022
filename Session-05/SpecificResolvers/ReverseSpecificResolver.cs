namespace EpsilonNet.CodingSchool2022.Session_05.SpecificResolvers;

public class ReverseSpecificResolver : AbstractSpecificResolver
{
    // cries in string.Create<TState>(Int32, TState, SpanAction<Char,TState>)
    private static string ReverseString(string str)
    {
        string reversedString = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
            reversedString += str[i];

        return reversedString;
    }

    public override string Execute(string content, MessageLogger logger)
    {
        // No need to log anything; both the input and the output are logged by the action resolver.
        return ReverseString(content);
    }
}
