namespace EpsilonNet.CodingSchool2022.Session_04;

internal class PrimeNumberCalculator
{
    public uint UpperBound { get; }

    public PrimeNumberCalculator(uint upperBound)
    {
        UpperBound = upperBound;
    }

    private bool IsPrime(uint x)
    {
        if (x == 0 || x == 1)
            return false;

        var upperCheckLimit = (uint)Math.Sqrt(x);
        for (int i = 2; i <= upperCheckLimit; i++)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }

    public void DisplayPrimes()
    {
        Console.Write($"The primes between 0 and {UpperBound} are ");
        for (uint i = 0; i < UpperBound; i++)
        {
            if (IsPrime(i))
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}
