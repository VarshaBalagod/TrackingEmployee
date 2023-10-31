using BLL;
using DAL.DAO;
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
    public partial class frmSalaryList : Form
    {
        public frmSalaryList()
        {
            InitializeComponent();
        }
        #region declarations
        frmSalary frmSalary = new frmSalary();
        SalaryDTO dtoSalary = new SalaryDTO();
        SalaryDetailsDTO dtoSalaryDetail = new SalaryDetailsDTO();
        bool combofull = false;
        #endregion

        #region functions
        void fillGrid()
        {
            dtoSalary = SalaryBLL.GetAllSalary();
            if (!UserStatic.isAdmin)
                dtoSalary.SalaryDetailsDTOs = dtoSalary.SalaryDetailsDTOs.Where(x => x.EmpId == UserStatic.EmployeeId).ToList();
            dgvEmployeeList.DataSource = dtoSalary.SalaryDetailsDTOs;
            dgvEmployeeList.Columns[0].HeaderText = "Employee Number";
            dgvEmployeeList.Columns[1].HeaderText = "Employee Name";
            dgvEmployeeList.Columns[2].HeaderText = "Employee Surname";
            dgvEmployeeList.Columns[3].HeaderText = "Salary Amount";
            dgvEmployeeList.Columns[4].HeaderText = "Salary Month";
            dgvEmployeeList.Columns[5].HeaderText = "Salary Year";
            dgvEmployeeList.Columns[6].Visible = false;
            dgvEmployeeList.Columns[7].Visible = false;
            dgvEmployeeList.Columns[8].Visible = false;
            dgvEmployeeList.Columns[9].Visible = false;
            dgvEmployeeList.Columns[10].Visible = false;
            dgvEmployeeList.Columns[11].Visible = false;
            dgvEmployeeList.Columns[12].Visible = false;
            dgvEmployeeList.Columns[13].Visible = false;
        }

        void fillComboBox()
        {
            dtoSalary = SalaryBLL.GetAllSalary();
            cbDepartmentName.DataSource = dtoSalary.Departments;
            cbDepartmentName.DisplayMember = "DepartmentName";
            cbDepartmentName.ValueMember = "DepID";
            cbDepartmentName.SelectedIndex = -1;
            if (dtoSalary.Departments.Count > 0)
                combofull = true;
            cbPosition.DataSource = dtoSalary.Positions;
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "PosID";
            cbPosition.SelectedIndex = -1;
            cbMonth.DataSource = dtoSalary.Months;
            cbMonth.DisplayMember = "MonthName";
            cbMonth.ValueMember = "MonID";
            cbMonth.SelectedIndex = -1;           
        }

        void clearData()
        {
            txtEmpNumber.Text = "";
            txtEmpNumber.Clear();
            txtEmpName.Text = "";
            txtEmpName.Clear();
            txtEmpSurname.Text = "";
            txtEmpSurname.Clear();
            txtSalary.Text = "";
            txtSalary.Clear();
            combofull = false;
            rbMore.Checked = false;
            rbLess.Checked = false;
            rbEqual.Checked = false;
            fillComboBox();
            fillGrid();
        }

        #endregion


        #region formLoad
        private void frmSalaryList_Load(object sender, EventArgs e)
        {
            fillComboBox();
            fillGrid();
            if (!UserStatic.isAdmin)
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;               
                pnLeft.Visible = false;
                pnRight.Dock = DockStyle.Left;
                btnNew.Location = new Point(150, 12);
                btnClose.Location= new Point(300, 12);
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
            dtoSalaryDetail.EmployeeNumber = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[0].Value);
            dtoSalaryDetail.EmployeeName = dgvEmployeeList.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtoSalaryDetail.EmployeeSurname = dgvEmployeeList.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtoSalaryDetail.SalaryAmount = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[3].Value);
            dtoSalaryDetail.SalaryMonth = dgvEmployeeList.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtoSalaryDetail.SalaryYear = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[5].Value);
            dtoSalaryDetail.EmpId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[6].Value);
            dtoSalaryDetail.DepId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[7].Value);
            dtoSalaryDetail.PosId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[8].Value);
            dtoSalaryDetail.SalId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[9].Value);
            dtoSalaryDetail.MonthId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[10].Value);
            dtoSalaryDetail.OldSalary = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[13].Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SalaryDetailsDTO> list = dtoSalary.SalaryDetailsDTOs;
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
            if (txtYear.Text.Trim() != "")
                list = list.Where(x => x.SalaryYear == Convert.ToInt32(txtYear.Text)).ToList();
            if (cbMonth.SelectedIndex != -1)
                list = list.Where(x => x.MonthId == Convert.ToInt32(cbMonth.SelectedValue)).ToList();
            if (txtSalary.Text.Trim() != "")
            {
                if (rbMore.Checked)
                    list = list.Where(x => x.SalaryAmount > Convert.ToInt32(txtSalary.Text)).ToList();
                else if (rbLess.Checked)
                    list = list.Where(x => x.SalaryAmount < Convert.ToInt32(txtSalary.Text)).ToList();
                else
                    list = list.Where(x => x.SalaryAmount == Convert.ToInt32(txtSalary.Text)).ToList();
            }
            dgvEmployeeList.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.ExcelExport(dgvEmployeeList, "Salary");
            MessageBox.Show("File exported in excel. Check desire location.");
            this.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmSalary= new frmSalary();
            frmSalary._isUpdate = false;
            this.Hide();
            frmSalary.ShowDialog();
            this.Visible = true;
            fillComboBox();
            fillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoSalaryDetail.SalId == 0)
                MessageBox.Show("Please select record to update from table.");
            else
            {
                frmSalary = new frmSalary();
                frmSalary._isUpdate= true;
                frmSalary._dtoSalaryDetail= dtoSalaryDetail;
                this.Hide();
                frmSalary.ShowDialog();
                this.Visible = true;
                fillComboBox();
                fillGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete salary?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SalaryBLL.DeleteSalary(dtoSalaryDetail.SalId);
                MessageBox.Show("Salary deleted.");
                fillComboBox();
                fillGrid();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

      
    }
}
