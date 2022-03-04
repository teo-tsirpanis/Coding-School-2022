namespace EpsilonNet.CodingSchool2022.Session_04;

internal class IntArraySorter
{
    public int[] Numbers { get; }

    public IntArraySorter(int[] numbers)
    {
        Numbers = numbers;
    }

    // Inspired by https://source.dot.net/#System.Private.CoreLib/ArraySortHelper.cs,254
    public void Sort()
    {
        for (int i = 0; i < Numbers.Length - 1; i++)
        {
            int t = Numbers[i + 1];

            int j = i;
            while (j >= 0 && t < Numbers[j])
            {
                Numbers[j + 1] = Numbers[j];
                j--;
            }

            Numbers[j + 1] = t;
        }
    }
}
