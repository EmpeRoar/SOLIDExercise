using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.interfaces
{
    public interface ICalculator
    {
        decimal Execute(decimal salary, ICalculation calculation);
    }
}
