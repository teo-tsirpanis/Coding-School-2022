using System.Numerics;

namespace EpsilonNet.CodingSchool2022.Session_04;

internal class ArrayMultiplier
{
    public int[] Left { get; }

    public int[] Right { get; }

    public ArrayMultiplier(int[] left, int[] right)
    {
        Left = left;
        Right = right;
    }

    // Because the left and right arrays are mutable, we can't
    // store the result in a property, like the other classes.
    public int[] CalculateHadamardProduct()
    {
        int length = Math.Min(Left.Length, Right.Length);
        int[] result = new int[length];

        for (int i = 0; i < length; i++)
            result[i] = Left[i] * Right[i];

        return result;
    }

    public int[] CalculateHadamardProductOptimized()
    {
        if (!Vector.IsHardwareAccelerated)
            return CalculateHadamardProduct();

        int length = Math.Min(Left.Length, Right.Length);
        int[] result = new int[length];

        int i;
        for (i = 0; i < length; i+= Vector<int>.Count)
        {
            var v1 = new Vector<int>(Left, i);
            var v2 = new Vector<int>(Right, i);

            var vResult = v1 * v2;
            vResult.CopyTo(result, i);
        }

        for (; i < length; i++)
            result[i] = Left[i] * Right[i];

        return result;
    }
}
