using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.interfaces
{
    public interface ICalculation
    {
        Func<decimal, decimal> Formula { get; }
    }
}
