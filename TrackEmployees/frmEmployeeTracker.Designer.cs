namespace EmployeePersonalTracker
{
    partial class frmEmployeeTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTracker));
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnPermission = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.BackgroundImage")));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEmployee.Location = new System.Drawing.Point(24, 12);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(186, 166);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalary.BackgroundImage")));
            this.btnSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalary.Location = new System.Drawing.Point(434, 184);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(185, 157);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "Salary";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTask.BackgroundImage")));
            this.btnTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.Purple;
            this.btnTask.Location = new System.Drawing.Point(227, 12);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(191, 166);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "Task";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnPermission
            // 
            this.btnPermission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPermission.BackgroundImage")));
            this.btnPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermission.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPermission.Location = new System.Drawing.Point(24, 184);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(186, 157);
            this.btnPermission.TabIndex = 3;
            this.btnPermission.Text = "Permission";
            this.btnPermission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPermission.UseVisualStyleBackColor = true;
            this.btnPermission.Click += new System.EventHandler(this.btnPermission_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepartment.BackgroundImage")));
            this.btnDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDepartment.Location = new System.Drawing.Point(227, 184);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(191, 157);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPosition.BackgroundImage")));
            this.btnPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosition.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPosition.Location = new System.Drawing.Point(434, 12);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(185, 166);
            this.btnPosition.TabIndex = 5;
            this.btnPosition.Text = "Position";
            this.btnPosition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogOut.Location = new System.Drawing.Point(312, 376);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(163, 80);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(86, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 80);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmployeeTracker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(652, 481);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnEmployee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmployeeTracker";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empolyee Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmployeeTracker_FormClosed);
            this.Load += new System.EventHandler(this.frmEmployeeTracker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnPermission;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
    }
}