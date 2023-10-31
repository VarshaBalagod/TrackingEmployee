using DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;

namespace EmployeePersonalTracker
{
    public partial class frmPermissionList : Form
    {
        public frmPermissionList()
        {
            InitializeComponent();
        }
        #region declarations
        frmPermission frmPermission = new frmPermission();
        PermissionDTO dtoPermission = new PermissionDTO();
        PermissionDetailDTO dtoPermissionDetail = new PermissionDetailDTO();
        bool combofull = false;
        #endregion

        #region functions
        void fillDataGrid()
        {
            dtoPermission = PermissionBLL.GetAllPermission();
            if (!UserStatic.isAdmin)
                dtoPermission.PermissionDetails = dtoPermission.PermissionDetails.Where(x => x.EmpId == UserStatic.EmployeeId).ToList();
            dgvEmployeeList.DataSource = dtoPermission.PermissionDetails;
            dgvEmployeeList.Columns[0].HeaderText = "Employee Number";
            dgvEmployeeList.Columns[1].HeaderText = "Employee Name";
            dgvEmployeeList.Columns[2].HeaderText = "Employee Surname";
            dgvEmployeeList.Columns[3].HeaderText = "Start Date";
            dgvEmployeeList.Columns[4].HeaderText = "End Date";
            dgvEmployeeList.Columns[5].HeaderText = "State Name";
            dgvEmployeeList.Columns[6].HeaderText = "Explaination";
            dgvEmployeeList.Columns[7].HeaderText = "Day Amount";
            dgvEmployeeList.Columns[8].Visible = false;
            dgvEmployeeList.Columns[9].Visible = false;
            dgvEmployeeList.Columns[10].Visible = false;
            dgvEmployeeList.Columns[11].Visible = false;
            dgvEmployeeList.Columns[12].Visible = false;
        }

        void fillCombobox()
        {
            dtoPermission = PermissionBLL.GetAllPermission();
            cbDepartmentName.DataSource = dtoPermission.Departments;
            cbDepartmentName.DisplayMember = "DepartmentName";
            cbDepartmentName.ValueMember = "DepID";
            cbDepartmentName.SelectedIndex = -1;

            cbPosition.DataSource = dtoPermission.Positions;
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "PosID";
            cbPosition.SelectedIndex = -1;

            if (dtoPermission.Departments.Count > 0)
                combofull = true;
        }

        void clearData()
        {
            combofull = false;
            txtEmpNumber.Text = "";
            txtEmpNumber.Clear();
            txtEmpName.Text = "";
            txtEmpName.Clear();
            txtEmpNumber.Text = "";
            txtEmpName.Clear();
            txtPermisionAmount.Text = "";
            txtPermisionAmount.Clear();
            rbEndDate.Checked = false;
            rbStartDate.Checked = false;
            dtStartDate.Value = DateTime.Today;
            dtFinishdate.Value = DateTime.Today;
            fillCombobox();
            fillDataGrid();
        }
        #endregion

        #region formLoad
        private void frmPermissionList_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            fillCombobox();
            if (!UserStatic.isAdmin)
            {
                pnLeft.Visible = false;
                pnRight.Dock = DockStyle.Left;
                btnApprove.Visible = false;
                btnDisApprove.Visible = false;
                btnDelete.Visible = false;
                btnNew.Location = new Point(100, 12);
                btnUpdate.Location = new Point(200, 12);
                btnClose.Location = new Point(300, 12);
                this.Size = new Size(637, 513);
            }
        }
        #endregion

        #region buttonClick
        private void cbDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentId = Convert.ToInt32(cbDepartmentName.SelectedValue);
                cbPosition.DataSource = dtoPermission.Positions.Where(x => x.DepID == departmentId).ToList();
            }
        }

        private void dgvEmployeeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoPermissionDetail.perId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[12].Value);
            dtoPermissionDetail.PermissionSartDate = Convert.ToDateTime(dgvEmployeeList.Rows[e.RowIndex].Cells[3].Value);
            dtoPermissionDetail.PermissionEndDate = Convert.ToDateTime(dgvEmployeeList.Rows[e.RowIndex].Cells[4].Value);
            dtoPermissionDetail.PermissionExplaination = dgvEmployeeList.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtoPermissionDetail.PermissionDay = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[7].Value);
            dtoPermissionDetail.EmployeeNumber = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[0].Value);
            dtoPermissionDetail.PStateId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[8].Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PermissionDetailDTO> list = dtoPermission.PermissionDetails;
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
            if (rbStartDate.Checked)
                list = list.Where(x => x.PermissionSartDate > dtStartDate.Value &&
                x.PermissionSartDate < dtFinishdate.Value).ToList();
            if (rbEndDate.Checked)
                list = list.Where(x => x.PermissionEndDate > dtStartDate.Value &&
                x.PermissionEndDate < dtFinishdate.Value).ToList();
            if (txtPermisionAmount.Text.Trim() != "")
                list = list.Where(x => x.PermissionDay == Convert.ToInt32(txtPermisionAmount.Text)).ToList();
            dgvEmployeeList.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.ExcelExport(dgvEmployeeList, "Permission");
            MessageBox.Show("File exported in excel. Check desire location.");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePermission(dtoPermissionDetail.perId, PermissionState.Approved);
            MessageBox.Show("Approved");
            fillDataGrid();
            fillCombobox();
        }

        private void btnDisApprove_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePermission(dtoPermissionDetail.perId, PermissionState.Disapproved);
            MessageBox.Show("Disapproved");
            fillDataGrid();
            fillCombobox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPermission = new frmPermission();
            frmPermission._isUpdate = false;
            this.Hide();
            frmPermission.ShowDialog();
            this.Visible = true;
            clearData();
            fillDataGrid();
            fillCombobox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoPermissionDetail.perId == 0)
                MessageBox.Show("Please select a permission from table.");
            if (dtoPermissionDetail.PStateId == PermissionState.Approved || dtoPermissionDetail.PStateId == PermissionState.Disapproved)
                MessageBox.Show("You can not update approved and disapproved permission.");
            else
            {
                frmPermission._isUpdate = true;
                frmPermission._dtoPermissionDetail = dtoPermissionDetail;
                this.Hide();
                frmPermission.ShowDialog();
                this.Visible = true;
                clearData();
                fillDataGrid();
                fillCombobox();
            }           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dtoPermissionDetail.PStateId.ToString());
            DialogResult result = MessageBox.Show("Are you sure to delete this permission? for employee number- "
                  + dtoPermissionDetail.EmployeeNumber, "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dtoPermissionDetail.PStateId == PermissionState.Approved || dtoPermissionDetail.PStateId == PermissionState.Disapproved)
                    MessageBox.Show("You can not delete approved and disapproved permission.");
                else
                {
                    PermissionBLL.DeletePermission(dtoPermissionDetail.perId);
                    MessageBox.Show("Permission was deleted.");
                    clearData();
                    fillCombobox();
                    fillDataGrid();
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
