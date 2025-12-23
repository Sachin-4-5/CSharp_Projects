using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public Decimal Add(Decimal a, Decimal b) => a + b;
        public Decimal Subtract(Decimal a, Decimal b) => a - b;
        public Decimal Multiply(Decimal a, Decimal b) => a * b;
        public Decimal Divide(Decimal a, Decimal b) => a / b;
    }
}
