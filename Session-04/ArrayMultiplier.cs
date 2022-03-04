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
    public int[] CalculateProduct()
    {
        int[] result = new int[Left.Length * Right.Length];

        int k = 0;
        for (int i = 0; i < Left.Length; i++)
            for (int j = 0; j < Right.Length; j++)
            result[k++] = Left[i] * Right[j];

        return result;
    }
}
