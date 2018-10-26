using Payroll.models;
using Payroll.models.calculations;
using System;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee driver = new Driver();
            driver.CurrentSalary = 300;
            driver.FullName = "Julius Bacosa";
            

            Calculator calculator = new Calculator();
            var BasicCalculation = calculator.Execute(driver, new BasicCalculation());
            var HolidayCalculation = calculator.Execute(driver, new HolidayCalculation());
            var OvertimeCalculation = calculator.Execute(driver, new OvertimeCalculation());
            var HazardPayCalculation = calculator.Execute(driver, new HazardPayCalculation());

            driver.TotalPay = BasicCalculation + HolidayCalculation + OvertimeCalculation + HazardPayCalculation;

            Console.WriteLine($"P{BasicCalculation}: P{HolidayCalculation}: P{OvertimeCalculation}: P{HazardPayCalculation}, Total Pay: {driver.TotalPay}");

            Console.ReadLine();
        }
    }
}
