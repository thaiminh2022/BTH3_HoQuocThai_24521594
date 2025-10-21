using System.Data;

namespace Bai06
{
    public partial class FormBai6 : Form
    {
        bool requestNewBuffer = false;
        bool requireClearAll = false;

        double? memory = null;

        public FormBai6()
        {
            InitializeComponent();

            backspaceBtn.Click += BackspaceBtn_Click;


            calBox.Text = string.Empty;
            n1Btn.Click += AddToCalBox;
            n2Btn.Click += AddToCalBox;
            n3Btn.Click += AddToCalBox;
            n4Btn.Click += AddToCalBox;
            n5Btn.Click += AddToCalBox;
            n6Btn.Click += AddToCalBox;
            n7Btn.Click += AddToCalBox;
            n8Btn.Click += AddToCalBox;
            n9Btn.Click += AddToCalBox;
            n0Btn.Click += AddToCalBox;
            dotBtn.Click += AddDot;

            addBtn.Click += AddOperator;
            subBtn.Click += AddOperator;
            mulBtn.Click += AddOperator;
            divideBtn.Click += AddOperator;

            equalBtn.Click += EvaluateExpression;
            sqrtBtn.Click += SqrtBtn_Click;
            oneOverXBtn.Click += OneOverXBtn_Click;
            percentBtn.Click += PercentBtn_Click;
            cBtn.Click += CBtn_Click;
            ceBtn.Click += CeBtn_Click;
            toggleSignBtn.Click += ToggleSignBtn_Click;

            memClearBtn.Click += MemClearBtn_Click;
            memCallBtn.Click += MemCallBtn_Click;
            memSaveBtn.Click += MemSaveBtn_Click;
            memAddBtn.Click += MemAddBtn_Click;

        }

        private void MemAddBtn_Click(object? sender, EventArgs e)
        {
            if (memory is not null)
            {
                if (double.TryParse(calBox.Text, out var n))
                {
                    memory += n;
                }
            }
            else
            {
                MessageBox.Show("No memory");
            }
        }

        private void MemSaveBtn_Click(object? sender, EventArgs e)
        {
            if (double.TryParse(calBox.Text, out var n))
            {
                memory = n;
            }
        }

        private void MemCallBtn_Click(object? sender, EventArgs e)
        {
            if (memory is not null)
            {
                calBox.Text = memory.ToString();
            }
            else
            {
                MessageBox.Show("No memory");
            }
        }

        private void MemClearBtn_Click(object? sender, EventArgs e)
        {
            memory = null;
        }

        private void CBtn_Click(object? sender, EventArgs e)
        {
            requireClearAll = false;
            calBox.Text = string.Empty;
            bufferBox.Text = string.Empty;
        }

        private void CeBtn_Click(object? sender, EventArgs e)
        {
            if (requireClearAll)
            {
                CBtn_Click(sender, e);
            }

            if (calBox.Text == string.Empty)
            {
                bufferBox.Text = string.Empty;
            }
            else
            {
                calBox.Text = string.Empty;
            }
        }

        private void ToggleSignBtn_Click(object? sender, EventArgs e)
        {
            if (requireClearAll) return;

            if (double.TryParse(calBox.Text, out var n))
            {
                calBox.Text = (-n).ToString();
            }
        }

        private void PercentBtn_Click(object? sender, EventArgs e)
        {
            if (requireClearAll) return;

            if (double.TryParse(calBox.Text, out var n))
            {
                if (requestNewBuffer)
                {
                    bufferBox.Text = string.Empty;
                    requestNewBuffer = false;
                }
                calBox.Text = (n / 100.0).ToString();
            }
        }

        private void OneOverXBtn_Click(object? sender, EventArgs e)
        {
            if (requireClearAll) return;

            if (double.TryParse(calBox.Text, out var n))
            {
                if (n == 0)
                {
                    MessageBox.Show("Cannot divide by 0");
                }
                else
                {
                    if (requestNewBuffer)
                    {
                        bufferBox.Text = string.Empty;
                        requestNewBuffer = false;
                    }
                    calBox.Text = (1.0 / n).ToString();
                }
            }

        }

        private void SqrtBtn_Click(object? sender, EventArgs e)
        {
            if (requireClearAll) return;

            if (double.TryParse(calBox.Text, out var n))
            {
                if (n < 0)
                {
                    MessageBox.Show("Cannot take square root of a negative number");
                }
                else
                {
                    if (requestNewBuffer)
                    {
                        bufferBox.Text = string.Empty;
                        requestNewBuffer = false;
                    }

                    calBox.Text = Math.Sqrt(n).ToString();
                }
            }
        }

        private void EvaluateExpression(object? sender, EventArgs e)
        {
            if (requestNewBuffer)
            {
                return;
            }


            bufferBox.Text += calBox.Text;
            calBox.Text = string.Empty;
            var expression = bufferBox.Text.Trim();

            try
            {
                var result = new DataTable().Compute(expression, null);
                if (result is null)
                {
                    requireClearAll = true;
                    throw new Exception("NO numeric result");
                }

                bool success = double.TryParse(result.ToString(),
                    out var answer);

                if (success)
                {
                    if (double.IsInfinity(answer))
                    {
                        requireClearAll = true;
                        throw new DivideByZeroException("Divide by 0");
                    }
                    calBox.Text = result.ToString();
                    requestNewBuffer = true;
                }
                else
                {
                    requireClearAll = true;
                    throw new Exception("Not a number");
                }



            }
            catch (Exception ex)
            {
                requireClearAll = true;
                MessageBox.Show($"Cannot evaluate: {ex.Message}");
            }
        }
        private void AddOperator(object? sender, EventArgs e)
        {
            if (requireClearAll) return;

            calBox.Text = calBox.Text.Trim();
            if (sender is null) return;

            if (sender is not Button btn)
                return;
            if (string.IsNullOrEmpty(calBox.Text)) return;
            if (calBox.Text == "0")
                return;

            var latestChar = calBox.Text.Last();
            if (char.IsDigit(latestChar))
            {
                if (requestNewBuffer)
                {
                    bufferBox.Text = string.Empty;
                    requestNewBuffer = false;
                }

                calBox.Text += btn.Text;
                bufferBox.Text += calBox.Text;
                calBox.Text = string.Empty;
            }

        }
        private void BackspaceBtn_Click(object? sender, EventArgs e)
        {
            if (requireClearAll) { return; }

            if (!string.IsNullOrEmpty(calBox.Text))
            {
                var nextLastIdx = calBox.Text.Length - 1;
                calBox.Text = calBox.Text[0..nextLastIdx];
            }
        }

        void AddDot(object? sender, EventArgs e)
        {
            if (requireClearAll) { return; }

            if (calBox.Text.Contains('.')) return;

            if (string.IsNullOrWhiteSpace(calBox.Text))
            {
                calBox.Text = "0.";
            }
            else
            {
                calBox.Text += ".";
            }
        }
        void AddToCalBox(object? sender, EventArgs args)
        {
            if (requireClearAll) { return; }

            calBox.Text = calBox.Text.Trim();
            if (sender is null) return;

            if (sender is not Button btn)
            {
                return;
            }

            if (calBox.Text == "0")
            {
                calBox.Text = btn.Text;
            }
            else
            {
                calBox.Text += btn.Text;
            }


        }

    }
}
