using EpsilonNet.CodingSchool2022.Session_04;
using System.Text;

// 1.
var name = "Theodore";
var reverser = new StringReverser(name);
string reversedString = reverser.GetReversedString();
Console.WriteLine(reversedString);
Console.WriteLine();

// 2.
Console.Write("Please write a positive number: ");
uint n = ReadUInt32();
var spCalculator = new SumAndProductCalculator(n);

Console.Write("Please write what to calculate (sum, product): ");
bool opType = ReadOperationType();

var opName = opType ? "sum" : "product";
uint result = opType ? spCalculator.Sum : spCalculator.Product;
Console.WriteLine($"The {opName} of all numbers from 0 to {spCalculator.UpperBound} is {result}.");
Console.WriteLine();

// 3.
Console.Write("Please write a positive number: ");
n = ReadUInt32();
var primesCalculator = new PrimeNumberCalculator(n);

primesCalculator.DisplayPrimes();
Console.WriteLine();

// 4.
var array1 = new int[] { 2, 4, 9, 12 };
var array2 = new int[] { 1, 3, 7, 10 };
var multiplier = new ArrayMultiplier(array1, array2);
int[] hadamardProduct = multiplier.CalculateHadamardProduct();

Console.WriteLine($"The Hadamard product of {FormatArray(array1)} and {FormatArray(array2)} is {FormatArray(hadamardProduct)}");
Console.WriteLine();

// 5.
var numbers = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
var sorter = new IntArraySorter(numbers);

Console.WriteLine($"Unsorted: {FormatArray(numbers)}");
sorter.Sort();
Console.WriteLine($"Sorted: {FormatArray(numbers)}");

// Utility code
static bool HasNumericCharactersOnly(string str)
{
    for (int i = 0; i < str.Length; i++)
        if (str[i] < '0' || str[i] > '9')
            return false;
    return true;
}

static uint ReadUInt32()
{
    while (true)
    {
        string input = Console.ReadLine();
        if (input != null && input.Length != 0 && HasNumericCharactersOnly(input))
            return uint.Parse(input);
        Console.Write("Invalid input, please try again: ");
    }
}

/// <returns>true if the sum should be calculated, false otherwise.</returns>
static bool ReadOperationType()
{
    while (true)
    {
        string input = Console.ReadLine();
        if (input == "sum")
            return true;
        else if (input == "product")
            return false;
        else
            Console.Write("Invalid input, please try again: ");
    }
}

static string FormatArray(int[] array)
{
    if (array.Length == 0)
        return "[]";

    var result = "[";
    for (int i = 0; i < array.Length - 1; i++)
    {
        result += $"{array[i]}, ";
    }

    return result + $"{array[array.Length - 1]}]";
}
