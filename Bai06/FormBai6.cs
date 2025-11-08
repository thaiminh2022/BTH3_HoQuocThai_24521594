using System;
using System.Data;

namespace Bai06
{
    public partial class FormBai6 : Form
    {
        Calculator _calculator;
        bool _requireClear = false;
        bool _allowAddOp = true;
        public FormBai6()
        {
            InitializeComponent();
            _calculator = new Calculator();

            // SETUP
            calBox.Text = "0";


            // NUMBER RELATED BUTTONS
            Button[] numButtons = [
                n0Btn, n1Btn, n2Btn, n3Btn, n4Btn, n5Btn, n6Btn, n7Btn, n8Btn, n9Btn,
            ];
            for (int i = 0; i < numButtons.Length; i++) {
                int num = i;
                numButtons[i].Click += (_, _) => NumberButtonClicked(num);
            }

            dotBtn.Click += DotBtn_Click;

            // OPERATOR BUTTONS
            Button[] opButtons = [
                addBtn, subBtn, mulBtn, divideBtn,    
            ];
            foreach (var opBtn in opButtons) {
                opBtn.Click += OpBtn_Click;
            }

            // Memory Clear
            memAddBtn.Click += MemAddBtn_Click;
            memCallBtn.Click += MemCallBtn_Click;
            memClearBtn.Click += MemClearBtn_Click;
            memSaveBtn.Click += MemSaveBtn_Click;

            // FUNCTION BUTTONS
            cBtn.Click += (_, _) => ClearCal();
            ceBtn.Click += CeBtn_Click;
            toggleSignBtn.Click += ToggleSignBtn_Click;
            oneOverXBtn.Click += OneOverXBtn_Click;
            percentBtn.Click += PercentBtn_Click;
            sqrtBtn.Click += SqrtBtn_Click;

            backspaceBtn.Click += BackspaceBtn_Click;

            // EQUALS BUTTON
            equalBtn.Click += EqualBtn_Click;

            // Toolstrip
            helpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;
        }

        private void HelpToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            var text = @"
                Input & editing
                    Digits: 0–9 -> enter numbers.
                    Decimal: . —> use to type fractional numbers (e.g., 3.14).
                    Backspace —> remove last digit.
                    CE -> clears the current number you are typing only.
                    C —> resets the entire calculation and clears entries.

                Basic operations
                    + − × ÷ —> standard arithmetic operators.
                    = —> evaluate the current expression.
                    +/- —> toggle sign of the current entry (positive <-> negative).
                    % —> percent: divide value by 100

                Memory
                    M+ —> add current value to memory.
                    MS —> save current value to memory.
                    MR —> recall value from memory.
                    MC —> clear memory.

                Advanced functions
                    sqrt —> square root.
                    1/x —> reciprocal (divide 1 by the current value).
            ";

            MessageBox.Show(text, "Calculator Helper");
        }

        #region Memory

        private void MemSaveBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (double.TryParse(calBox.Text, out var num))
            {
                _calculator.MemorySave(num);
            }
        }

        private void MemClearBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;
            _calculator.MemoryClear();
        }

        private void MemCallBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            var memValue = _calculator.MemoryRecall();
            if (memValue == null) return;

            calBox.Text = memValue.ToString();
        }

        private void MemAddBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (double.TryParse(calBox.Text, out var num))
            {
                _calculator.MemoryAdd(num);
            }
        }

        #endregion

        #region Function Button
        private void CeBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear)
            {
                ClearCal();
                return;
            }

            if (!_calculator.Evaluated)
            {
                calBox.Text = "0";
            }
            else
            {
                _calculator.ClearTillLast();
                bufferBox.Text = string.Empty;
                calBox.Text = "0";
            }

        }
        private void ClearCal()
        {
            calBox.Text = "0";
            bufferBox.Text = string.Empty;
            _calculator.ResetBuffer();
            _requireClear = false;
        }
        private void ToggleSignBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (_calculator.Evaluated)
            {
                var lastResult = calBox.Text;
                ClearCal();
                calBox.Text = lastResult;
            }

            if (calBox.Text[0] == '-')
            {
                calBox.Text = calBox.Text[1..];
            }else
            {
                calBox.Text = '-' + calBox.Text;
            }
        }

        private void SqrtBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (double.TryParse(calBox.Text, out var num))
            {
                if (num < 0)
                {
  
                    MessageBox.Show("Cannot take the square root of a negative",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                var newVal = Math.Sqrt(num);
                calBox.Text = newVal.ToString();
            }
        }

        private void PercentBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (double.TryParse(calBox.Text, out var num))
            {
                var newVal = num / 100.0;
                calBox.Text = newVal.ToString();
            }
        }

        private void OneOverXBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (double.TryParse(calBox.Text, out var num))
            {
                if (num == 0)
                {
                    MessageBox.Show("Divided by zero error",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var newVal = 1.0 / num;
                calBox.Text = newVal.ToString();
            }
        }

        private void BackspaceBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (calBox.Text.Length <= 1)
            {
                calBox.Text = "0";
                return;
            }

                if (_calculator.Evaluated)
                    return;

            calBox.Text = calBox.Text[..^1];

        }

        #endregion

        #region Number Button
        private void DotBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (_calculator.Evaluated)
            {
                var lastResult = calBox.Text;
                ClearCal();
                calBox.Text = lastResult;
            }

            if (!calBox.Text.Contains('.'))
            {
                calBox.Text += ".";
            }
        }

        private void NumberButtonClicked(int i)
        {
            if (_requireClear) return;



            if (_calculator.Evaluated)
            {
                ClearCal();
                calBox.Text = i.ToString();
                _allowAddOp = true;
                return;
            }


            if (calBox.Text == "0") { 
                calBox.Text = i.ToString();
                _allowAddOp = true;
                return;
            }

            calBox.Text += i.ToString();
            _allowAddOp = true;

        }

        #endregion

        #region Operator Button
        private void OpBtn_Click(object? sender, EventArgs e)
        {
            if (_requireClear) return;

            if (sender is not Button btn)
                return;

            var op = btn.Text[0] switch
            {
                '+' => Calculator.Operator.Plus,
                '-' => Calculator.Operator.Minus,
                '*' => Calculator.Operator.Mul,
                '/' => Calculator.Operator.Divide,
                _ => throw new NotImplementedException()
            };


            if (!_allowAddOp)
            {
                _calculator.ModifyNextOperator(op);
                bufferBox.Text = _calculator.DisplayBufferString;

                return;
            }

            if (_calculator.Evaluated)
            {
                _calculator.ResetBuffer();
            }

            
            if (double.TryParse(calBox.Text, out var num))
            {
                try
                {
                    _calculator.AddToCalc(op, num);
                    // Reset
                    bufferBox.Text = _calculator.DisplayBufferString;
                    calBox.Text = "0";

                    _allowAddOp = false;
                }
                catch (DivideByZeroException) {
                    MessageBox.Show("Divided by zero error",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }


            }
        }

        #endregion

        private void EqualBtn_Click(object? sender, EventArgs e)
        {
            void UpdateCalcBox()
            {
                try
                {
                    calBox.Text = _calculator.Evaluate().ToString();
                    bufferBox.Text = _calculator.DisplayBufferString;
                    bufferBox.Text += "=";
                }catch (DivideByZeroException)
                {
                    MessageBox.Show("Divided by zero error, clear before continue", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                    _requireClear = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} Clear before continue", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );

                    _requireClear = true;
                }
               
            }
           

            if (_calculator.Evaluated)
            {
                UpdateCalcBox();
                return;
            }

            if (double.TryParse(calBox.Text, out var num))
            {
                try
                {
                    _calculator.AddToCalc(Calculator.Operator.Noop, num);
                    UpdateCalcBox();
                }
                catch (DivideByZeroException) {
                    MessageBox.Show("Divided by zero error",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                    );
                }
            }
        }

    }
}
