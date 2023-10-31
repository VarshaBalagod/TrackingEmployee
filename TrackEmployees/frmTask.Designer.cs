namespace EmployeePersonalTracker
{
    partial class frmTask
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpSurname = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.cbTaskState = new System.Windows.Forms.ComboBox();
            this.lblTaskState = new System.Windows.Forms.Label();
            this.txtTaskContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbPosition);
            this.panel2.Controls.Add(this.cbDepartmentName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 175);
            this.panel2.TabIndex = 0;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(16, 120);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(239, 33);
            this.cbPosition.TabIndex = 2;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // cbDepartmentName
            // 
            this.cbDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartmentName.FormattingEnabled = true;
            this.cbDepartmentName.Location = new System.Drawing.Point(16, 50);
            this.cbDepartmentName.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartmentName.Name = "cbDepartmentName";
            this.cbDepartmentName.Size = new System.Drawing.Size(239, 33);
            this.cbDepartmentName.TabIndex = 0;
            this.cbDepartmentName.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Position Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Department Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvEmployeeList);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 548);
            this.panel3.TabIndex = 0;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 175);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 62;
            this.dgvEmployeeList.RowTemplate.Height = 28;
            this.dgvEmployeeList.Size = new System.Drawing.Size(493, 373);
            this.dgvEmployeeList.TabIndex = 1;
            this.dgvEmployeeList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_RowEnter);
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNumber.Location = new System.Drawing.Point(235, 13);
            this.txtEmpNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.ReadOnly = true;
            this.txtEmpNumber.Size = new System.Drawing.Size(275, 30);
            this.txtEmpNumber.TabIndex = 0;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(23, 13);
            this.lblEmployeeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(173, 25);
            this.lblEmployeeNumber.TabIndex = 3;
            this.lblEmployeeNumber.Text = "Employee Number";
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSurname.Location = new System.Drawing.Point(235, 105);
            this.txtEmpSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.ReadOnly = true;
            this.txtEmpSurname.Size = new System.Drawing.Size(275, 30);
            this.txtEmpSurname.TabIndex = 2;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(235, 59);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(275, 30);
            this.txtEmpName.TabIndex = 1;
            // 
            // lblEmpSurname
            // 
            this.lblEmpSurname.AutoSize = true;
            this.lblEmpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSurname.Location = new System.Drawing.Point(23, 105);
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
            this.lblEmpName.Location = new System.Drawing.Point(23, 59);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(156, 25);
            this.lblEmpName.TabIndex = 12;
            this.lblEmpName.Text = "Employee Name";
            // 
            // cbTaskState
            // 
            this.cbTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaskState.FormattingEnabled = true;
            this.cbTaskState.Location = new System.Drawing.Point(235, 151);
            this.cbTaskState.Margin = new System.Windows.Forms.Padding(2);
            this.cbTaskState.Name = "cbTaskState";
            this.cbTaskState.Size = new System.Drawing.Size(275, 33);
            this.cbTaskState.TabIndex = 3;
            // 
            // lblTaskState
            // 
            this.lblTaskState.AutoSize = true;
            this.lblTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskState.Location = new System.Drawing.Point(23, 151);
            this.lblTaskState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskState.Name = "lblTaskState";
            this.lblTaskState.Size = new System.Drawing.Size(107, 25);
            this.lblTaskState.TabIndex = 17;
            this.lblTaskState.Text = "Task State";
            // 
            // txtTaskContent
            // 
            this.txtTaskContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskContent.Location = new System.Drawing.Point(235, 246);
            this.txtTaskContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskContent.Multiline = true;
            this.txtTaskContent.Name = "txtTaskContent";
            this.txtTaskContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTaskContent.Size = new System.Drawing.Size(275, 208);
            this.txtTaskContent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Content";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.Location = new System.Drawing.Point(235, 200);
            this.txtTaskTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(275, 30);
            this.txtTaskTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Title";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(366, 481);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(211, 481);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 548);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTaskContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTaskState);
            this.Controls.Add(this.lblTaskState);
            this.Controls.Add(this.txtEmpSurname);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpSurname);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpNumber);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.panel3);
            this.Name = "frmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbDepartmentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpNumber;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpSurname;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.ComboBox cbTaskState;
        private System.Windows.Forms.Label lblTaskState;
        private System.Windows.Forms.TextBox txtTaskContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}