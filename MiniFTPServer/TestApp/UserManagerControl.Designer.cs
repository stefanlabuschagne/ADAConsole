namespace TestApp
{
    partial class UserManagerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbUserHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRListhidden = new System.Windows.Forms.CheckBox();
            this.cbRRename = new System.Windows.Forms.CheckBox();
            this.cbRDelete = new System.Windows.Forms.CheckBox();
            this.cbRUpload = new System.Windows.Forms.CheckBox();
            this.tbUserPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbUsers);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel2.Controls.Add(this.tbUserHome);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tbUserPass);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbUserName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(462, 221);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbUsers
            // 
            this.lbUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(0, 13);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(154, 208);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(214, 130);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbUserHome
            // 
            this.tbUserHome.Location = new System.Drawing.Point(29, 132);
            this.tbUserHome.Name = "tbUserHome";
            this.tbUserHome.Size = new System.Drawing.Size(179, 20);
            this.tbUserHome.TabIndex = 6;
            this.tbUserHome.TextChanged += new System.EventHandler(this.TextfieldChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "User home:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRListhidden);
            this.groupBox1.Controls.Add(this.cbRRename);
            this.groupBox1.Controls.Add(this.cbRDelete);
            this.groupBox1.Controls.Add(this.cbRUpload);
            this.groupBox1.Location = new System.Drawing.Point(15, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rights";
            // 
            // cbRListhidden
            // 
            this.cbRListhidden.AutoSize = true;
            this.cbRListhidden.Location = new System.Drawing.Point(89, 42);
            this.cbRListhidden.Name = "cbRListhidden";
            this.cbRListhidden.Size = new System.Drawing.Size(77, 17);
            this.cbRListhidden.TabIndex = 3;
            this.cbRListhidden.Text = "List hidden";
            this.cbRListhidden.UseVisualStyleBackColor = true;
            this.cbRListhidden.CheckedChanged += new System.EventHandler(this.RightsChanges);
            // 
            // cbRRename
            // 
            this.cbRRename.AutoSize = true;
            this.cbRRename.Location = new System.Drawing.Point(14, 42);
            this.cbRRename.Name = "cbRRename";
            this.cbRRename.Size = new System.Drawing.Size(66, 17);
            this.cbRRename.TabIndex = 2;
            this.cbRRename.Text = "Rename";
            this.cbRRename.UseVisualStyleBackColor = true;
            this.cbRRename.CheckedChanged += new System.EventHandler(this.RightsChanges);
            // 
            // cbRDelete
            // 
            this.cbRDelete.AutoSize = true;
            this.cbRDelete.Location = new System.Drawing.Point(89, 19);
            this.cbRDelete.Name = "cbRDelete";
            this.cbRDelete.Size = new System.Drawing.Size(57, 17);
            this.cbRDelete.TabIndex = 1;
            this.cbRDelete.Text = "Delete";
            this.cbRDelete.UseVisualStyleBackColor = true;
            this.cbRDelete.CheckedChanged += new System.EventHandler(this.RightsChanges);
            // 
            // cbRUpload
            // 
            this.cbRUpload.AutoSize = true;
            this.cbRUpload.Location = new System.Drawing.Point(14, 19);
            this.cbRUpload.Name = "cbRUpload";
            this.cbRUpload.Size = new System.Drawing.Size(60, 17);
            this.cbRUpload.TabIndex = 0;
            this.cbRUpload.Text = "Upload";
            this.cbRUpload.UseVisualStyleBackColor = true;
            this.cbRUpload.CheckedChanged += new System.EventHandler(this.RightsChanges);
            // 
            // tbUserPass
            // 
            this.tbUserPass.Location = new System.Drawing.Point(29, 77);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.PasswordChar = '*';
            this.tbUserPass.Size = new System.Drawing.Size(260, 20);
            this.tbUserPass.TabIndex = 3;
            this.tbUserPass.TextChanged += new System.EventHandler(this.TextfieldChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Password:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(29, 29);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(260, 20);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.TextChanged += new System.EventHandler(this.TextfieldChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 38);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(253, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(128, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(3, 6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(114, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // UserManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "UserManagerControl";
            this.Size = new System.Drawing.Size(462, 259);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbUserHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbUserPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRDelete;
        private System.Windows.Forms.CheckBox cbRUpload;
        private System.Windows.Forms.CheckBox cbRRename;
        private System.Windows.Forms.CheckBox cbRListhidden;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}
