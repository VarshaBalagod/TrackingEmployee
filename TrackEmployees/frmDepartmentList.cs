using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace EmployeePersonalTracker
{
    public partial class frmDepartmentList : Form
    {

        public frmDepartmentList()
        {
            InitializeComponent();
        }
        #region declarations
        List<tbl_Department> listTableDepartment = new List<tbl_Department>();
        frmDepartment frmDepartment = new frmDepartment();
        tbl_Department dtoDepartment = new tbl_Department();
        #endregion

        #region form load
        private void frmDepartmentList_Load(object sender, EventArgs e)
        {
            listTableDepartment = BLL.DepartmentBLL.GetDeparment();
            dgvDepartmentLst.DataSource = listTableDepartment;
            dgvDepartmentLst.Columns[0].Visible = false;
            dgvDepartmentLst.Columns[1].HeaderText = "Department Name";
        }
        #endregion

        #region button Click
        private void dgvDepartmentLst_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoDepartment.DepID =Convert.ToInt32(dgvDepartmentLst.Rows[e.RowIndex].Cells[0].Value);
            dtoDepartment.DepartmentName = dgvDepartmentLst.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDepartment = new frmDepartment();
            this.Hide();
            frmDepartment.ShowDialog();
            this.Visible = true;
            listTableDepartment = DepartmentBLL.GetDeparment();
            dgvDepartmentLst.DataSource= listTableDepartment;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoDepartment.DepID == 0)
                MessageBox.Show("Please select department from table");
            else
            {
                frmDepartment = new frmDepartment();
                frmDepartment._isUpdate=true;
                frmDepartment._dtoDepartment = dtoDepartment;
                this.Hide();
                frmDepartment.ShowDialog();
                this.Visible = true;
                listTableDepartment = DepartmentBLL.GetDeparment();
                dgvDepartmentLst.DataSource = listTableDepartment;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this department?", "Warning?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DepartmentBLL.DeleteDepartment(dtoDepartment.DepID);
                MessageBox.Show("Department was deleted");
                listTableDepartment = DepartmentBLL.GetDeparment();
                dgvDepartmentLst.DataSource = listTableDepartment;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

       
    }
}
