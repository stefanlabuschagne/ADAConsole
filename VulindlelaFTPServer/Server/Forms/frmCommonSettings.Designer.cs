namespace VulindlelaFTPServer
{
    partial class frmCommonSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommonSettings));
            this.chkDisplayNotifyIcon = new System.Windows.Forms.CheckBox();
            this.chkChangeFTPFoldrsIcon = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDateTimeFormat = new System.Windows.Forms.Label();
            this.txtDateTimeFormat = new System.Windows.Forms.ComboBox();
            this.lblEgDateTimeFormat = new System.Windows.Forms.Label();
            this.lblCommonSettings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkDisplayNotifyIcon
            // 
            this.chkDisplayNotifyIcon.AutoSize = true;
            this.chkDisplayNotifyIcon.Location = new System.Drawing.Point(18, 48);
            this.chkDisplayNotifyIcon.Name = "chkDisplayNotifyIcon";
            this.chkDisplayNotifyIcon.Size = new System.Drawing.Size(234, 17);
            this.chkDisplayNotifyIcon.TabIndex = 0;
            this.chkDisplayNotifyIcon.Text = "Show Notify Icon in the taskbar (conditional)";
            this.chkDisplayNotifyIcon.UseVisualStyleBackColor = true;
            // 
            // chkChangeFTPFoldrsIcon
            // 
            this.chkChangeFTPFoldrsIcon.AutoSize = true;
            this.chkChangeFTPFoldrsIcon.Location = new System.Drawing.Point(18, 71);
            this.chkChangeFTPFoldrsIcon.Name = "chkChangeFTPFoldrsIcon";
            this.chkChangeFTPFoldrsIcon.Size = new System.Drawing.Size(161, 17);
            this.chkChangeFTPFoldrsIcon.TabIndex = 1;
            this.chkChangeFTPFoldrsIcon.Text = "Change icon for FTP Folders";
            this.chkChangeFTPFoldrsIcon.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(287, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDateTimeFormat
            // 
            this.lblDateTimeFormat.AutoSize = true;
            this.lblDateTimeFormat.Location = new System.Drawing.Point(14, 97);
            this.lblDateTimeFormat.Name = "lblDateTimeFormat";
            this.lblDateTimeFormat.Size = new System.Drawing.Size(85, 13);
            this.lblDateTimeFormat.TabIndex = 0;
            this.lblDateTimeFormat.Text = "DateTimeFormat";
            // 
            // txtDateTimeFormat
            // 
            this.txtDateTimeFormat.FormattingEnabled = true;
            this.txtDateTimeFormat.Items.AddRange(new object[] {
            "dd/MM/yyyy hh:mm:sstt",
            "dd/MM/yyyy HH:mm:ss",
            "MMMM dd, yyyy hh:mm:sstt",
            "MMMM dd, yyyy HH:mm:ss"});
            this.txtDateTimeFormat.Location = new System.Drawing.Point(106, 94);
            this.txtDateTimeFormat.Name = "txtDateTimeFormat";
            this.txtDateTimeFormat.Size = new System.Drawing.Size(256, 21);
            this.txtDateTimeFormat.TabIndex = 6;
            this.txtDateTimeFormat.SelectedIndexChanged += new System.EventHandler(this.DateFormat_Changed);
            this.txtDateTimeFormat.TextUpdate += new System.EventHandler(this.DateFormat_Changed);
            this.txtDateTimeFormat.Leave += new System.EventHandler(this.txtDateTimeFormat_Leave);
            // 
            // lblEgDateTimeFormat
            // 
            this.lblEgDateTimeFormat.AutoSize = true;
            this.lblEgDateTimeFormat.Location = new System.Drawing.Point(103, 125);
            this.lblEgDateTimeFormat.Name = "lblEgDateTimeFormat";
            this.lblEgDateTimeFormat.Size = new System.Drawing.Size(31, 13);
            this.lblEgDateTimeFormat.TabIndex = 0;
            this.lblEgDateTimeFormat.Text = "(eg. )";
            // 
            // lblCommonSettings
            // 
            this.lblCommonSettings.BackColor = System.Drawing.Color.Linen;
            this.lblCommonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCommonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonSettings.Location = new System.Drawing.Point(0, 0);
            this.lblCommonSettings.Name = "lblCommonSettings";
            this.lblCommonSettings.Size = new System.Drawing.Size(374, 30);
            this.lblCommonSettings.TabIndex = 0;
            this.lblCommonSettings.Text = "Common Settings";
            this.lblCommonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCommonSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(374, 190);
            this.Controls.Add(this.lblCommonSettings);
            this.Controls.Add(this.lblEgDateTimeFormat);
            this.Controls.Add(this.txtDateTimeFormat);
            this.Controls.Add(this.lblDateTimeFormat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkChangeFTPFoldrsIcon);
            this.Controls.Add(this.chkDisplayNotifyIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCommonSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vulindlela FTP Server :: Common Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDisplayNotifyIcon;
        private System.Windows.Forms.CheckBox chkChangeFTPFoldrsIcon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDateTimeFormat;
        private System.Windows.Forms.ComboBox txtDateTimeFormat;
        private System.Windows.Forms.Label lblEgDateTimeFormat;
        private System.Windows.Forms.Label lblCommonSettings;
    }
}