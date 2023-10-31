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
using System.IO;
using System.Configuration;

namespace EmployeePersonalTracker
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        #region declarations

        string dirEmployeeImages = ConfigurationSettings.AppSettings["EmployeeImages"];

        EmployeeDTO dtoEmployee = new EmployeeDTO();
        public EmployeeDetailDTO _dtoEmployeeDetail = new EmployeeDetailDTO();
        public bool _isUpdate = false;
        bool combofull, validData, uniqueEmpNum = false;
        string employeePhoto, upEmloyeePhoto = "";
        #endregion

        #region functions
        void validateData()
        {

            if (txtEmpNumber.Text.Trim() == "")
                MessageBox.Show("Please enter Employee number.");
            else if (txtEmpPassword.Text.Trim() == "")
                MessageBox.Show("Please enter Employee password.");
            else if (txtEmpName.Text.Trim() == "")
                MessageBox.Show("Please enter Employee name.");
            else if (txtEmpSurName.Text.Trim() == "")
                MessageBox.Show("Please enter Employee surname.");
            else if (txtEmpImage.Text.Trim() == "")
                MessageBox.Show("Please select image.");
            else if (txtAddress.Text.Trim() == "")
                MessageBox.Show("Please enter Employee address.");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Please enter Employee salary.");
            else if (cbDepartmentName.SelectedIndex == -1)
                MessageBox.Show("Please select department name.");
            else if (cbPosition.SelectedIndex == -1)
                MessageBox.Show("Please select position name.");
            else if (dtEmpBirthdate.Text.Length == 0)
                MessageBox.Show("Please select date.");
            else
                validData = true;
        }
        void clearData()
        {
            txtEmpNumber.Text = "";
            txtEmpNumber.Clear();
            txtEmpPassword.Text = "";
            txtEmpPassword.Clear();
            txtEmpName.Text = "";
            txtEmpName.Clear();
            txtEmpSurName.Text = "";
            txtEmpSurName.Clear();
            txtEmpImage.Text = "";
            txtEmpImage.Clear();
            txtAddress.Text = "";
            txtAddress.Clear();
            txtSalary.Text = "";
            txtSalary.Clear();
            chkIsAdmin.Checked = false;
            employeePhoto = "";
            uniqueEmpNum = false;
            validData = false;
            combofull = false;
            pbIEmpImage.Image = null;
            dtEmpBirthdate.Value = DateTime.Today;
            fillComboBox();
        }

        void fillComboBox()
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
        #endregion

        #region formLoad
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            fillComboBox();
            if (_isUpdate)
            {
                btnSave.Text = "Update";
                upEmloyeePhoto = dirEmployeeImages + _dtoEmployeeDetail.EmployeeImagePath;
                txtEmpNumber.Text = _dtoEmployeeDetail.EmployeeNumber.ToString();
                txtEmpPassword.Text = _dtoEmployeeDetail.EmployeePassword;
                txtEmpName.Text = _dtoEmployeeDetail.EmployeeName;
                txtEmpSurName.Text = _dtoEmployeeDetail.EmployeeSurname;
                txtEmpImage.Text = upEmloyeePhoto;
                txtAddress.Text = _dtoEmployeeDetail.EmployeeAddress;
                txtSalary.Text = _dtoEmployeeDetail.EmployeeSalary.ToString();
                chkIsAdmin.Checked = _dtoEmployeeDetail.isAdmin;
                pbIEmpImage.Load(upEmloyeePhoto);
                dtEmpBirthdate.Value = _dtoEmployeeDetail.EmployeeBirthday;
                cbDepartmentName.SelectedValue = Convert.ToInt32(_dtoEmployeeDetail.DepId);
                cbPosition.SelectedValue = Convert.ToInt32(_dtoEmployeeDetail.PosId);
                if (!UserStatic.isAdmin)
                {
                    chkIsAdmin.Enabled = false;
                    txtEmpNumber.Enabled = false;
                    txtSalary.Enabled = false;
                    cbDepartmentName.Enabled = false;
                    cbPosition.Enabled = false;
                }
            }

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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtEmpNumber.Text.Trim() == "")
                MessageBox.Show("Please enter Employee number.");
            else
            {
                uniqueEmpNum = EmployeeBLL.IsUniqueEmployeeNumber(Convert.ToInt32(txtEmpNumber.Text));
                if (!uniqueEmpNum)
                    MessageBox.Show("Employee number Exits.");
                else
                    MessageBox.Show("Employee number you can use.");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbIEmpImage.Load(openFileDialog1.FileName);
                txtEmpImage.Text = openFileDialog1.FileName;
                employeePhoto = DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss_") + openFileDialog1.SafeFileName;
            }
        }

        private void txtEmpNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateData();
            if (validData == true)
            {

                if (!_isUpdate)
                {
                    if (!EmployeeBLL.IsUniqueEmployeeNumber(Convert.ToInt32(txtEmpNumber.Text)))
                        MessageBox.Show("Employee number Exits.");
                    else
                    {
                        tbl_Employee tableEmployee = new tbl_Employee();
                        tableEmployee.EmployeeNumber = Convert.ToInt32(txtEmpNumber.Text);
                        tableEmployee.EmployeePassword = txtEmpPassword.Text;
                        tableEmployee.EmployeeeName = txtEmpName.Text;
                        tableEmployee.EmployeeSurname = txtEmpSurName.Text;
                        tableEmployee.EmployeePhotoPath = employeePhoto;
                        tableEmployee.EmployeeSalary = Convert.ToInt32(txtSalary.Text);
                        tableEmployee.EmployeeAddress = txtAddress.Text;
                        tableEmployee.DepID = Convert.ToInt32(cbDepartmentName.SelectedValue);
                        tableEmployee.PosID = Convert.ToInt32(cbPosition.SelectedValue);
                        tableEmployee.EmployeeBirthDay = dtEmpBirthdate.Value;
                        tableEmployee.IsAdmin = chkIsAdmin.Checked;
                        EmployeeBLL.AddEmployee(tableEmployee);
                        MessageBox.Show("New employee is added.");
                        try
                        {
                            // If this directory does not exist, a DirectoryNotFoundException is thrown
                            // when attempting to set the current directory.
                            Directory.SetCurrentDirectory(dirEmployeeImages);
                            File.Copy(txtEmpImage.Text, dirEmployeeImages + employeePhoto);
                            //MessageBox.Show("File copied.");
                        }
                        catch (DirectoryNotFoundException dirEx)
                        {
                            // Let the user know that the directory did not exist.
                            MessageBox.Show("Directory not found: " + dirEx.Message);
                        }
                        clearData();
                        tableEmployee = new tbl_Employee();
                    }
                }
                else if (_isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        tbl_Employee tableEmployeeUpdate = new tbl_Employee();
                        tableEmployeeUpdate.EmpID = _dtoEmployeeDetail.EmpId;
                        tableEmployeeUpdate.EmployeeNumber = Convert.ToInt32(txtEmpNumber.Text);
                        tableEmployeeUpdate.EmployeePassword = txtEmpPassword.Text;
                        tableEmployeeUpdate.EmployeeeName = txtEmpName.Text;
                        tableEmployeeUpdate.EmployeeSurname = txtEmpSurName.Text;
                        tableEmployeeUpdate.EmployeeSalary = Convert.ToInt32(txtSalary.Text);
                        tableEmployeeUpdate.EmployeeAddress = txtAddress.Text;
                        tableEmployeeUpdate.DepID = Convert.ToInt32(cbDepartmentName.SelectedValue);
                        tableEmployeeUpdate.PosID = Convert.ToInt32(cbPosition.SelectedValue);
                        tableEmployeeUpdate.EmployeeBirthDay = dtEmpBirthdate.Value;
                        tableEmployeeUpdate.IsAdmin = chkIsAdmin.Checked;
                        try
                        {
                            if (txtEmpImage.Text != upEmloyeePhoto)
                            {


                                if (File.Exists(dirEmployeeImages + _dtoEmployeeDetail.EmployeeImagePath))
                                    File.Delete(dirEmployeeImages + _dtoEmployeeDetail.EmployeeImagePath);

                                // If this directory does not exist, a DirectoryNotFoundException is thrown
                                // when attempting to set the current directory.
                                Directory.SetCurrentDirectory(dirEmployeeImages);
                                File.Copy(txtEmpImage.Text, dirEmployeeImages + employeePhoto);
                                tableEmployeeUpdate.EmployeePhotoPath = employeePhoto;
                                //MessageBox.Show("File copied.");
                            }
                            else
                                tableEmployeeUpdate.EmployeePhotoPath = _dtoEmployeeDetail.EmployeeImagePath;
                        }
                        catch (DirectoryNotFoundException dirEx)
                        {
                            // Let the user know that the directory did not exist.
                            MessageBox.Show("Directory not found: " + dirEx.Message);
                        }

                        EmployeeBLL.UpdateEmployee(tableEmployeeUpdate);
                        MessageBox.Show("Employee is updated.");
                        _isUpdate = false;
                        clearData();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter/select data.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
