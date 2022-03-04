using System.Text;

namespace EpsilonNet.CodingSchool2022.Session_04;

internal class StringReverser
{
    public string OriginalString { get; }

    public StringReverser(string originalString)
    {
        OriginalString = originalString;
    }

    public string GetReversedString()
    {
        string reversedString = string.Empty;

        for (int i = OriginalString.Length - 1; i >= 0; i--)
            reversedString += OriginalString[i];

        return reversedString;
    }

    public string GetReversedStringOptimized()
    {
        var sb = new StringBuilder(OriginalString.Length);

        for (int i = OriginalString.Length; i >= 0; i--)
            sb.Append(OriginalString[i]);

        return sb.ToString();
    }

    public string GetReversedStringMoreOptimized()
    {
        return string.Create(OriginalString.Length, OriginalString, (buffer, input) =>
        {
            input.CopyTo(buffer);
            buffer.Reverse();
        });
    }
}
