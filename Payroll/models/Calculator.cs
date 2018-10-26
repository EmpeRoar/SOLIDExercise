using Payroll.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.models
{
    public class Calculator : ICalculator
    {
        public decimal Execute(decimal salary, ICalculation calculation)
        {
            Func<decimal, decimal> calculate = calculation.Formula;
            return calculate(salary);
        }

    }
}
