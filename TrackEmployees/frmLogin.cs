using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePersonalTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            frmEmployeeTracker frmEmployeeTracker = new frmEmployeeTracker();
            this.Hide();
            frmEmployeeTracker.ShowDialog();
            */
            if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Please enter employee number.");
            else if (txtUserNumber.Text.Trim() == "")
                MessageBox.Show("Please enter password.");
            else
            {
                List<tbl_Employee> listEmployee = EmployeeBLL.GetEmployee(Convert.ToInt32(txtUserNumber.Text), txtPassword.Text);
                if (listEmployee.Count == 0)
                {
                    MessageBox.Show("Given user - " + txtUserNumber.Text + " and password " + txtPassword.Text + " does not match.");
                    txtPassword.Text = "";
                    txtPassword.Clear();
                    txtUserNumber.Text = "";
                    txtUserNumber.Clear();
                }
                else
                {
                    tbl_Employee tableEmployee = new tbl_Employee();
                    tableEmployee = listEmployee.First();
                    UserStatic.EmployeeId = tableEmployee.EmpID;
                    UserStatic.EmployeeNumber = tableEmployee.EmployeeNumber;
                    UserStatic.isAdmin = tableEmployee.IsAdmin;
                    frmEmployeeTracker frmEmployeeTracker = new frmEmployeeTracker();
                    this.Hide();
                    frmEmployeeTracker.ShowDialog();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
    }
}
