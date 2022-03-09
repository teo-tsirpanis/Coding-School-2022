using System.Diagnostics;

namespace EpsilonNet.CodingSchool2022.CalculatorLib;

public class Calculator
{
    private readonly NumberBuilder _op1Builder, _op2Builder;

    private InputType _currentOperation;

    private State _currentState;

    private double _finalResultValue;

    public Calculator()
    {
        _op1Builder = new NumberBuilder();
        _op2Builder = new NumberBuilder();
    }

    public bool CanEnter(InputType input)
    {
        bool isOperation = input.IsOperation();

        switch (_currentState)
        {
            case State.NoInput:
                return input.IsNumberElement();
            case State.WritingOperand1:
                return isOperation || _op1Builder.CanEnter(input);
            case State.WritingOperand2:
                return _op2Builder.CanEnter(input);
            default:
                return false;
        }
    }

    public void Enter(InputType input)
    {
        if (!CanEnter(input))
            return;

        switch (_currentState)
        {
            case State.NoInput:
                _op1Builder.Enter(input);
                _currentState = State.WritingOperand1;
                break;
            case State.WritingOperand1:
                OperationType operationType = input.GetOperationType();

                if (operationType == OperationType.NotAnOperation)
                {
                    _op1Builder.Enter(input);
                    return;
                }

                _currentOperation = input;
                _currentState = operationType == OperationType.UnaryOperation ? State.Finished : State.WritingOperand2;
                break;
            case State.WritingOperand2:
                _op2Builder.Enter(input);
                break;
        }
    }

    public string GetDisplayText()
    {
        if (_currentState == State.Finished)
            return _finalResultValue.ToString();
        else if (_currentState == State.WritingOperand2)
            return _op2Builder.ToString();
        else
            return _op1Builder.ToString();
    }

    public void Finish()
    {
        switch (_currentState)
        {
            case State.NoInput:
                _finalResultValue = 0;
                break;
            case State.WritingOperand1:
                _finalResultValue = _op1Builder.GetValue();
                break;
            case State.WritingOperand2:
            case State.Finished:
                double op1 = _op1Builder.GetValue();
                double op2 = _op2Builder.GetValue();
                _finalResultValue = PerformOperation(_currentOperation, op1, op2);
                break;
        }
        _currentState = State.Finished;
    }

    private static double PerformOperation(InputType operation, double operand1, double operand2)
    {
        switch (operation)
        {
            case InputType.Add:
                return operand1 + operand2;
            case InputType.Subtract:
                return operand1 - operand2;
            case InputType.Multiply:
                return operand1 * operand2;
            case InputType.Divide:
                return operand1 / operand2;
            case InputType.Pow:
                return Math.Pow(operand1, operand2);
            case InputType.SquareRoot:
                return Math.Sqrt(operand1);
            default:
                Debug.Fail("Input is not an operation");
                return 0;
        }
    }

    public void Clear()
    {
        _op1Builder.Clear();
        _op2Builder.Clear();
        _currentOperation = InputType.None;
        _currentState = State.NoInput;
    }

    private enum State
    {
        NoInput,
        WritingOperand1,
        WritingOperand2,
        Finished
    }
}
