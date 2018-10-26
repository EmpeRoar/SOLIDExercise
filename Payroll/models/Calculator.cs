using Payroll.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.models
{
    public class Calculator : ICalculator
    {
        public decimal Execute(IEmployee employee, ICalculation calculation)
        {
            Func<IEmployee, decimal> calculate = calculation.Formula;
            return calculate(employee);
        }

    }
}
