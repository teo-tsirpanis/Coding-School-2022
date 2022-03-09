using EpsilonNet.CodingSchool2022.CalculatorLib;
using System;
using System.Windows.Forms;

namespace EpsilonNet.CodingSchool2022.Session06
{
    public partial class Form1 : Form
    {
        private readonly Calculator _calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateState()
        {
            tbScreen.Text = _calculator.GetDisplayText();
            btnNumber0.Enabled = _calculator.CanEnter(InputType.Number0);
            btnNumber1.Enabled = _calculator.CanEnter(InputType.Number1);
            btnNumber2.Enabled = _calculator.CanEnter(InputType.Number2);
            btnNumber3.Enabled = _calculator.CanEnter(InputType.Number3);
            btnNumber4.Enabled = _calculator.CanEnter(InputType.Number4);
            btnNumber5.Enabled = _calculator.CanEnter(InputType.Number5);
            btnNumber6.Enabled = _calculator.CanEnter(InputType.Number6);
            btnNumber7.Enabled = _calculator.CanEnter(InputType.Number7);
            btnNumber8.Enabled = _calculator.CanEnter(InputType.Number8);
            btnNumber9.Enabled = _calculator.CanEnter(InputType.Number9);
            btnAdd.Enabled = _calculator.CanEnter(InputType.Add);
            btnSubtract.Enabled = _calculator.CanEnter(InputType.Subtract);
            btnMultiply.Enabled = _calculator.CanEnter(InputType.Multiply);
            btnDivide.Enabled = _calculator.CanEnter(InputType.Divide);
            btnPow.Enabled = _calculator.CanEnter(InputType.Pow);
            btnSquareRoot.Enabled = _calculator.CanEnter(InputType.SquareRoot);
        }

        private void EnterInput(InputType input)
        {
            _calculator.Enter(input);
            UpdateState();
        }

        private void btnNumber0_Click(object sender, EventArgs e) => EnterInput(InputType.Number0);

        private void btnNumber1_Click(object sender, EventArgs e) => EnterInput(InputType.Number1);

        private void btnNumber2_Click(object sender, EventArgs e) => EnterInput(InputType.Number2);

        private void btnNumber3_Click(object sender, EventArgs e) => EnterInput(InputType.Number3);

        private void btnNumber4_Click(object sender, EventArgs e) => EnterInput(InputType.Number4);

        private void btnNumber5_Click(object sender, EventArgs e) => EnterInput(InputType.Number5);

        private void btnNumber6_Click(object sender, EventArgs e) => EnterInput(InputType.Number6);

        private void btnNumber7_Click(object sender, EventArgs e) => EnterInput(InputType.Number7);

        private void btnNumber8_Click(object sender, EventArgs e) => EnterInput(InputType.Number8);

        private void btnNumber9_Click(object sender, EventArgs e) => EnterInput(InputType.Number9);

        private void btnDot_Click(object sender, EventArgs e) => EnterInput(InputType.Dot);

        private void btnAdd_Click(object sender, EventArgs e) => EnterInput(InputType.Add);

        private void btnSubtract_Click(object sender, EventArgs e) => EnterInput(InputType.Subtract);

        private void btnMultiply_Click(object sender, EventArgs e) => EnterInput(InputType.Multiply);

        private void btnDivide_Click(object sender, EventArgs e) => EnterInput(InputType.Divide);

        private void btnPow_Click(object sender, EventArgs e) => EnterInput(InputType.Pow);

        private void btnSquareRoot_Click(object sender, EventArgs e) => EnterInput(InputType.SquareRoot);

        private void btnClear_Click(object sender, EventArgs e)
        {
            _calculator.Clear();
            UpdateState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            _calculator.Finish();
            UpdateState();
        }
    }
}
