using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1.Interfaces
{
    public class MessageBoxDisplayError : IDisplayError
    {
        public void Display(string errorMessage)
        {
            MessageBox.Show(
                errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
