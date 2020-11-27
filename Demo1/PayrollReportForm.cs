using Demo1.DAL;
using Demo1.Models;
using System;
using System.Windows.Forms;

namespace Demo1
{
    public partial class PayrollReportForm : Form
    {
        private Payroll _payroll;
        private IDisplayError _displayError;

        public PayrollReportForm(IDisplayError displayError) 
        {
            InitializeComponent();

            btCalculatePay.Enabled = false;
            _payroll = new Payroll();
            _displayError = displayError;
        }

        private void btCalculatePay_Click(object sender, EventArgs e)
        {
            if(_payroll.Emp != null)
            {
                _payroll.CalculatePay();
                tbPay.Text = string.Format("{0:F2} vnd", _payroll.Pay);
            }
            else
            {
                _displayError.Display("Please search for the employee first");
            }
        }

        private void btSearchEmp_Click(object sender, EventArgs e)
        {
            if(tbEmpCode.TextLength != 0)
            {
                try
                {
                    int id = int.Parse(tbEmpCode.Text);
                    //get employee from data layer
                    Employee employee = InMemoryEmployeeDal.GetEmployeeById(id);
                    
                    if (employee == null)
                        _displayError.Display("Cannot find Employee!");
                    else
                    {
                        _payroll.Emp = employee;
                        //presents data to form controls
                        tbEmpAge.Text = employee.Age.ToString();
                        tbEmpName.Text = employee.Name;
                        tbEmpCode.Text = employee.Id.ToString();
                        btCalculatePay.Enabled = true;
                    }
                }
                catch(Exception ex)
                {
                    _displayError.Display(ex.Message);
                }
            }
            else
            {
                btCalculatePay.Enabled = false;
                _displayError.Display("Please search employee first!");
            }
        }
    }
}
