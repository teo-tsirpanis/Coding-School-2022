using System.Globalization;
using System.Text;

namespace EpsilonNet.CodingSchool2022.CalculatorLib;

internal class NumberBuilder
{
    private readonly StringBuilder _accumulator = new StringBuilder();

    private bool _hasDot;

    public NumberBuilder()
    {
    }

    public void Enter(InputType input)
    {
        if (input == InputType.Dot)
        {
            if (_hasDot)
                return;
            _hasDot = true;
            if (_accumulator.Length == 0)
                _accumulator.Append('0');
            _accumulator.Append('.');
            return;
        }

        byte? inputNumericValue = input.GetNumericValue();

        if (inputNumericValue.HasValue)
        {
            char numberChar = (char)(inputNumericValue.GetValueOrDefault() + '0');
            _accumulator.Append(numberChar);
        }
    }

    public bool CanEnter(InputType input)
    {
        if (input.IsNumber())
            return true;
        else if (input == InputType.Dot)
            return !_hasDot;
        else
            return false;
    }

    public double GetValue()
    {
        string accumulatedString = _accumulator.ToString();
        return double.Parse(accumulatedString, CultureInfo.InvariantCulture);
    }

    public void Clear()
    {
        _accumulator.Clear();
        _hasDot = false;
    }

    public override string ToString()
    {
        return _accumulator.ToString();
    }
}
