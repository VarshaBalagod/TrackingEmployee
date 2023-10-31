using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;

namespace EmployeePersonalTracker
{
    public partial class frmEmployeeList : Form
    {
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        #region declarations
        frmEmployee frmEmployee = new frmEmployee();
        EmployeeDTO dtoEmployee = new EmployeeDTO();
        EmployeeDetailDTO dtoEmployeeDetail = new EmployeeDetailDTO();
        bool combofull = false;
        #endregion


        #region functions
        void fillDataGrid()
        {
            dtoEmployee = EmployeeBLL.GetAllEmployee();
            dgvEmployeeList.DataSource = dtoEmployee.Employees;
            dgvEmployeeList.Columns[0].Visible = false;
            dgvEmployeeList.Columns[1].Visible = false;
            dgvEmployeeList.Columns[2].Visible = false;
            dgvEmployeeList.Columns[3].HeaderText = "Employee Number";
            dgvEmployeeList.Columns[4].HeaderText = "Employee Password";
            dgvEmployeeList.Columns[5].HeaderText = "Employee Name";
            dgvEmployeeList.Columns[6].HeaderText = "Employee Surname";
            dgvEmployeeList.Columns[7].HeaderText = "Employee Image Path";
            dgvEmployeeList.Columns[8].HeaderText = "Employee Department Name";
            dgvEmployeeList.Columns[9].HeaderText = "EmployeePosition Name";
            dgvEmployeeList.Columns[10].HeaderText = "Employee Salary";
            dgvEmployeeList.Columns[11].HeaderText = "Employee Address";
            dgvEmployeeList.Columns[12].HeaderText = "isAdmin";
            dgvEmployeeList.Columns[13].HeaderText = "Employee Birthday";
            dgvEmployeeList.Columns[14].Visible = false;
        }

        void fillCombobox()
        {
            dtoEmployee = EmployeeBLL.GetAllEmployee();
            cbDepartmentName.DataSource = dtoEmployee.Departments;
            cbDepartmentName.DisplayMember = "DepartmentName";
            cbDepartmentName.ValueMember = "DepID";
            cbDepartmentName.SelectedIndex = -1;
            cbPosition.DataSource = dtoEmployee.Positions;
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "PosID";
            cbPosition.SelectedIndex = -1;
            if (dtoEmployee.Departments.Count > 0)
                combofull = true;
        }

        void clearData()
        {
            combofull = false;
            txtEmpNumber.Text = "";
            txtEmpNumber.Clear();
            txtEmpName.Text = "";
            txtEmpName.Clear();
            txtEmpSurname.Text = "";
            txtEmpSurname.Clear();
            fillCombobox();
            fillDataGrid();
        }
        #endregion

        #region formLoad
        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            fillCombobox();
        }
        #endregion


        #region buttonClick 
        private void cbDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentId = Convert.ToInt32(cbDepartmentName.SelectedValue);
                cbPosition.DataSource = dtoEmployee.Positions.Where(x => x.DepID == departmentId).ToList();
            }
        }

        private void dgvEmployeeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoEmployeeDetail.EmpId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[0].Value);
            dtoEmployeeDetail.DepId= Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[1].Value);
            dtoEmployeeDetail.PosId= Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[2].Value);
            dtoEmployeeDetail.EmployeeNumber= Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[3].Value);
            dtoEmployeeDetail.EmployeePassword = dgvEmployeeList.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtoEmployeeDetail.EmployeeName = dgvEmployeeList.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtoEmployeeDetail.EmployeeSurname = dgvEmployeeList.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtoEmployeeDetail.EmployeeImagePath = dgvEmployeeList.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtoEmployeeDetail.EmployeeSalary = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[10].Value);
            dtoEmployeeDetail.EmployeeAddress = dgvEmployeeList.Rows[e.RowIndex].Cells[11].Value.ToString();            
            dtoEmployeeDetail.isAdmin = Convert.ToBoolean(dgvEmployeeList.Rows[e.RowIndex].Cells[12].Value);
            dtoEmployeeDetail.EmployeeBirthday = Convert.ToDateTime(dgvEmployeeList.Rows[e.RowIndex].Cells[13].Value);
            dtoEmployeeDetail.EmployeeOldSalary = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[14].Value);
        }

        private void txtEmpNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EmployeeDetailDTO> list = dtoEmployee.Employees;
            if (txtEmpNumber.Text.Trim() != "")           
                list = list.Where(x => x.EmployeeNumber == Convert.ToInt32(txtEmpNumber.Text)).ToList();
            if (txtEmpName.Text.Trim() != "")
                list = list.Where(x => x.EmployeeName == txtEmpName.Text).ToList();
            if (txtEmpSurname.Text.Trim() != "")
                list = list.Where(x => x.EmployeeSurname == txtEmpSurname.Text).ToList();
            if (cbDepartmentName.SelectedIndex != -1)
                list = list.Where(x => x.DepId == Convert.ToInt32(cbDepartmentName.SelectedValue)).ToList();
            if (cbPosition.SelectedIndex != -1)
                list = list.Where(x => x.PosId == Convert.ToInt32(cbPosition.SelectedValue)).ToList();
            dgvEmployeeList.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.ExcelExport(dgvEmployeeList, "Employee");
            MessageBox.Show("File exported in excel. Check desire location.");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmEmployee = new frmEmployee();      
            this.Hide();
            frmEmployee.ShowDialog();
            this.Visible = true;
            clearData();
            fillDataGrid();
            fillCombobox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoEmployeeDetail.EmpId == 0)
                MessageBox.Show("Please select employee from table.");
            else
            {
                frmEmployee = new frmEmployee();
                frmEmployee._isUpdate = true;
                frmEmployee._dtoEmployeeDetail = dtoEmployeeDetail;
                this.Hide();
                frmEmployee.ShowDialog();
                this.Visible = true;
                clearData();
                fillDataGrid();
                fillCombobox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this employee?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EmployeeBLL.DeleteEmployee(dtoEmployeeDetail.EmpId);
                MessageBox.Show("Employee deleted.");
                clearData();
                fillCombobox();
                fillDataGrid();
            }
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

       
    }
}
