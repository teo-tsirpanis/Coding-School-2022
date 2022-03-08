namespace EpsilonNet.CodingSchool2022.Session_05.SpecificResolvers;

internal class UppercaseSpecificResolver : AbstractSpecificResolver
{
    public UppercaseSpecificResolver()
    {
    }

    private string? FindLongestWord(string[] words)
    {
        string? longestWord = null;
        int longestWordLength = 0;

        for (int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i];
            if (currentWord.Length > longestWordLength)
            {
                longestWordLength = currentWord.Length;
                longestWord = currentWord;
            }
        }

        return longestWord;
    }

    public override string? Execute(string content, MessageLogger logger)
    {
        string[] words = content.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        string? longestWord = FindLongestWord(words);

        logger.Write($"The string consists of {words.Length} words.");

        // It will automatically fail if there are no words in the input string.
        return longestWord;
    }
}
