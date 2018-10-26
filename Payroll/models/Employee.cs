using Payroll.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.models
{
    public class Employee : IEmployee
    {
        public string FullName { get; set; }
        public decimal CurrentSalary { get; set; }
        public decimal TotalPay { get; set; }
       
    }
}
