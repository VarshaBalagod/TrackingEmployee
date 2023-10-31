using BLL;
using DAL.DTO;
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
    public partial class frmEmployeeTracker : Form
    {
        public frmEmployeeTracker()
        {
            InitializeComponent();
        }

        #region form load
        private void frmEmployeeTracker_Load(object sender, EventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                btnDepartment.Visible = false;
                btnPosition.Visible = false;
                btnSalary.Location = new Point(227, 184);
                this.Size = new Size(455, 489);
                btnExit.Size = new Size(133, 59);
                btnExit.Location = new Point(24, 376);
                btnLogOut.Size = new Size(152, 59);
                btnLogOut.Location = new Point(227, 376);
            }
        }
        #endregion

        #region Button Clicks
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (UserStatic.isAdmin)
            {
                frmEmployeeList frmEmpolyeelist = new frmEmployeeList();
                this.Hide();
                frmEmpolyeelist.ShowDialog();
                this.Visible = true;
            }
            else
            {
                EmployeeDTO dtoEmployee = EmployeeBLL.GetAllEmployee();
                EmployeeDetailDTO dtoEmployeeDetil = dtoEmployee.Employees.First(x => x.EmpId == UserStatic.EmployeeId);
                frmEmployee frmEmployee = new frmEmployee();
                frmEmployee._dtoEmployeeDetail = dtoEmployeeDetil;
                frmEmployee._isUpdate = true;
                this.Hide();
                frmEmployee.ShowDialog();
                this.Visible = true;

            }
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            frmTaskList frmTaskList = new frmTaskList();
            this.Hide();
            frmTaskList.ShowDialog();
            this.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalaryList frmSalaryList = new frmSalaryList();
            this.Hide();
            frmSalaryList.ShowDialog();
            this.Visible = true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            frmPermissionList frmPermissionList = new frmPermissionList();
            this.Hide();
            frmPermissionList.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartmentList frmDepartmentList = new frmDepartmentList();
            this.Hide();
            frmDepartmentList.ShowDialog();
            this.Visible = true;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmPositionList frmPositionList = new frmPositionList();
            this.Hide();
            frmPositionList.ShowDialog();
            this.Visible = true;
        }
        
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmEmployeeTracker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
