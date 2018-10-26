using Payroll.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.models.calculations
{
    public class OvertimeCalculation : ICalculation
    {
        public Func<IEmployee, decimal> Formula
        {
            get
            {
                return (employee) =>
                {
                    return employee.CurrentSalary * 3;
                };
            }
        }
    }
}
