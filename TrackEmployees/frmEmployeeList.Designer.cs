namespace EmployeePersonalTracker
{
    partial class frmEmployeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeList));
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbDepartmentName = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.lblDepName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpNumber = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblEmpSrname = new System.Windows.Forms.Label();
            this.panTop = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 198);
            this.dgvEmployeeList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 62;
            this.dgvEmployeeList.RowTemplate.Height = 28;
            this.dgvEmployeeList.Size = new System.Drawing.Size(842, 266);
            this.dgvEmployeeList.TabIndex = 6;
            this.dgvEmployeeList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_RowEnter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(410, 124);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(572, 124);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbDepartmentName
            // 
            this.cbDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartmentName.FormattingEnabled = true;
            this.cbDepartmentName.Location = new System.Drawing.Point(579, 22);
            this.cbDepartmentName.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartmentName.Name = "cbDepartmentName";
            this.cbDepartmentName.Size = new System.Drawing.Size(226, 24);
            this.cbDepartmentName.TabIndex = 3;
            this.cbDepartmentName.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentName_SelectedIndexChanged);
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(579, 72);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(226, 24);
            this.cbPosition.TabIndex = 4;
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNumber.Location = new System.Drawing.Point(199, 20);
            this.txtEmpNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(202, 23);
            this.txtEmpNumber.TabIndex = 0;
            this.txtEmpNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpNumber_KeyPress);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(199, 72);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(202, 23);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSurname.Location = new System.Drawing.Point(199, 124);
            this.txtEmpSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(202, 23);
            this.txtEmpSurname.TabIndex = 2;
            // 
            // lblDepName
            // 
            this.lblDepName.AutoSize = true;
            this.lblDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepName.Location = new System.Drawing.Point(405, 25);
            this.lblDepName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Size = new System.Drawing.Size(123, 17);
            this.lblDepName.TabIndex = 4;
            this.lblDepName.Text = "Department Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(405, 75);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(11, 72);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(111, 17);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblEmpNumber
            // 
            this.lblEmpNumber.AutoSize = true;
            this.lblEmpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNumber.Location = new System.Drawing.Point(11, 20);
            this.lblEmpNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpNumber.Name = "lblEmpNumber";
            this.lblEmpNumber.Size = new System.Drawing.Size(124, 17);
            this.lblEmpNumber.TabIndex = 0;
            this.lblEmpNumber.Text = "Employee Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(235, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(447, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(648, 22);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(22, 22);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(144, 45);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnUpdate);
            this.pnlBottom.Controls.Add(this.btnDelete);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnNew);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 464);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(842, 100);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblEmpSrname
            // 
            this.lblEmpSrname.AutoSize = true;
            this.lblEmpSrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSrname.Location = new System.Drawing.Point(11, 129);
            this.lblEmpSrname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpSrname.Name = "lblEmpSrname";
            this.lblEmpSrname.Size = new System.Drawing.Size(131, 17);
            this.lblEmpSrname.TabIndex = 2;
            this.lblEmpSrname.Text = "Employee Surname";
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.btnExportToExcel);
            this.panTop.Controls.Add(this.btnSearch);
            this.panTop.Controls.Add(this.btnClear);
            this.panTop.Controls.Add(this.cbDepartmentName);
            this.panTop.Controls.Add(this.cbPosition);
            this.panTop.Controls.Add(this.txtEmpNumber);
            this.panTop.Controls.Add(this.txtEmpName);
            this.panTop.Controls.Add(this.txtEmpSurname);
            this.panTop.Controls.Add(this.lblDepName);
            this.panTop.Controls.Add(this.lblPosition);
            this.panTop.Controls.Add(this.lblEmpSrname);
            this.panTop.Controls.Add(this.lblEmpName);
            this.panTop.Controls.Add(this.lblEmpNumber);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(2);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(842, 198);
            this.panTop.TabIndex = 5;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.BackgroundImage")));
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Location = new System.Drawing.Point(734, 112);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(71, 68);
            this.btnExportToExcel.TabIndex = 4;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 564);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbDepartmentName;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtEmpNumber;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.Label lblDepName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblEmpSrname;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}