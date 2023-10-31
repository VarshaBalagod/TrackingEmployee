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


namespace EmployeePersonalTracker
{
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }
        #region declarations
        public tbl_Department _dtoDepartment = new tbl_Department();
        public bool _isUpdate = false;
        #endregion

        #region form load
        private void frmDepartment_Load(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                btnSave.Text = "Update";
                txtDepartmentName.Text = _dtoDepartment.DepartmentName;
            }

        }
        #endregion

        #region buttonClick       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter valid department name.");
            }
            else
            {
                if (!_isUpdate)
                {
                    tbl_Department tableDepartment = new tbl_Department();
                    tableDepartment.DepartmentName = txtDepartmentName.Text;
                    BLL.DepartmentBLL.AddDepartment(tableDepartment);
                    MessageBox.Show("Department name added.");
                    txtDepartmentName.Text = "";
                    txtDepartmentName.Clear();
                    tableDepartment = new tbl_Department();
                }
                else if (_isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        tbl_Department tableDepartmentupdate = new tbl_Department();
                        tableDepartmentupdate.DepID = _dtoDepartment.DepID;
                        tableDepartmentupdate.DepartmentName = txtDepartmentName.Text;
                        BLL.DepartmentBLL.UpdateDepartment(tableDepartmentupdate);
                        MessageBox.Show("Department name updated.");
                        txtDepartmentName.Text = "";
                        txtDepartmentName.Clear();
                        _isUpdate = false;
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
