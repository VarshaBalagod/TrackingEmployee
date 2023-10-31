using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.DTO;

namespace EmployeePersonalTracker
{
    public partial class frmPermission : Form
    {
        public frmPermission()
        {
            InitializeComponent();
        }
        #region declarations
        TimeSpan PermissionDay;
        public bool _isUpdate = false;
        public PermissionDetailDTO _dtoPermissionDetail = new PermissionDetailDTO();
        #endregion

        #region functions
        void clearData()
        {
            dtFinishdate.Value = dtStartDate.Value = DateTime.Today;
            txtAmount.Text = "";
            txtAmount.Clear();
            txtExplanation.Text = "";
            txtExplanation.Clear();
        }
        #endregion

        #region formLoad
        private void frmPermission_Load(object sender, EventArgs e)
        {
            txtEmpNumber.Text = UserStatic.EmployeeNumber.ToString();
            if (_isUpdate)
            {
                btnSave.Text = "Update";
                dtStartDate.Value = _dtoPermissionDetail.PermissionSartDate;
                dtFinishdate.Value = _dtoPermissionDetail.PermissionEndDate;
                txtEmpNumber.Text = _dtoPermissionDetail.EmployeeNumber.ToString();
                txtAmount.Text = _dtoPermissionDetail.PermissionDay.ToString();
                txtExplanation.Text = _dtoPermissionDetail.PermissionExplaination;
            }
        }
        #endregion

        #region buttonClick  
        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dtFinishdate.Value.Date - dtStartDate.Value.Date;
            txtAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void dtFinishdate_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dtFinishdate.Value.Date - dtStartDate.Value.Date;
            txtAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {          
            
            if (txtAmount.Text.Trim() == "")
                MessageBox.Show("Please change end or start date.");
            else if (Convert.ToInt32(txtAmount.Text) <= 0)
                MessageBox.Show("Permission day must be biger than 0.");
            else if (txtExplanation.Text.Trim() == "")
                MessageBox.Show("Please fill explanation.");
            else
            {
                tbl_Permission tablePermission = new tbl_Permission();
                if (!_isUpdate)
                {
                    tablePermission.EmpID = UserStatic.EmployeeId;
                    tablePermission.PermissionState = 1;
                    tablePermission.PermissionSartDate = dtStartDate.Value.Date;
                    tablePermission.PermissionEndDate = dtFinishdate.Value.Date;
                    tablePermission.PermissionDay = Convert.ToInt32(txtAmount.Text);
                    tablePermission.PermissionExplaination = txtExplanation.Text;
                    PermissionBLL.AddPermission(tablePermission);
                    MessageBox.Show("Permission added.");
                    tablePermission = new tbl_Permission();
                    clearData();
                }
                else if (_isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure","Warning",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        tablePermission.PerID = _dtoPermissionDetail.perId;
                        tablePermission.PermissionSartDate = dtStartDate.Value.Date;
                        tablePermission.PermissionEndDate = dtFinishdate.Value.Date;
                        tablePermission.PermissionDay = Convert.ToInt32(txtAmount.Text);
                        tablePermission.PermissionExplaination = txtExplanation.Text;
                        PermissionBLL.UpdatePermission(tablePermission);
                        MessageBox.Show("Permission updated.");
                        clearData();
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
