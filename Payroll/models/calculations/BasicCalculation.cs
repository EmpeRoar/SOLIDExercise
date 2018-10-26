using Payroll.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.models.calculations
{
    public class BasicCalculation : ICalculation
    {
        public Func<IEmployee, decimal> Formula
        {
            get
            {
                return (employee) =>
                {
                    return employee.CurrentSalary * 20;
                };
            }
        }
    }
}
