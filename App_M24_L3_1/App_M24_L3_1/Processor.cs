namespace App_M24_L3_1
{
    public class Calculator
    {
        private int _multiplicator;
        private decimal _basis;

        public Calculator(int multiplicator, decimal basis)
        {
            _multiplicator = multiplicator;
            _basis = basis;
        }

        public decimal Calc(decimal value)
        {
            return (value / _basis) * _multiplicator;
        }
    }

    public class Result
    {
        public decimal Value { get; set; }
        public string Desc { get; set; }
    }

    public class Processor
    {
        private Calculator _calculator;

        public Processor(Calculator calculator)
        {
            _calculator = calculator;
        }

        public Result Do(decimal value)
        {
            var result = _calculator.Calc(value);

            if (result < 10.0M)
            {
                return new Result
                {
                    Value = 0.0M,
                    Desc = "WRONG"
                };
            }

            return new Result
            {
                Value = result,
                Desc = "OK"
            };
        }
    }
}
