using Payroll.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.models.calculations
{
    public class HazardPayCalculation : ICalculation
    {
        public Func<decimal, decimal> Formula
        {
            get
            {
                return (salary) =>
                {
                    return salary / 2;
                };
            }
        }
    }
}
