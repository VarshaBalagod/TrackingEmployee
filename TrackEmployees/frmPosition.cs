using DAL;
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
using DAL.DTO;

namespace EmployeePersonalTracker
{
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();
        }

        #region declarations
        List<tbl_Department> listDepartment = new List<tbl_Department>();
        public PositionDTO _dtoPosition = new PositionDTO();
        public bool _isUpdate = false;
        #endregion

      
        #region functions
        void clearData()
        {
            txtPositionName.Text = "";
            txtPositionName.Clear();
            cbDepartmentName.SelectedIndex = -1;
        }
        void fillCombobox()
        {
            listDepartment = BLL.DepartmentBLL.GetDeparment();
            cbDepartmentName.DataSource = listDepartment;
            cbDepartmentName.DisplayMember = "DepartmentName";
            cbDepartmentName.ValueMember = "DepID";
            cbDepartmentName.SelectedIndex = -1;
        }

        #endregion

        #region formLoad
        private void frmPosition_Load(object sender, EventArgs e)
        {
            clearData();
            fillCombobox();
            if (_isUpdate)
            {
                btnSave.Text = "Update";
                txtPositionName.Text = _dtoPosition.PositionName;
                cbDepartmentName.SelectedValue = Convert.ToInt32(_dtoPosition.DepID);
            }
        }
        #endregion


        #region buttonClick 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPositionName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter valid position name.");
            }
            else if (cbDepartmentName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select department name.");
            }
            else 
            {
                if (!_isUpdate)
                {
                    tbl_Position tablePosition = new tbl_Position();
                    tablePosition.PositionName = txtPositionName.Text;
                    tablePosition.DepID = Convert.ToInt32(cbDepartmentName.SelectedValue);
                    BLL.PositionBLL.AddPosition(tablePosition);
                    MessageBox.Show("Position added.");
                    clearData();
                    tablePosition = new tbl_Position();
                }
                else if (_isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        tbl_Position tablePositionUpdate = new tbl_Position();
                        tablePositionUpdate.PositionName = txtPositionName.Text;
                        tablePositionUpdate.DepID = Convert.ToInt32(cbDepartmentName.SelectedValue);
                        tablePositionUpdate.PosID = _dtoPosition.PosID;
                        bool control = false;
                        if (Convert.ToInt32(cbDepartmentName.SelectedValue) != _dtoPosition.DepID)
                            control = true;       
                        BLL.PositionBLL.UpdatePositon(tablePositionUpdate,control);
                        MessageBox.Show("Position Updated.");
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
