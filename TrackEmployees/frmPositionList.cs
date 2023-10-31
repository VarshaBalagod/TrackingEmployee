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
    public partial class frmPositionList : Form
    {
        public frmPositionList()
        {
            InitializeComponent();
        }
        #region declarations
        frmPosition frmPosition = new frmPosition();
        List<PositionDTO> listPosition = new List<PositionDTO>();
        PositionDTO dtoPosition = new PositionDTO();
        #endregion


        #region functions
        void fillGridData()
        {
            listPosition = PositionBLL.GetAllPosition();
            dgvPositionList.DataSource = listPosition;
            dgvPositionList.Columns[1].Visible = false;
            dgvPositionList.Columns[2].Visible = false;
            dgvPositionList.Columns[4].Visible = false;
            dgvPositionList.Columns[0].HeaderText = "Department Name";
            dgvPositionList.Columns[3].HeaderText = "Position Name";
        }
        #endregion


        #region form load 
        private void frmPositionList_Load(object sender, EventArgs e)
        {
            fillGridData();
        }
        #endregion


        #region buttonClick 
        private void dgvPositionList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoPosition.DepID = Convert.ToInt32(dgvPositionList.Rows[e.RowIndex].Cells[4].Value);
            dtoPosition.PosID = Convert.ToInt32(dgvPositionList.Rows[e.RowIndex].Cells[2].Value);
            dtoPosition.DepartmentName = dgvPositionList.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtoPosition.PositionName = dgvPositionList.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtoPosition.OldDepID = Convert.ToInt32(dgvPositionList.Rows[e.RowIndex].Cells[4].Value);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPosition = new frmPosition();
            this.Hide();
            frmPosition.ShowDialog();
            this.Visible = true;
            fillGridData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoPosition.PosID == 0)
                MessageBox.Show("Please select position form table.");
            else
            {
                frmPosition = new frmPosition();
                frmPosition._isUpdate = true;
                frmPosition._dtoPosition = dtoPosition;
                this.Hide();
                frmPosition.ShowDialog();
                this.Visible = true;
                fillGridData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this position?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PositionBLL.DeletePosition(dtoPosition.PosID);
                MessageBox.Show("Position was deleted.");
                fillGridData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
       
    }
}
