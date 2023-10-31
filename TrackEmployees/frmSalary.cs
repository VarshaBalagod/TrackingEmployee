using BLL;
using DAL;
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
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        #region declarations
        SalaryDTO dtoSalary = new SalaryDTO();
        tbl_Salary tableSalary = new tbl_Salary();
        public SalaryDetailsDTO _dtoSalaryDetail = new SalaryDetailsDTO();
        public bool _isUpdate = false;
        bool combofull= false;
        int oldSalary = 0;
        #endregion


        #region functions
        void fillDataGrid()
        {
            dtoSalary = SalaryBLL.GetAllSalary();
            dgvEmployeeList.DataSource = dtoSalary.Employees;
            dgvEmployeeList.Columns[0].Visible = false;
            dgvEmployeeList.Columns[1].Visible = false;
            dgvEmployeeList.Columns[2].Visible = false;
            dgvEmployeeList.Columns[3].HeaderText = "Employee Number";
            dgvEmployeeList.Columns[4].Visible = false;
            dgvEmployeeList.Columns[5].HeaderText = "Employee Name";
            dgvEmployeeList.Columns[6].HeaderText = "Employee Surname";
            dgvEmployeeList.Columns[7].Visible = false;
            dgvEmployeeList.Columns[8].Visible = false;
            dgvEmployeeList.Columns[9].Visible = false;
            dgvEmployeeList.Columns[10].Visible = false;
            dgvEmployeeList.Columns[11].Visible = false;
            dgvEmployeeList.Columns[12].Visible = false;
            dgvEmployeeList.Columns[13].Visible = false;
            dgvEmployeeList.Columns[14].Visible = false;
        }

        void fillCombobox()
        {
            dtoSalary = SalaryBLL.GetAllSalary();
            cbDepartmentName.DataSource = dtoSalary.Departments;
            cbDepartmentName.DisplayMember = "DepartmentName";
            cbDepartmentName.ValueMember = "DepID";
            cbDepartmentName.SelectedIndex = -1;
            cbPosition.DataSource = dtoSalary.Positions;
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "PosID";
            cbPosition.SelectedIndex = -1;
            cbMonth.DataSource = dtoSalary.Months;
            cbMonth.DisplayMember = "MonthName";
            cbMonth.ValueMember = "MonID";
            cbMonth.SelectedIndex = -1;
            if (dtoSalary.Departments.Count > 0)
                combofull = true;
        }

        void ClearData()
        {
            txtEmpNumber.Text = "";
            txtEmpNumber.Clear();
            txtEmpName.Text = "";
            txtEmpName.Clear();
            txtEmpSurName.Text = "";
            txtEmpSurName.Clear();
            txtSalary.Text = "";
            txtSalary.Clear();
            combofull = false;
            fillCombobox();
            fillDataGrid();
        }
        #endregion

        #region formLoad
        private void frmSalary_Load(object sender, EventArgs e)
        {
            if (!_isUpdate)
                fillDataGrid();
            fillCombobox();          
            if (_isUpdate)
            {
                btnSave.Text = "Update";
                panel3.Visible = false;
                txtEmpNumber.Text = _dtoSalaryDetail.EmployeeNumber.ToString();
                txtEmpName.Text = _dtoSalaryDetail.EmployeeName;
                txtEmpSurName.Text = _dtoSalaryDetail.EmployeeSurname;
                txtSalary.Text = _dtoSalaryDetail.SalaryAmount.ToString();
                txtYear.Text = _dtoSalaryDetail.SalaryYear.ToString();
                cbMonth.SelectedValue = _dtoSalaryDetail.MonthId;              
            }
        }
        #endregion


        #region buttonClick 
        private void cbDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentId = Convert.ToInt32(cbDepartmentName.SelectedValue);
                cbPosition.DataSource = dtoSalary.Positions.Where(x => x.DepID == departmentId).ToList();
            }
        }

        private void dgvEmployeeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpNumber.Text = dgvEmployeeList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmpName.Text = dgvEmployeeList.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmpSurName.Text = dgvEmployeeList.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtYear.Text=DateTime.Today.Year.ToString();
            txtSalary.Text= dgvEmployeeList.Rows[e.RowIndex].Cells[10].Value.ToString();
            tableSalary.EmpID = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[0].Value);
            oldSalary = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[10].Value);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Please enter salary.");
            else if (txtYear.Text.Trim() == "")
                MessageBox.Show("Please enter year.");
            else if (cbMonth.SelectedIndex == -1)
                MessageBox.Show("Please select month.");
            else if (txtEmpNumber.Text.Trim() == "")
                MessageBox.Show("Please enter employee number.");
            else
            {
                bool controlSal = false;
                if (!_isUpdate)
                {
                    if (tableSalary.EmpID == 0)
                        MessageBox.Show("Please Select an employee from table.");
                    else
                    {
                        tbl_Salary tableSalaryAdd = new tbl_Salary();
                        tableSalaryAdd.Year = Convert.ToInt32(txtYear.Text);
                        tableSalaryAdd.MonthID = Convert.ToInt32(cbMonth.SelectedValue);
                        tableSalaryAdd.Amount = Convert.ToInt32(txtSalary.Text);
                        tableSalaryAdd.EmpID = tableSalary.EmpID;
                        if (tableSalaryAdd.Amount > oldSalary)
                            controlSal = true;
                        SalaryBLL.AddSalaryAmmount(tableSalaryAdd, controlSal);
                        MessageBox.Show("Salary added.");
                        cbMonth.SelectedIndex = -1;
                        ClearData();
                        tableSalaryAdd = new tbl_Salary();
                    }
                }
                else if (_isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure?","Warning",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        tbl_Salary tableSalaryUpdate = new tbl_Salary();
                        tableSalaryUpdate.SalID = _dtoSalaryDetail.SalId;
                       // tableSalaryUpdate.EmpID = _dtoSalaryDetail.EmpId;
                        if (Convert.ToInt32(txtEmpNumber.Text) != _dtoSalaryDetail.EmployeeNumber)
                            tableSalaryUpdate.EmpID = tableSalary.EmpID;
                        else
                            tableSalaryUpdate.EmpID = _dtoSalaryDetail.EmpId;
                        tableSalaryUpdate.Year = Convert.ToInt32(txtYear.Text);
                        tableSalaryUpdate.MonthID = Convert.ToInt32(cbMonth.SelectedValue);
                        tableSalaryUpdate.Amount = Convert.ToInt32(txtSalary.Text);
                       
                        
                        if(tableSalaryUpdate.Amount > _dtoSalaryDetail.SalaryAmount)
                            controlSal = true;

                        SalaryBLL.UpdateSalary(tableSalaryUpdate, controlSal);
                        MessageBox.Show("Salary Updated.");
                        cbMonth.SelectedIndex = -1;
                        ClearData();
                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

       
    }
}
