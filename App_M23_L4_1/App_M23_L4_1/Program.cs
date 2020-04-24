using System;

namespace App_M23_L4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new A(3.0);
            var worker = new B(calculator);
            worker.DoWork();
            var processor = new C(calculator);
            processor.Process();
        }
    }

    class A
    {
        private double _factor;

        public A(double factor)
        {
            _factor = factor;
        }

        public double Calc()
        {
            return _factor * Math.Sqrt(133);
        }
    }

    class B
    {
        private A _calculator;

        public B(A calculator)
        {
            _calculator = calculator;
        }

        public void DoWork()
        {
            var x = _calculator.Calc();
            Console.WriteLine(x);
        }
    }

    class C
    {
        private A _calculator;

        public C(A calculator)
        {
            _calculator = calculator;
        }

        public void Process()
        {
            var x = _calculator.Calc();
            Console.WriteLine($"Processing {x}...");
        }
    }
}
