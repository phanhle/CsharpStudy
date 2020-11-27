using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Models
{
    //contains data and logic for PayrollReportForm
    public class Payroll
    {
        public Employee Emp { get; set; }
        public decimal Pay { get; private set; }

        public void CalculatePay()
        {
            if(Emp != null)
            {
                decimal payRate = Emp.PayRate;
                Pay = decimal.Multiply(_basePay, payRate);
            }
        }

        private readonly decimal _basePay = 10000M;
        private decimal _pay;
    }
}
