using System.Diagnostics;
using System.Globalization;

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
            case State.WaitingForOperand1:
                return input.IsNumberElement();
            case State.WritingOperand1:
                return isOperation || _op1Builder.CanEnter(input);
            case State.WaitingForOperand2:
                return input.IsNumberElement();
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
            case State.WaitingForOperand1:
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
                if (operationType == OperationType.UnaryOperation)
                {
                    _currentState = State.Finished;
                    _finalResultValue = PerformOperation(input, _op1Builder.GetValue(), 0);
                    return;
                }

                _currentState = State.WaitingForOperand2;
                break;
            case State.WaitingForOperand2:
            case State.WritingOperand2:
                _op2Builder.Enter(input);
                _currentState = State.WritingOperand2;
                break;
        }
    }

    public string GetDisplayText()
    {
        switch (_currentState)
        {
            case State.WritingOperand2:
                return _op2Builder.ToString();
            case State.Finished:
                return _finalResultValue.ToString(CultureInfo.InvariantCulture);
            default:
                return _op1Builder.ToString();
        }
    }

    public bool CanFinish
    {
        get
        {
            return _currentState == State.WritingOperand1 || _currentState == State.WritingOperand2;
        }
    }

    public void Finish()
    {
        switch (_currentState)
        {
            case State.WaitingForOperand1:
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
        _currentState = State.WaitingForOperand1;
    }

    private enum State
    {
        WaitingForOperand1,
        WritingOperand1,
        WaitingForOperand2,
        WritingOperand2,
        Finished
    }
}
