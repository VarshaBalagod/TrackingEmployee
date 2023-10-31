namespace EmployeePersonalTracker
{
    partial class frmPermissionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermissionList));
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnRight = new System.Windows.Forms.Panel();
            this.txtPermisionAmount = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpRadioBtn = new System.Windows.Forms.GroupBox();
            this.rbEndDate = new System.Windows.Forms.RadioButton();
            this.rbStartDate = new System.Windows.Forms.RadioButton();
            this.dtFinishdate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.btnDisApprove = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnRight.SuspendLayout();
            this.grpRadioBtn.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 271);
            this.dgvEmployeeList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmployeeList.MultiSelect = false;
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 62;
            this.dgvEmployeeList.RowTemplate.Height = 28;
            this.dgvEmployeeList.Size = new System.Drawing.Size(1041, 186);
            this.dgvEmployeeList.TabIndex = 5;
            this.dgvEmployeeList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_RowEnter);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(840, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.btnExportToExcel);
            this.pnRight.Controls.Add(this.txtPermisionAmount);
            this.pnRight.Controls.Add(this.btnSearch);
            this.pnRight.Controls.Add(this.btnClear);
            this.pnRight.Controls.Add(this.grpRadioBtn);
            this.pnRight.Controls.Add(this.dtFinishdate);
            this.pnRight.Controls.Add(this.dtStartDate);
            this.pnRight.Controls.Add(this.label4);
            this.pnRight.Controls.Add(this.label3);
            this.pnRight.Controls.Add(this.label2);
            this.pnRight.Controls.Add(this.label1);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(489, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(552, 271);
            this.pnRight.TabIndex = 1;
            // 
            // txtPermisionAmount
            // 
            this.txtPermisionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermisionAmount.Location = new System.Drawing.Point(144, 125);
            this.txtPermisionAmount.Name = "txtPermisionAmount";
            this.txtPermisionAmount.Size = new System.Drawing.Size(175, 30);
            this.txtPermisionAmount.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(27, 185);
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
            this.btnClear.Location = new System.Drawing.Point(204, 185);
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
            this.grpRadioBtn.Controls.Add(this.rbEndDate);
            this.grpRadioBtn.Controls.Add(this.rbStartDate);
            this.grpRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRadioBtn.Location = new System.Drawing.Point(329, 29);
            this.grpRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.grpRadioBtn.Name = "grpRadioBtn";
            this.grpRadioBtn.Padding = new System.Windows.Forms.Padding(2);
            this.grpRadioBtn.Size = new System.Drawing.Size(190, 88);
            this.grpRadioBtn.TabIndex = 7;
            this.grpRadioBtn.TabStop = false;
            // 
            // rbEndDate
            // 
            this.rbEndDate.AutoSize = true;
            this.rbEndDate.Location = new System.Drawing.Point(14, 55);
            this.rbEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.rbEndDate.Name = "rbEndDate";
            this.rbEndDate.Size = new System.Drawing.Size(118, 29);
            this.rbEndDate.TabIndex = 0;
            this.rbEndDate.TabStop = true;
            this.rbEndDate.Text = "End Date";
            this.rbEndDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            this.rbStartDate.AutoSize = true;
            this.rbStartDate.Location = new System.Drawing.Point(14, 21);
            this.rbStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.rbStartDate.Name = "rbStartDate";
            this.rbStartDate.Size = new System.Drawing.Size(124, 29);
            this.rbStartDate.TabIndex = 1;
            this.rbStartDate.TabStop = true;
            this.rbStartDate.Text = "Start Date";
            this.rbStartDate.UseVisualStyleBackColor = true;
            // 
            // dtFinishdate
            // 
            this.dtFinishdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinishdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinishdate.Location = new System.Drawing.Point(144, 82);
            this.dtFinishdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtFinishdate.Name = "dtFinishdate";
            this.dtFinishdate.Size = new System.Drawing.Size(175, 30);
            this.dtFinishdate.TabIndex = 1;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(144, 44);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(175, 30);
            this.dtStartDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Day Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Finish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permission Date";
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(20, 16);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(144, 45);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(512, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(676, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(224, 212);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(231, 33);
            this.cbPosition.TabIndex = 4;
            // 
            // cbDepartmentName
            // 
            this.cbDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartmentName.FormattingEnabled = true;
            this.cbDepartmentName.Location = new System.Drawing.Point(224, 160);
            this.cbDepartmentName.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartmentName.Name = "cbDepartmentName";
            this.cbDepartmentName.Size = new System.Drawing.Size(231, 33);
            this.cbDepartmentName.TabIndex = 3;
            this.cbDepartmentName.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 220);
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
            this.label5.Location = new System.Drawing.Point(26, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Department Name";
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSurname.Location = new System.Drawing.Point(224, 111);
            this.txtEmpSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(232, 30);
            this.txtEmpSurname.TabIndex = 2;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(224, 62);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(232, 30);
            this.txtEmpName.TabIndex = 1;
            // 
            // lblEmpSurname
            // 
            this.lblEmpSurname.AutoSize = true;
            this.lblEmpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSurname.Location = new System.Drawing.Point(26, 111);
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
            this.lblEmpName.Location = new System.Drawing.Point(26, 67);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(156, 25);
            this.lblEmpName.TabIndex = 12;
            this.lblEmpName.Text = "Employee Name";
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNumber.Location = new System.Drawing.Point(224, 13);
            this.txtEmpNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(231, 30);
            this.txtEmpNumber.TabIndex = 0;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(26, 18);
            this.lblEmployeeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(173, 25);
            this.lblEmployeeNumber.TabIndex = 3;
            this.lblEmployeeNumber.Text = "Employee Number";
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
            this.pnLeft.Size = new System.Drawing.Size(485, 271);
            this.pnLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnRight);
            this.panel1.Controls.Add(this.pnLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 271);
            this.panel1.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(348, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(144, 45);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btnDisApprove);
            this.pnBottom.Controls.Add(this.btnApprove);
            this.pnBottom.Controls.Add(this.btnUpdate);
            this.pnBottom.Controls.Add(this.btnDelete);
            this.pnBottom.Controls.Add(this.btnClose);
            this.pnBottom.Controls.Add(this.btnNew);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 457);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1041, 83);
            this.pnBottom.TabIndex = 4;
            // 
            // btnDisApprove
            // 
            this.btnDisApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisApprove.Location = new System.Drawing.Point(184, 17);
            this.btnDisApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisApprove.Name = "btnDisApprove";
            this.btnDisApprove.Size = new System.Drawing.Size(144, 45);
            this.btnDisApprove.TabIndex = 1;
            this.btnDisApprove.Text = "Disapprove";
            this.btnDisApprove.UseVisualStyleBackColor = true;
            this.btnDisApprove.Click += new System.EventHandler(this.btnDisApprove_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.BackgroundImage")));
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Location = new System.Drawing.Point(381, 162);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(71, 68);
            this.btnExportToExcel.TabIndex = 8;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // frmPermissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 540);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBottom);
            this.Name = "frmPermissionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission List";
            this.Load += new System.EventHandler(this.frmPermissionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.grpRadioBtn.ResumeLayout(false);
            this.grpRadioBtn.PerformLayout();
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.TextBox txtPermisionAmount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpRadioBtn;
        private System.Windows.Forms.RadioButton rbEndDate;
        private System.Windows.Forms.RadioButton rbStartDate;
        private System.Windows.Forms.DateTimePicker dtFinishdate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
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
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnDisApprove;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}