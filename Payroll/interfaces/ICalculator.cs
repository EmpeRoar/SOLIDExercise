using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.interfaces
{
    public interface ICalculator
    {
        decimal Execute(IEmployee employee, ICalculation calculation);
    }
}
