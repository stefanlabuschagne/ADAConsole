namespace VulindlelaFTPServer
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstUserList = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartUpPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(493, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "User List";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstUserList
            // 
            this.lstUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.Password,
            this.StartUpPath});
            this.lstUserList.FullRowSelect = true;
            this.lstUserList.GridLines = true;
            this.lstUserList.Location = new System.Drawing.Point(0, 33);
            this.lstUserList.Name = "lstUserList";
            this.lstUserList.Size = new System.Drawing.Size(493, 335);
            this.lstUserList.TabIndex = 1;
            this.lstUserList.UseCompatibleStateImageBehavior = false;
            this.lstUserList.View = System.Windows.Forms.View.Details;
            this.lstUserList.DoubleClick += new System.EventHandler(this.EditUser_Click);
            // 
            // UserName
            // 
            this.UserName.Text = "User Name";
            this.UserName.Width = 120;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 120;
            // 
            // StartUpPath
            // 
            this.StartUpPath.Text = "StartUp Path";
            this.StartUpPath.Width = 300;
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(200, 100);
            this.panelBottom.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(363, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteUser
            // 
            //this.btnDeleteUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //this.btnDeleteUser.Image = global::VulindlelaFTPServer.Properties.Resources.DeleteUser;
            //this.btnDeleteUser.Location = new System.Drawing.Point(130, 9);
            //this.btnDeleteUser.Name = "btnDeleteUser";
            //this.btnDeleteUser.Size = new System.Drawing.Size(55, 55);
            //this.btnDeleteUser.TabIndex = 2;
            //this.btnDeleteUser.UseVisualStyleBackColor = true;
            //this.btnDeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditUser.Image = global::VulindlelaFTPServer.Properties.Resources.EditUser;
            this.btnEditUser.Location = new System.Drawing.Point(69, 9);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(55, 55);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNewUser.Image = global::VulindlelaFTPServer.Properties.Resources.NewUser;
            this.btnNewUser.Location = new System.Drawing.Point(8, 9);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(55, 55);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.CreateNewUser_Click);
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(493, 368);
            this.Controls.Add(this.lstUserList);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vulindlela FTP Server :: User Account";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListView lstUserList;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader StartUpPath;
        private System.Windows.Forms.Button btnCancel;

    }
}