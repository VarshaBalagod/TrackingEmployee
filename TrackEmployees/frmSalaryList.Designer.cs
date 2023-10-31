namespace EmployeePersonalTracker
{
    partial class frmSalaryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpRadioBtn = new System.Windows.Forms.GroupBox();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpSurname = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.grpRadioBtn.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnRight);
            this.panel1.Controls.Add(this.pnLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 264);
            this.panel1.TabIndex = 6;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.btnExportToExcel);
            this.pnRight.Controls.Add(this.cbMonth);
            this.pnRight.Controls.Add(this.txtYear);
            this.pnRight.Controls.Add(this.txtSalary);
            this.pnRight.Controls.Add(this.btnSearch);
            this.pnRight.Controls.Add(this.btnClear);
            this.pnRight.Controls.Add(this.grpRadioBtn);
            this.pnRight.Controls.Add(this.label4);
            this.pnRight.Controls.Add(this.label3);
            this.pnRight.Controls.Add(this.label2);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(498, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(552, 264);
            this.pnRight.TabIndex = 1;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.BackgroundImage")));
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Location = new System.Drawing.Point(402, 161);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(71, 68);
            this.btnExportToExcel.TabIndex = 8;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(339, 32);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(165, 33);
            this.cbMonth.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(87, 29);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(166, 30);
            this.txtYear.TabIndex = 0;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(88, 100);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(165, 30);
            this.txtSalary.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(53, 183);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(218, 183);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpRadioBtn
            // 
            this.grpRadioBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.grpRadioBtn.Controls.Add(this.rbEqual);
            this.grpRadioBtn.Controls.Add(this.rbLess);
            this.grpRadioBtn.Controls.Add(this.rbMore);
            this.grpRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRadioBtn.Location = new System.Drawing.Point(266, 87);
            this.grpRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.grpRadioBtn.Name = "grpRadioBtn";
            this.grpRadioBtn.Padding = new System.Windows.Forms.Padding(2);
            this.grpRadioBtn.Size = new System.Drawing.Size(275, 53);
            this.grpRadioBtn.TabIndex = 7;
            this.grpRadioBtn.TabStop = false;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Location = new System.Drawing.Point(175, 15);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(87, 29);
            this.rbEqual.TabIndex = 2;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Equal";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Location = new System.Drawing.Point(93, 15);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(79, 29);
            this.rbLess.TabIndex = 1;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "Less";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            this.rbMore.AutoSize = true;
            this.rbMore.Location = new System.Drawing.Point(5, 15);
            this.rbMore.Name = "rbMore";
            this.rbMore.Size = new System.Drawing.Size(82, 29);
            this.rbMore.TabIndex = 0;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "More";
            this.rbMore.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.cbPosition);
            this.pnLeft.Controls.Add(this.cbDepartmentName);
            this.pnLeft.Controls.Add(this.label6);
            this.pnLeft.Controls.Add(this.label5);
            this.pnLeft.Controls.Add(this.txtEmpSurname);
            this.pnLeft.Controls.Add(this.txtEmpName);
            this.pnLeft.Controls.Add(this.lblEmpSurname);
            this.pnLeft.Controls.Add(this.lblEmpName);
            this.pnLeft.Controls.Add(this.txtEmpNumber);
            this.pnLeft.Controls.Add(this.lblEmployeeNumber);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(494, 264);
            this.pnLeft.TabIndex = 0;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(220, 213);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(266, 33);
            this.cbPosition.TabIndex = 4;
            // 
            // cbDepartmentName
            // 
            this.cbDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartmentName.FormattingEnabled = true;
            this.cbDepartmentName.Location = new System.Drawing.Point(220, 163);
            this.cbDepartmentName.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartmentName.Name = "cbDepartmentName";
            this.cbDepartmentName.Size = new System.Drawing.Size(266, 33);
            this.cbDepartmentName.TabIndex = 3;
            this.cbDepartmentName.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Position Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Department Name";
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSurname.Location = new System.Drawing.Point(220, 116);
            this.txtEmpSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(267, 30);
            this.txtEmpSurname.TabIndex = 2;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(220, 69);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(267, 30);
            this.txtEmpName.TabIndex = 1;
            // 
            // lblEmpSurname
            // 
            this.lblEmpSurname.AutoSize = true;
            this.lblEmpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSurname.Location = new System.Drawing.Point(26, 121);
            this.lblEmpSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpSurname.Name = "lblEmpSurname";
            this.lblEmpSurname.Size = new System.Drawing.Size(184, 25);
            this.lblEmpSurname.TabIndex = 13;
            this.lblEmpSurname.Text = "Employee Surname";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(26, 72);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(156, 25);
            this.lblEmpName.TabIndex = 12;
            this.lblEmpName.Text = "Employee Name";
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNumber.Location = new System.Drawing.Point(220, 22);
            this.txtEmpNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(266, 30);
            this.txtEmpNumber.TabIndex = 0;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(26, 22);
            this.lblEmployeeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(173, 25);
            this.lblEmployeeNumber.TabIndex = 3;
            this.lblEmployeeNumber.Text = "Employee Number";
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btnUpdate);
            this.pnBottom.Controls.Add(this.btnDelete);
            this.pnBottom.Controls.Add(this.btnClose);
            this.pnBottom.Controls.Add(this.btnNew);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 586);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1050, 69);
            this.pnBottom.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(242, 12);
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
            this.btnDelete.Location = new System.Drawing.Point(432, 12);
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
            this.btnClose.Location = new System.Drawing.Point(622, 12);
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
            this.btnNew.Location = new System.Drawing.Point(52, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(144, 45);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 264);
            this.dgvEmployeeList.MultiSelect = false;
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 62;
            this.dgvEmployeeList.RowTemplate.Height = 28;
            this.dgvEmployeeList.Size = new System.Drawing.Size(1050, 322);
            this.dgvEmployeeList.TabIndex = 8;
            this.dgvEmployeeList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_RowEnter);
            // 
            // frmSalaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 655);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBottom);
            this.Name = "frmSalaryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary List";
            this.Load += new System.EventHandler(this.frmSalaryList_Load);
            this.panel1.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.grpRadioBtn.ResumeLayout(false);
            this.grpRadioBtn.PerformLayout();
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpRadioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbDepartmentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpSurname;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpNumber;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}