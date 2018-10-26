using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.interfaces
{
    public interface ICalculation
    {
        Func<IEmployee, decimal> Formula { get; }
    }
}
