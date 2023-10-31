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
    public partial class frmTask : Form
    {
        public frmTask()
        {
            InitializeComponent();
        }

        #region declarations
        TaskDTO dtoTask = new TaskDTO();
        tbl_Task tableTask = new tbl_Task();
        public bool _isUpdate = false;
        public TaskDetailDTO _dtoTaskDetail = new TaskDetailDTO();
        bool combofull = false;
        #endregion


        #region functions
        void fillDataGrid()
        {
            dtoTask = TaskBLL.GetAllTask();
            dgvEmployeeList.DataSource = dtoTask.Employees;
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
            if (dtoTask.Departments.Count > 0)
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
            txtTaskContent.Text = "";
            txtTaskContent.Clear();
            txtTaskTitle.Text = "";
            txtTaskTitle.Clear();
            fillCombobox();
            fillDataGrid();
            lblTaskState.Visible = false;
            cbTaskState.Visible = false;
        }
        #endregion

        #region formLoad
        private void frmTask_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            fillCombobox();
            lblTaskState.Visible = false;
            cbTaskState.Visible = false;
            if (_isUpdate)
            {
                btnSave.Text = "Update";
                panel3.Visible = false;
                lblTaskState.Visible = true;
                cbTaskState.Visible = true;
                btnSave.Text = "Update";
                txtEmpName.Text = _dtoTaskDetail.EmployeeName;
                txtEmpNumber.Text = _dtoTaskDetail.EmployeeNumber.ToString();
                txtEmpSurname.Text = _dtoTaskDetail.EmployeeSurname;
                txtTaskTitle.Text = _dtoTaskDetail.TaskTitle;
                txtTaskContent.Text = _dtoTaskDetail.TaskContent;
                cbTaskState.SelectedValue = Convert.ToInt32(_dtoTaskDetail.TaskStateId);
                cbDepartmentName.SelectedValue = Convert.ToInt32(_dtoTaskDetail.DepId);
                cbPosition.SelectedValue = Convert.ToInt32(_dtoTaskDetail.PosId);
            }           
        }
        #endregion


        #region buttonClick 
        private void cbDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentId = Convert.ToInt32(cbDepartmentName.SelectedValue);
                cbPosition.DataSource = dtoTask.Positions.Where(x => x.DepID == departmentId).ToList();
                List<EmployeeDetailDTO> list = dtoTask.Employees;
                dgvEmployeeList.DataSource = list.Where(x => x.DepId == departmentId).ToList();
            }
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int posId = Convert.ToInt32(cbPosition.SelectedValue);
                List<EmployeeDetailDTO> list = dtoTask.Employees;
                dgvEmployeeList.DataSource = list.Where(x => x.PosId == posId).ToList();
            }
        }

        private void dgvEmployeeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpNumber.Text = dgvEmployeeList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmpName.Text = dgvEmployeeList.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmpSurname.Text = dgvEmployeeList.Rows[e.RowIndex].Cells[6].Value.ToString();
            tableTask.EmpID = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[0].Value);
            //cbDepartmentName.SelectedValue = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[1].Value);
           // cbPosition.SelectedValue = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells[2].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tableTask.EmpID == 0)
                MessageBox.Show("Please select employee on the table.");
            else if (txtTaskTitle.Text.Trim() == "")
                MessageBox.Show("Please enter task title.");
            else if (txtTaskContent.Text.Trim() == "")
                MessageBox.Show("Please enter task content.");
            else
            {
                if (!_isUpdate)
                {
                    tbl_Task tableTaskAdd= new tbl_Task();
                    tableTaskAdd.TaskTitle = txtTaskTitle.Text;
                    tableTaskAdd.TaskContent = txtTaskContent.Text;
                    tableTaskAdd.TaskStartDate = DateTime.Today;
                    tableTaskAdd.TaskSate = 1;// Convert.ToInt32(cbTaskState.SelectedValue);
                    tableTaskAdd.EmpID = tableTask.EmpID;
                    TaskBLL.AddTask(tableTaskAdd);
                    MessageBox.Show("Task added.");
                    clearData();
                    tableTaskAdd = new tbl_Task();
                }
                else if(_isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are You Sure?", "Warning!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        tbl_Task tableTaskUpdate = new tbl_Task();
                        tableTaskUpdate.TaskID = _dtoTaskDetail.TaskId;
                        if (Convert.ToInt32(txtEmpNumber.Text) != _dtoTaskDetail.EmployeeNumber)
                            tableTaskUpdate.EmpID = tableTask.EmpID;
                        else
                            tableTaskUpdate.EmpID = _dtoTaskDetail.EmpId;

                        tableTaskUpdate.TaskTitle = txtTaskTitle.Text;
                        tableTaskUpdate.TaskContent = txtTaskContent.Text;
                        tableTaskUpdate.TaskStartDate = DateTime.Today;
                        tableTaskUpdate.TaskSate = Convert.ToInt32(cbTaskState.SelectedValue);
                        TaskBLL.UpdateTask(tableTaskUpdate);
                        _isUpdate = false;
                        MessageBox.Show("Task updated.");
                        clearData();
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
