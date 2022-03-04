namespace EpsilonNet.CodingSchool2022.Session_04;

internal class SumAndProductCalculator
{
    public uint UpperBound { get; }

    public uint Sum { get; }

    public uint Product { get; }

    public SumAndProductCalculator(uint originalValue)
    {
        UpperBound = originalValue;
        Sum = 0;
        Product = 1;

        for (uint i = 1; i <= UpperBound; i++)
        {
            Sum += i;
            Product *= i;
        }
    }
}
