using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.interfaces
{
    public interface IEmployee
    {
        string FullName { get; set; }
        decimal CurrentSalary { get; set; }
        decimal TotalPay { get; set; }
    }
}
