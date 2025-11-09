using System.Data;
using System.Linq.Expressions;

namespace Bai06
{
    internal class Calculator
    {
        public enum Operator
        {
            Noop,
            Plus = '+',
            Minus = '-',
            Mul = '*',
            Divide = '/',
        }

        private readonly DataTable _dataTable;
        private readonly List<(Operator, double)> _buffer;
        public string DisplayBufferString => GetDisplayBufferString();
        public bool Evaluated { get; private set; } = false;

        Operator _nextOperator = Operator.Noop;
        private double _lastResult = 0;
        double? _memoryValue = 0;


        public Calculator()
        {
            _dataTable = new DataTable();
            _buffer = [];
        }

        public void MemoryClear()
        {
            _memoryValue = null;
        }

        public void MemorySave(double value)
        {
            _memoryValue = value;
        }
        public void MemoryAdd(double value)
        {
            if (_memoryValue is null)
            {
                MemorySave(value);
                return;
            }
            _memoryValue += value;
        }
        public double? MemoryRecall()
        {
            return _memoryValue;
        }

        public void AddToCalc(Operator op, double num)
        {
            if (_nextOperator == Operator.Divide && num == 0)
            {
                throw new DivideByZeroException();
            } 

            _buffer.Add((_nextOperator, num));
            _nextOperator = op;
        }
        public void ResetBuffer()
        {
            _buffer.Clear();
            _lastResult = 0;
            _nextOperator = Operator.Noop;
            Evaluated = false;
        }
        public void ClearTillLast()
        {
            _lastResult = 0;
        }
        public void ModifyNextOperator(Operator newNext)
        {
            _nextOperator = newNext;
        }

        private string GetDisplayBufferString()
        {
            var expr = "";
            foreach (var (op, num) in _buffer)
            {
                if (op == Operator.Noop)
                {
                    expr += num;
                    continue;
                }

                expr += $"{(char)op}{num}";
            }
            if (_nextOperator != Operator.Noop)
            {
                expr += (char)_nextOperator;
            }
            return expr;
        }
        private string GetBufferString()
        {
            var expr = "";
            foreach (var (op, num) in _buffer)
            {
                if (op == Operator.Noop)
                {
                    expr += num.ToString("0.0########");
                    continue;
                }

                expr += $"{(char)op}{num:0.0########}";
            }
            if (_nextOperator != Operator.Noop)
            {
                expr += (char)_nextOperator;
            }
            return expr;
        }
        public double Evaluate()
        {
            if (Evaluated)
            {
                var lastOperation = _buffer.Last();
                if (lastOperation.Item1 != Operator.Noop)
                {
                    _buffer.Clear();

                    _buffer.Add((Operator.Noop, _lastResult));
                    _buffer.Add(lastOperation);
                }
            }

            var result = _dataTable.Compute(GetBufferString(), null);
            if (result is null)
                throw new Exception("NO numeric result");

            bool success = double.TryParse(result.ToString(),
                out var answer);

            if (success)
            {
                if (double.IsInfinity(answer))
                {
                    throw new DivideByZeroException("Divide by 0");
                }
            }
            else
            {
                throw new Exception("Not a number");
            }
            Evaluated = true;
            _lastResult = answer;
            return answer;
        }
    }
}
