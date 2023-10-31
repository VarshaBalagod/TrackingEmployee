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
using DAL.DAO;
using DAL.DTO;

namespace EmployeePersonalTracker
{
    public partial class frmTaskList : Form
    {
        public frmTaskList()
        {
            InitializeComponent();
        }

        #region declarations
        frmTask frmTask = new frmTask();
        TaskDTO dtoTask = new TaskDTO();   
        TaskDetailDTO dtoTaskDetail= new TaskDetailDTO();        
        bool combofull = false;
        #endregion


        #region functions
        void fillDataGrid()
        {
            dtoTask = TaskBLL.GetAllTask();
            if (!UserStatic.isAdmin)
                dtoTask.TaskDetail = dtoTask.TaskDetail.Where(x => x.EmpId == UserStatic.EmployeeId).ToList();
            dgvEmployeeList.DataSource = dtoTask.TaskDetail;
            dgvEmployeeList.Columns[0].HeaderText = "Employee Number";
            dgvEmployeeList.Columns[1].HeaderText = "Employee Name";
            dgvEmployeeList.Columns[2].HeaderText = "Employee Surname";
            dgvEmployeeList.Columns[3].HeaderText = "Task Title";
            dgvEmployeeList.Columns[4].HeaderText = "Task State Name";
            dgvEmployeeList.Columns[5].HeaderText = "Task Content";
            dgvEmployeeList.Columns[6].HeaderText = "Task Start Date";
            dgvEmployeeList.Columns[7].HeaderText = "Task Delivery Date";
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
            dtoTask = TaskBLL.GetAllTask();
            cbDepartmentName.DataSource = dtoTask.Departments;
            cbDepartmentName.DisplayMember = "DepartmentName";
            cbDepartmentName.ValueMember = "DepID";
            cbDepartmentName.SelectedIndex = -1;

            cbPosition.DataSource = dtoTask.Positions;
            cbPosition.DisplayMember = "PositionName";
            cbPosition.ValueMember = "PosID";
            cbPosition.SelectedIndex = -1;
             
            cbTaskState.DataSource = dtoTask.TaskStatesName;
            cbTaskState.DisplayMember = "TaskStateName";
            cbTaskState.ValueMember = "TskstID";
            cbTaskState.SelectedIndex = -1;

            if(dtoTask.Departments.Count > 0) 
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
            rbDeliveryDate.Checked = false;
            rbStartDate.Checked = false;
            fillCombobox();
            fillDataGrid();
        }
        #endregion

        #region formLoad
        private void frmTaskList_Load(object sender, EventArgs e)
        {
            fillCombobox();
            fillDataGrid();
            if (!UserStatic.isAdmin)
            {
                btnNew.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnClose.Location = new Point(444, 13);
                btnApprove.Location = new Point(316, 13);
                panelAdmin.Hide();
                btnApprove.Text = "Delivered";
                pnRight.Dock = DockStyle.Left;
            }
        }
        #endregion

        #region button click
        private void dgvEmployeeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoTaskDetail.EmployeeNumber = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[0].Value);
            dtoTaskDetail.EmployeeName = dgvEmployeeList.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtoTaskDetail.EmployeeSurname = dgvEmployeeList.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtoTaskDetail.TaskStateId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[12].Value);
            dtoTaskDetail.TaskTitle = dgvEmployeeList.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtoTaskDetail.TaskContent = dgvEmployeeList.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtoTaskDetail.TaskStartDate = Convert.ToDateTime(dgvEmployeeList.Rows[e.RowIndex].Cells[6].Value);
            dtoTaskDetail.TaskDeliveryDate = Convert.ToDateTime(dgvEmployeeList.Rows[e.RowIndex].Cells[7].Value);
            dtoTaskDetail.EmpId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[8].Value);
            dtoTaskDetail.DepId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[9].Value);
            dtoTaskDetail.PosId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[10].Value);
            dtoTaskDetail.TaskId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[11].Value);
        }

        private void cbDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentId = Convert.ToInt32(cbDepartmentName.SelectedValue);
                cbPosition.DataSource = dtoTask.Positions.Where(x => x.DepID == departmentId).ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TaskDetailDTO> list = dtoTask.TaskDetail;
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
                list = list.Where(x => x.TaskStartDate > dtStartDate.Value && 
                x.TaskStartDate < dtEnddate.Value).ToList();
            if (rbDeliveryDate.Checked)
                list = list.Where(x => x.TaskDeliveryDate > dtStartDate.Value &&
                x.TaskDeliveryDate < dtEnddate.Value).ToList();
            if (cbTaskState.SelectedIndex != -1)
                list = list.Where(x => x.TaskStateId == Convert.ToInt32(cbTaskState.SelectedValue)).ToList();
            dgvEmployeeList.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.ExcelExport(dgvEmployeeList, "Task");
            MessageBox.Show("File exported in excel. Check desire location.");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (UserStatic.isAdmin && dtoTaskDetail.TaskStateId == TaskState.OnEmployee && dtoTaskDetail.EmpId != UserStatic.EmployeeId)
                MessageBox.Show("Before approve a task employee have to delivery task.");
            else if (UserStatic.isAdmin && dtoTaskDetail.TaskStateId == TaskState.Approved)
                MessageBox.Show("This task is already approved.");
            else if (!UserStatic.isAdmin && dtoTaskDetail.TaskStateId == TaskState.Delivered)
                MessageBox.Show("This task is already delivered.");
            else if (!UserStatic.isAdmin && dtoTaskDetail.TaskStateId == TaskState.Approved)
                MessageBox.Show("This task is already approved.");
            else
            {
                TaskBLL.ApprovedTask(dtoTaskDetail.TaskId, UserStatic.isAdmin);
                MessageBox.Show("Task is " + btnApprove.Text + " .");
                fillCombobox();
                fillDataGrid();
            }
        }      

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTask = new frmTask();
            frmTask._isUpdate = false;
            this.Hide();
            frmTask.ShowDialog();
            this.Visible = true;
            fillCombobox();
            fillDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoTaskDetail.TaskId == 0)
                MessageBox.Show("Please select task.");
            else
            {
                frmTask._isUpdate = true;
                frmTask._dtoTaskDetail = dtoTaskDetail;
                this.Hide();
                frmTask.ShowDialog();
                this.Visible = true;
                fillCombobox();
                fillDataGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this task?", "Warning!", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                TaskBLL.DeleteTask(dtoTaskDetail.TaskId);
                MessageBox.Show("Task was deleted.");
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
