namespace EpsilonNet.CodingSchool2022.CalculatorLib;

public enum InputType
{
    None,

    Number0,
    Number1,
    Number2,
    Number3,
    Number4,
    Number5,
    Number6,
    Number7,
    Number8,
    Number9,

    Dot,

    Add,
    Subtract,
    Multiply,
    Divide,
    Pow,
    SquareRoot,

    NumberMin = Number0,
    NumberMax = Number9,

    OperationMin = Add,
    OperationMax = SquareRoot,
}

public enum OperationType
{
    NotAnOperation,
    UnaryOperation,
    BinaryOperation
}

public static class InputTypeExtensions
{
    public static bool IsNumber(this InputType input)
    {
        return input >= InputType.NumberMin && input <= InputType.NumberMax;
    }

    public static bool IsNumberElement(this InputType input)
    {
        return input.IsNumber() || input == InputType.Dot;
    }

    public static byte? GetNumericValue(this InputType input)
    {
        if (!input.IsNumber())
            return null;

        return (byte)(input - InputType.Number0);
    }

    public static bool IsOperation(this InputType input)
    {
        return input >= InputType.OperationMin && input <= InputType.OperationMax;
    }

    public static OperationType GetOperationType(this InputType input)
    {
        if (!input.IsOperation())
            return OperationType.NotAnOperation;
        else if (input == InputType.SquareRoot)
            return OperationType.UnaryOperation;
        else
            return OperationType.BinaryOperation;
    }
}

