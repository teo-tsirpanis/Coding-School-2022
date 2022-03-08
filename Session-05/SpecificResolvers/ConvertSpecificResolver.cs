namespace EpsilonNet.CodingSchool2022.Session_05.SpecificResolvers;

public class ConvertSpecificResolver : AbstractSpecificResolver
{
    public ConvertSpecificResolver()
    {
    }

    public override string? Execute(string content, MessageLogger logger)
    {
        // We assume "a decimal number" means an integer in the decimal system.
        // Not strictly matching the C# decimal type, because it cannot be formatted to binary.
        int result;
        if (!int.TryParse(content, out result))
        {
            logger.Write("Input is not an integer.");
            return null;
        }

        return Convert.ToString(result, 2);
    }
}
